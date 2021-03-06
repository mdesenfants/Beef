/*
 * This file is automatically generated; any changes will be lost. 
 */
 
#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Beef;
using Beef.AspNetCore.WebApi;
using Beef.Entities;
using Beef.RefData;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <b>ReferenceData</b> Web API functionality.
    /// </summary>
    public partial class ReferenceDataController : ControllerBase
    {
        /// <summary> 
        /// Gets all of the <see cref="RefDataNamespace.Country"/> reference data entities that match the specified criteria.
        /// </summary>
        /// <param name="codes">The reference data code list.</param>
        /// <param name="text">The reference data text (including wildcards).</param>
        /// <returns>A <see cref="RefDataNamespace.Country"/> collection.</returns>
        [HttpGet()]
        [Route("api/v1/demo/ref/countries")]
        [ProducesResponseType(typeof(IEnumerable<RefDataNamespace.Country>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult CountryGetAll(List<string>? codes = default, string? text = default) => new WebApiGet<ReferenceDataFilterResult<RefDataNamespace.Country>>(this, 
            () => Task.FromResult(ReferenceDataFilter.ApplyFilter<RefDataNamespace.CountryCollection, RefDataNamespace.Country>(RefDataNamespace.ReferenceData.Current.Country, codes, text, includeInactive: this.IncludeInactive())),
            operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary> 
        /// Gets all of the <see cref="RefDataNamespace.USState"/> reference data entities that match the specified criteria.
        /// </summary>
        /// <param name="codes">The reference data code list.</param>
        /// <param name="text">The reference data text (including wildcards).</param>
        /// <returns>A <see cref="RefDataNamespace.USState"/> collection.</returns>
        [HttpGet()]
        [Route("api/v1/demo/ref/usStates")]
        [ProducesResponseType(typeof(IEnumerable<RefDataNamespace.USState>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult USStateGetAll(List<string>? codes = default, string? text = default) => new WebApiGet<ReferenceDataFilterResult<RefDataNamespace.USState>>(this, 
            () => Task.FromResult(ReferenceDataFilter.ApplyFilter<RefDataNamespace.USStateCollection, RefDataNamespace.USState>(RefDataNamespace.ReferenceData.Current.USState, codes, text, includeInactive: this.IncludeInactive())),
            operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary> 
        /// Gets all of the <see cref="RefDataNamespace.Gender"/> reference data entities that match the specified criteria.
        /// </summary>
        /// <param name="codes">The reference data code list.</param>
        /// <param name="text">The reference data text (including wildcards).</param>
        /// <returns>A <see cref="RefDataNamespace.Gender"/> collection.</returns>
        [HttpGet()]
        [Route("api/v1/demo/ref/genders")]
        [ProducesResponseType(typeof(IEnumerable<RefDataNamespace.Gender>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GenderGetAll(List<string>? codes = default, string? text = default) => new WebApiGet<ReferenceDataFilterResult<RefDataNamespace.Gender>>(this, 
            () => Task.FromResult(ReferenceDataFilter.ApplyFilter<RefDataNamespace.GenderCollection, RefDataNamespace.Gender>(RefDataNamespace.ReferenceData.Current.Gender, codes, text, includeInactive: this.IncludeInactive())),
            operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary> 
        /// Gets all of the <see cref="RefDataNamespace.EyeColor"/> reference data entities that match the specified criteria.
        /// </summary>
        /// <param name="codes">The reference data code list.</param>
        /// <param name="text">The reference data text (including wildcards).</param>
        /// <returns>A <see cref="RefDataNamespace.EyeColor"/> collection.</returns>
        [HttpGet()]
        [Route("api/v1/demo/ref/eyeColors")]
        [ProducesResponseType(typeof(IEnumerable<RefDataNamespace.EyeColor>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult EyeColorGetAll(List<string>? codes = default, string? text = default) => new WebApiGet<ReferenceDataFilterResult<RefDataNamespace.EyeColor>>(this, 
            () => Task.FromResult(ReferenceDataFilter.ApplyFilter<RefDataNamespace.EyeColorCollection, RefDataNamespace.EyeColor>(RefDataNamespace.ReferenceData.Current.EyeColor, codes, text, includeInactive: this.IncludeInactive())),
            operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary> 
        /// Gets all of the <see cref="RefDataNamespace.PowerSource"/> reference data entities that match the specified criteria.
        /// </summary>
        /// <param name="codes">The reference data code list.</param>
        /// <param name="text">The reference data text (including wildcards).</param>
        /// <returns>A <see cref="RefDataNamespace.PowerSource"/> collection.</returns>
        [HttpGet()]
        [Route("api/v1/demo/ref/powerSources")]
        [ProducesResponseType(typeof(IEnumerable<RefDataNamespace.PowerSource>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult PowerSourceGetAll(List<string>? codes = default, string? text = default) => new WebApiGet<ReferenceDataFilterResult<RefDataNamespace.PowerSource>>(this, 
            () => Task.FromResult(ReferenceDataFilter.ApplyFilter<RefDataNamespace.PowerSourceCollection, RefDataNamespace.PowerSource>(RefDataNamespace.ReferenceData.Current.PowerSource, codes, text, includeInactive: this.IncludeInactive())),
            operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary> 
        /// Gets all of the <see cref="RefDataNamespace.Company"/> reference data entities that match the specified criteria.
        /// </summary>
        /// <param name="codes">The reference data code list.</param>
        /// <param name="text">The reference data text (including wildcards).</param>
        /// <returns>A <see cref="RefDataNamespace.Company"/> collection.</returns>
        [HttpGet()]
        [Route("api/v1/demo/ref/companies")]
        [ProducesResponseType(typeof(IEnumerable<RefDataNamespace.Company>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult CompanyGetAll(List<string>? codes = default, string? text = default) => new WebApiGet<ReferenceDataFilterResult<RefDataNamespace.Company>>(this, 
            () => Task.FromResult(ReferenceDataFilter.ApplyFilter<RefDataNamespace.CompanyCollection, RefDataNamespace.Company>(RefDataNamespace.ReferenceData.Current.Company, codes, text, includeInactive: this.IncludeInactive())),
            operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);

        /// <summary>
        /// Gets the reference data entries for the specified entities and codes from the query string; e.g: api/v1/demo/ref?entity=codeX,codeY&amp;entity2=codeZ&amp;entity3
        /// </summary>
        /// <returns>A <see cref="ReferenceDataMultiCollection"/>.</returns>
        [HttpGet()]
        [Route("api/v1/demo/ref")]
        [ProducesResponseType(typeof(ReferenceDataMultiCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetNamed()
        {
            return new WebApiGet<ReferenceDataMultiCollection>(this, async () =>
            {
                var coll = new ReferenceDataMultiCollection();
                var inactive = this.IncludeInactive();
                var refSelection = this.ReferenceDataSelection();

                var names = refSelection.Select(x => x.Key).ToArray();
                await RefDataNamespace.ReferenceData.Current.PrefetchAsync(names).ConfigureAwait(false);

                foreach (var q in refSelection)
                {
                    switch (q.Key)
                    {
                        case var s when string.Compare(s, nameof(RefDataNamespace.Country), StringComparison.InvariantCultureIgnoreCase) == 0: coll.Add(new ReferenceDataMultiItem(nameof(RefDataNamespace.Country), ReferenceDataFilter.ApplyFilter<RefDataNamespace.CountryCollection, RefDataNamespace.Country>(RefDataNamespace.ReferenceData.Current.Country, q.Value, includeInactive: inactive))); break;
                        case var s when string.Compare(s, nameof(RefDataNamespace.USState), StringComparison.InvariantCultureIgnoreCase) == 0: coll.Add(new ReferenceDataMultiItem(nameof(RefDataNamespace.USState), ReferenceDataFilter.ApplyFilter<RefDataNamespace.USStateCollection, RefDataNamespace.USState>(RefDataNamespace.ReferenceData.Current.USState, q.Value, includeInactive: inactive))); break;
                        case var s when string.Compare(s, nameof(RefDataNamespace.Gender), StringComparison.InvariantCultureIgnoreCase) == 0: coll.Add(new ReferenceDataMultiItem(nameof(RefDataNamespace.Gender), ReferenceDataFilter.ApplyFilter<RefDataNamespace.GenderCollection, RefDataNamespace.Gender>(RefDataNamespace.ReferenceData.Current.Gender, q.Value, includeInactive: inactive))); break;
                        case var s when string.Compare(s, nameof(RefDataNamespace.EyeColor), StringComparison.InvariantCultureIgnoreCase) == 0: coll.Add(new ReferenceDataMultiItem(nameof(RefDataNamespace.EyeColor), ReferenceDataFilter.ApplyFilter<RefDataNamespace.EyeColorCollection, RefDataNamespace.EyeColor>(RefDataNamespace.ReferenceData.Current.EyeColor, q.Value, includeInactive: inactive))); break;
                        case var s when string.Compare(s, nameof(RefDataNamespace.PowerSource), StringComparison.InvariantCultureIgnoreCase) == 0: coll.Add(new ReferenceDataMultiItem(nameof(RefDataNamespace.PowerSource), ReferenceDataFilter.ApplyFilter<RefDataNamespace.PowerSourceCollection, RefDataNamespace.PowerSource>(RefDataNamespace.ReferenceData.Current.PowerSource, q.Value, includeInactive: inactive))); break;
                        case var s when string.Compare(s, nameof(RefDataNamespace.Company), StringComparison.InvariantCultureIgnoreCase) == 0: coll.Add(new ReferenceDataMultiItem(nameof(RefDataNamespace.Company), ReferenceDataFilter.ApplyFilter<RefDataNamespace.CompanyCollection, RefDataNamespace.Company>(RefDataNamespace.ReferenceData.Current.Company, q.Value, includeInactive: inactive))); break;
                    }
                }
                
                return coll;
            }, operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }
    }
}

#pragma warning restore IDE0005
#nullable restore