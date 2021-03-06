// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserMessagesCollectionRequestBuilder.
    /// </summary>
    public partial class UserMessagesCollectionRequestBuilder : BaseRequestBuilder, IUserMessagesCollectionRequestBuilder
    {  
        /// <summary>
        /// Constructs a new UserMessagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserMessagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserMessagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserMessagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserMessagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMessageRequestBuilder"/> for the specified UserMessage.
        /// </summary>
        /// <param name="id">The ID for the UserMessage.</param>
        /// <returns>The <see cref="IMessageRequestBuilder"/>.</returns>
        public IMessageRequestBuilder this[string id]
        {
            get
            {
                return new MessageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
