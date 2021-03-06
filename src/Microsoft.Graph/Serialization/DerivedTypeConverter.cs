// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Globalization;

    /// <summary>
    /// Handles resolving interfaces to the correct derived class during serialization/deserialization.
    /// </summary>
    public class DerivedTypeConverter : JsonConverter
    {
        private TextInfo textInfo;

        internal static string assemblyName;

        static DerivedTypeConverter()
        {
            assemblyName = typeof(DerivedTypeConverter).GetTypeInfo().Assembly.FullName;
        }

        public DerivedTypeConverter()
            : base()
        {
            this.textInfo = CultureInfo.CurrentCulture.TextInfo;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Deserializes the object to the correct type.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">The interface type.</param>
        /// <param name="existingValue">The existing value of the object being read.</param>
        /// <param name="serializer">The <see cref="JsonSerializer"/> for deserialization.</param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var type = jObject.GetValue(Constants.Serialization.ODataType);

            var instance = this.Create(type == null ? objectType.AssemblyQualifiedName : type.ToString());

            // If @odata.type is set but we aren't able to create an instance of it type try using the method-provided
            // object type instead. This means unknown types will be deserialized as a parent type.
            if (instance == null && type != null)
            {
                instance = this.Create(objectType.AssemblyQualifiedName);
            }

            if (instance == null)
            {
                throw new ServiceException(
                    new Error
                    {
                        Code = GraphErrorCode.GeneralException.ToString(),
                        Message = string.Format("Unable to create an instance of type {0}.", objectType.AssemblyQualifiedName),
                    });
            }

            using (var objectReader = this.GetObjectReader(reader, jObject))
            {
                serializer.Populate(objectReader, instance);
                return instance;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private object Create(string typeString)
        {
            typeString = typeString.TrimStart('#');
            typeString = StringHelper.ConvertTypeToTitleCase(typeString);

            var type = Type.GetType(typeString);

            if (type == null)
            {
                return null;
            }

            try
            {
                // Find the default constructor. Abstract entity classes use non-public constructors.
                var constructorInfo = type.GetTypeInfo().DeclaredConstructors.FirstOrDefault(
                    constructor => !constructor.GetParameters().Any() && !constructor.IsStatic);

                if (constructorInfo == null)
                {
                    return null;
                }

                return constructorInfo.Invoke( new object[] { } );
            }
            catch (Exception exception)
            {
                throw new ServiceException(
                    new Error
                    {
                        Code = GraphErrorCode.GeneralException.ToString(),
                        Message = string.Format("Unable to create an instance of type {0}.", typeString),
                    },
                    exception);
            }
        }

        private JsonReader GetObjectReader(JsonReader originalReader, JObject jObject)
        {
            var objectReader = jObject.CreateReader();
            
            objectReader.Culture = originalReader.Culture;
            objectReader.DateParseHandling = originalReader.DateParseHandling;
            objectReader.DateTimeZoneHandling = originalReader.DateTimeZoneHandling;
            objectReader.FloatParseHandling = originalReader.FloatParseHandling;

            // This reader is only for a single token. Don't dispose the stream after.
            objectReader.CloseInput = false;

            return objectReader;
        }
    }
}
