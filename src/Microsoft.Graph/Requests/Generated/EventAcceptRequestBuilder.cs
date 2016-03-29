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
    /// The type EventAcceptRequestBuilder.
    /// </summary>
    public partial class EventAcceptRequestBuilder : BaseRequestBuilder, IEventAcceptRequestBuilder
    {
    
        public EventAcceptRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string comment = null,
            bool? sendResponse = null)
            : base(requestUrl, client)
        {
            
            this.Comment = comment;
            this.SendResponse = sendResponse;

        }
    
        /// <summary>
        /// Gets the value of Comment.
        /// </summary>
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets the value of SendResponse.
        /// </summary>
        public bool? SendResponse { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEventAcceptRequest Request(IEnumerable<Option> options = null)
        {
                
            return new EventAcceptRequest(
                this.RequestUrl,
                this.Client,
                options,
                this.Comment,
                this.SendResponse);
        
        }

    }
}
