// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The type DirectoryObjectGetMemberObjectsRequestBuilder.
    /// </summary>
    public partial class DirectoryObjectGetMemberObjectsRequestBuilder : BaseRequestBuilder, IDirectoryObjectGetMemberObjectsRequestBuilder
    {
    
        public DirectoryObjectGetMemberObjectsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool? securityEnabledOnly = null)
            : base(requestUrl, client)
        {
            
            this.SecurityEnabledOnly = securityEnabledOnly;

        }
    
        /// <summary>
        /// Gets the value of SecurityEnabledOnly.
        /// </summary>
        public bool? SecurityEnabledOnly { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDirectoryObjectGetMemberObjectsRequest Request(IEnumerable<Option> options = null)
        {
                
            return new DirectoryObjectGetMemberObjectsRequest(
                this.RequestUrl,
                this.Client,
                options,
                this.SecurityEnabledOnly);
        
        }

    }
}

