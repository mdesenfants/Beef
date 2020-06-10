/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Entities;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.Data
{
    /// <summary>
    /// Defines the Trip Person data access.
    /// </summary>
    public partial interface ITripPersonData
    {
        /// <summary>
        /// Gets the <see cref="TripPerson"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        /// <returns>The selected <see cref="TripPerson"/> object where found; otherwise, <c>null</c>.</returns>
        Task<TripPerson?> GetAsync(string? id);

        /// <summary>
        /// Creates the <see cref="TripPerson"/> object.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/> object.</param>
        /// <returns>A refreshed <see cref="TripPerson"/> object.</returns>
        Task<TripPerson> CreateAsync(TripPerson value);

        /// <summary>
        /// Updates the <see cref="TripPerson"/> object.
        /// </summary>
        /// <param name="value">The <see cref="TripPerson"/> object.</param>
        /// <returns>A refreshed <see cref="TripPerson"/> object.</returns>
        Task<TripPerson> UpdateAsync(TripPerson value);

        /// <summary>
        /// Deletes the <see cref="TripPerson"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="TripPerson"/> identifier (username).</param>
        Task DeleteAsync(string? id);
    }
}

#pragma warning restore IDE0005
#nullable restore