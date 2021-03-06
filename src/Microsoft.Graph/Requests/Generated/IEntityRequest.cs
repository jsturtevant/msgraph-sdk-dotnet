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
    /// The interface IEntityRequest.
    /// </summary>
    public partial interface IEntityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Entity using PUT.
        /// </summary>
        /// <param name="entityToCreate">The Entity to create.</param>
        /// <returns>The created Entity.</returns>
        Task<Entity> CreateAsync(Entity entityToCreate);        /// <summary>
        /// Creates the specified Entity using PUT.
        /// </summary>
        /// <param name="entityToCreate">The Entity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Entity.</returns>
        Task<Entity> CreateAsync(Entity entityToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Entity.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Entity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Entity.
        /// </summary>
        /// <returns>The Entity.</returns>
        Task<Entity> GetAsync();

        /// <summary>
        /// Gets the specified Entity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Entity.</returns>
        Task<Entity> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Entity using PATCH.
        /// </summary>
        /// <param name="entityToUpdate">The Entity to update.</param>
        /// <returns>The updated Entity.</returns>
        Task<Entity> UpdateAsync(Entity entityToUpdate);

        /// <summary>
        /// Updates the specified Entity using PATCH.
        /// </summary>
        /// <param name="entityToUpdate">The Entity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Entity.</returns>
        Task<Entity> UpdateAsync(Entity entityToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEntityRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEntityRequest Select(string value);
    }
}
