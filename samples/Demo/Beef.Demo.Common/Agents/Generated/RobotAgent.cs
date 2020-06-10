/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Beef;
using Beef.Entities;
using Beef.WebApi;
using Newtonsoft.Json.Linq;
using Beef.Demo.Common.Entities;
using Beef.Demo.Common.Agents.ServiceAgents;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Agents
{
    /// <summary>
    /// Provides the Robot Web API agent.
    /// </summary>
    public partial class RobotAgent : WebApiAgentBase, IRobotServiceAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotAgent"/> class.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> (where overridding the default value).</param>
        /// <param name="beforeRequest">The <see cref="Action{HttpRequestMessage}"/> to invoke before the <see cref="HttpRequestMessage">Http Request</see> is made (see <see cref="WebApiServiceAgentBase.BeforeRequest"/>).</param>
        public RobotAgent(HttpClient? httpClient = null, Action<HttpRequestMessage>? beforeRequest = null)
        {
            RobotServiceAgent = Beef.Factory.Create<IRobotServiceAgent>(httpClient, beforeRequest);
        }
        
        /// <summary>
        /// Gets the underlyng <see cref="IRobotServiceAgent"/> instance.
        /// </summary>
        public IRobotServiceAgent RobotServiceAgent { get; private set; }

        /// <summary>
        /// Gets the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> GetAsync(Guid id, WebApiRequestOptions? requestOptions = null)
            => RobotServiceAgent.GetAsync(id, requestOptions);

        /// <summary>
        /// Creates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> CreateAsync(Robot value, WebApiRequestOptions? requestOptions = null)
            => RobotServiceAgent.CreateAsync(Check.NotNull(value, nameof(value)), requestOptions);

        /// <summary>
        /// Updates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> UpdateAsync(Robot value, Guid id, WebApiRequestOptions? requestOptions = null)
            => RobotServiceAgent.UpdateAsync(Check.NotNull(value, nameof(value)), id, requestOptions);

        /// <summary>
        /// Patches the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="patchOption">The <see cref="WebApiPatchOption"/>.</param>
        /// <param name="value">The JSON patch value.</param>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Robot>> PatchAsync(WebApiPatchOption patchOption, JToken value, Guid id, WebApiRequestOptions? requestOptions = null)
            => RobotServiceAgent.PatchAsync(patchOption, value, id, requestOptions);

        /// <summary>
        /// Deletes the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> DeleteAsync(Guid id, WebApiRequestOptions? requestOptions = null)
            => RobotServiceAgent.DeleteAsync(id, requestOptions);

        /// <summary>
        /// Gets the <see cref="Robot"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="RobotArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<RobotCollectionResult>> GetByArgsAsync(RobotArgs? args, PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null)
            => RobotServiceAgent.GetByArgsAsync(args, paging, requestOptions);

        /// <summary>
        /// Raises a <see cref="Robot.PowerSource"/> change event.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="powerSource">The Power Source (see <see cref="RefDataNamespace.PowerSource"/>).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> RaisePowerSourceChangeAsync(Guid id, RefDataNamespace.PowerSource? powerSource, WebApiRequestOptions? requestOptions = null)
            => RobotServiceAgent.RaisePowerSourceChangeAsync(id, powerSource, requestOptions);
    }
}

#pragma warning restore IDE0005
#nullable restore