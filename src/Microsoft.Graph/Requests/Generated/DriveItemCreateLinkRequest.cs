// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type DriveItemCreateLinkRequest.
    /// </summary>
    public partial class DriveItemCreateLinkRequest : BaseRequest, IDriveItemCreateLinkRequest
    {
    
        /// <summary>
        /// Constructs a new DriveItemCreateLinkRequest.
        /// </summary>
        public DriveItemCreateLinkRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options,
            string type = null,
            string scope = null)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new DriveItemCreateLinkRequestBody();
            this.RequestBody.Type = type;
            this.RequestBody.Scope = scope;
        }
    
        /// <summary>
        /// Gets the request body.
        /// </summary>
        public DriveItemCreateLinkRequestBody RequestBody { get; private set; }
    
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public Task<Permission> PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>ThePermission</returns>
        public Task<Permission> PostAsync(CancellationToken cancellationToken)
        {
    
            return this.SendAsync<Permission>(this.RequestBody, cancellationToken);
    
        }
    
        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDriveItemCreateLinkRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDriveItemCreateLinkRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    
    }
}
