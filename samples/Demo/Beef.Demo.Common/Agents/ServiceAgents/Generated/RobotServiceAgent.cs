/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Beef.Entities;
using Beef.WebApi;
using Newtonsoft.Json.Linq;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Agents.ServiceAgents
{
    /// <summary>
    /// Defines the Robot Web API service agent.
    /// </summary>
    public partial interface IRobotServiceAgent
    {
        /// <summary>
        /// Gets the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Robot>> GetAsync(Guid id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Creates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Robot>> CreateAsync(Robot value, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Updates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Robot>> UpdateAsync(Robot value, Guid id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Patches the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="patchOption">The <see cref="WebApiPatchOption"/>.</param>
        /// <param name="value">The JSON patch value.</param>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<Robot>> PatchAsync(WebApiPatchOption patchOption, JToken value, Guid id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Deletes the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult> DeleteAsync(Guid id, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Gets the <see cref="Robot"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="RobotArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult<RobotCollectionResult>> GetByArgsAsync(RobotArgs? args, PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null);

        /// <summary>
        /// Raises a <see cref="Robot.PowerSource"/> change event.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="powerSource">The Power Source (see <see cref="RefDataNamespace.PowerSource"/>).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        Task<WebApiAgentResult> RaisePowerSourceChangeAsync(Guid id, RefDataNamespace.PowerSource? powerSource, WebApiRequestOptions? requestOptions = null);
    }

    /// <summary>
    /// Provides the Robot Web API service agent.
    /// </summary>
    public partial class RobotServiceAgent : WebApiServiceAgentBase<RobotServiceAgent>, IRobotServiceAgent
    {
        /// <summary>
        /// Static constructor.
        /// </summary>
        static RobotServiceAgent()
        {
            Register(() =>
            {
                var rd = WebApiServiceAgentManager.Get<RobotServiceAgent>();
                return rd == null ? null : new RobotServiceAgent(rd.Client, rd.BeforeRequest!);
            }, false);
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotServiceAgent"/> class with a <paramref name="httpClient"/>.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
        /// <param name="beforeRequest">The <see cref="Action{HttpRequestMessage}"/> to invoke before the <see cref="HttpRequestMessage">Http Request</see> is made (see <see cref="WebApiServiceAgentBase.BeforeRequest"/>).</param>
        public RobotServiceAgent(HttpClient? httpClient = null, Action<HttpRequestMessage>? beforeRequest = null) : base(httpClient, beforeRequest) { }

        /// <summary>
        /// Gets the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> GetAsync(Guid id, WebApiRequestOptions? requestOptions = null)
        {
            return base.GetAsync<Robot>("api/v1/robots/{id}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id) });
        }

        /// <summary>
        /// Creates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> CreateAsync(Robot value, WebApiRequestOptions? requestOptions = null)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            return base.PostAsync<Robot>("api/v1/robots", value, requestOptions: requestOptions,
                args: new WebApiArg[] { });
        }

        /// <summary>
        /// Updates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> UpdateAsync(Robot value, Guid id, WebApiRequestOptions? requestOptions = null)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            return base.PutAsync<Robot>("api/v1/robots/{id}", value, requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id) });
        }

        /// <summary>
        /// Patches the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="patchOption">The <see cref="WebApiPatchOption"/>.</param>
        /// <param name="value">The JSON patch value.</param>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> PatchAsync(WebApiPatchOption patchOption, JToken value, Guid id, WebApiRequestOptions? requestOptions = null)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            return base.PatchAsync<Robot>("api/v1/robots/{id}", patchOption, value, requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id) });
        }

        /// <summary>
        /// Deletes the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> DeleteAsync(Guid id, WebApiRequestOptions? requestOptions = null)
        {
            return base.DeleteAsync("api/v1/robots/{id}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id) });
        }

        /// <summary>
        /// Gets the <see cref="Robot"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="RobotArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RobotCollectionResult>> GetByArgsAsync(RobotArgs? args, PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null)
        {
            return base.GetCollectionResultAsync<RobotCollectionResult, RobotCollection, Robot>("api/v1/robots", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<RobotArgs?>("args", args, WebApiArgType.FromUriUseProperties), new WebApiPagingArgsArg("paging", paging) });
        }

        /// <summary>
        /// Raises a <see cref="Robot.PowerSource"/> change event.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="powerSource">The Power Source (see <see cref="RefDataNamespace.PowerSource"/>).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> RaisePowerSourceChangeAsync(Guid id, RefDataNamespace.PowerSource? powerSource, WebApiRequestOptions? requestOptions = null)
        {
            return base.PostAsync("api/v1/robots/{id}/powerSource/{powerSource}", requestOptions: requestOptions,
                args: new WebApiArg[] { new WebApiArg<Guid>("id", id), new WebApiArg<RefDataNamespace.PowerSource?>("powerSource", powerSource) });
        }
    }
}

#pragma warning restore IDE0005
#nullable restore