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
    /// Defines the Product data access.
    /// </summary>
    public partial interface IProductData
    {
        /// <summary>
        /// Gets the <see cref="Product"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Product"/> identifier.</param>
        /// <returns>The selected <see cref="Product"/> object where found; otherwise, <c>null</c>.</returns>
        Task<Product?> GetAsync(int id);

        /// <summary>
        /// Gets the <see cref="Product"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="ProductArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="ProductCollectionResult"/>.</returns>
        Task<ProductCollectionResult> GetByArgsAsync(ProductArgs? args, PagingArgs? paging);
    }
}

#pragma warning restore IDE0005
#nullable restore