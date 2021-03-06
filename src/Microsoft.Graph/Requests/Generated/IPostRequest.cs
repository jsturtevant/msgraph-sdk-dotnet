// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IPostRequest.
    /// </summary>
    public partial interface IPostRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Post using PUT.
        /// </summary>
        /// <param name="postToCreate">The Post to create.</param>
        /// <returns>The created Post.</returns>
        Task<Post> CreateAsync(Post postToCreate);        /// <summary>
        /// Creates the specified Post using PUT.
        /// </summary>
        /// <param name="postToCreate">The Post to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Post.</returns>
        Task<Post> CreateAsync(Post postToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Post.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Post.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Post.
        /// </summary>
        /// <returns>The Post.</returns>
        Task<Post> GetAsync();

        /// <summary>
        /// Gets the specified Post.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Post.</returns>
        Task<Post> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Post using PATCH.
        /// </summary>
        /// <param name="postToUpdate">The Post to update.</param>
        /// <returns>The updated Post.</returns>
        Task<Post> UpdateAsync(Post postToUpdate);

        /// <summary>
        /// Updates the specified Post using PATCH.
        /// </summary>
        /// <param name="postToUpdate">The Post to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Post.</returns>
        Task<Post> UpdateAsync(Post postToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPostRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPostRequest Select(string value);
    }
}
