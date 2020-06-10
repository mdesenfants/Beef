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
using Beef.Business;
using Beef.Entities;
using Beef.Validation;
using Beef.Demo.Common.Entities;
using Beef.Demo.Business.Validation;
using Beef.Demo.Business.DataSvc;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business
{
    /// <summary>
    /// Provides the Robot business functionality.
    /// </summary>
    public partial class RobotManager : IRobotManager
    {
        #region Private
        #pragma warning disable CS0649 // Defaults to null by design; can be overridden in constructor.

        private readonly Func<Guid, Task>? _getOnPreValidateAsync;
        private readonly Action<MultiValidator, Guid>? _getOnValidate;
        private readonly Func<Guid, Task>? _getOnBeforeAsync;
        private readonly Func<Robot?, Guid, Task>? _getOnAfterAsync;

        private readonly Func<Robot, Task>? _createOnPreValidateAsync;
        private readonly Action<MultiValidator, Robot>? _createOnValidate;
        private readonly Func<Robot, Task>? _createOnBeforeAsync;
        private readonly Func<Robot, Task>? _createOnAfterAsync;

        private readonly Func<Robot, Guid, Task>? _updateOnPreValidateAsync;
        private readonly Action<MultiValidator, Robot, Guid>? _updateOnValidate;
        private readonly Func<Robot, Guid, Task>? _updateOnBeforeAsync;
        private readonly Func<Robot, Guid, Task>? _updateOnAfterAsync;

        private readonly Func<Guid, Task>? _deleteOnPreValidateAsync;
        private readonly Action<MultiValidator, Guid>? _deleteOnValidate;
        private readonly Func<Guid, Task>? _deleteOnBeforeAsync;
        private readonly Func<Guid, Task>? _deleteOnAfterAsync;

        private readonly Func<RobotArgs?, PagingArgs?, Task>? _getByArgsOnPreValidateAsync;
        private readonly Action<MultiValidator, RobotArgs?, PagingArgs?>? _getByArgsOnValidate;
        private readonly Func<RobotArgs?, PagingArgs?, Task>? _getByArgsOnBeforeAsync;
        private readonly Func<RobotCollectionResult, RobotArgs?, PagingArgs?, Task>? _getByArgsOnAfterAsync;

        #pragma warning restore CS0649
        #endregion

        /// <summary>
        /// Gets the <see cref="Robot"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <returns>The selected <see cref="Robot"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<Robot?> GetAsync(Guid id)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Read;
                EntityBase.CleanUp(id);
                if (_getOnPreValidateAsync != null) await _getOnPreValidateAsync(id).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(id.Validate(nameof(id)).Mandatory())
                    .Additional((__mv) => _getOnValidate?.Invoke(__mv, id))
                    .Run().ThrowOnError();

                if (_getOnBeforeAsync != null) await _getOnBeforeAsync(id).ConfigureAwait(false);
                var __result = await RobotDataSvc.GetAsync(id).ConfigureAwait(false);
                if (_getOnAfterAsync != null) await _getOnAfterAsync(__result, id).ConfigureAwait(false);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Creates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <returns>A refreshed <see cref="Robot"/> object.</returns>
        public Task<Robot> CreateAsync(Robot value)
        {
            value.Validate(nameof(value)).Mandatory().Run().ThrowOnError();

            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Create;
                EntityBase.CleanUp(value);
                if (_createOnPreValidateAsync != null) await _createOnPreValidateAsync(value).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(value.Validate(nameof(value)).Entity(RobotValidator.Default))
                    .Additional((__mv) => _createOnValidate?.Invoke(__mv, value))
                    .Run().ThrowOnError();

                if (_createOnBeforeAsync != null) await _createOnBeforeAsync(value).ConfigureAwait(false);
                var __result = await RobotDataSvc.CreateAsync(value).ConfigureAwait(false);
                if (_createOnAfterAsync != null) await _createOnAfterAsync(__result).ConfigureAwait(false);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Updates the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Robot"/> object.</param>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <returns>A refreshed <see cref="Robot"/> object.</returns>
        public Task<Robot> UpdateAsync(Robot value, Guid id)
        {
            value.Validate(nameof(value)).Mandatory().Run().ThrowOnError();

            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Update;
                value.Id = id;
                EntityBase.CleanUp(value, id);
                if (_updateOnPreValidateAsync != null) await _updateOnPreValidateAsync(value, id).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(value.Validate(nameof(value)).Entity(RobotValidator.Default))
                    .Additional((__mv) => _updateOnValidate?.Invoke(__mv, value, id))
                    .Run().ThrowOnError();

                if (_updateOnBeforeAsync != null) await _updateOnBeforeAsync(value, id).ConfigureAwait(false);
                var __result = await RobotDataSvc.UpdateAsync(value).ConfigureAwait(false);
                if (_updateOnAfterAsync != null) await _updateOnAfterAsync(__result, id).ConfigureAwait(false);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Deletes the <see cref="Robot"/> object.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        public Task DeleteAsync(Guid id)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Delete;
                EntityBase.CleanUp(id);
                if (_deleteOnPreValidateAsync != null) await _deleteOnPreValidateAsync(id).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(id.Validate(nameof(id)).Mandatory())
                    .Additional((__mv) => _deleteOnValidate?.Invoke(__mv, id))
                    .Run().ThrowOnError();

                if (_deleteOnBeforeAsync != null) await _deleteOnBeforeAsync(id).ConfigureAwait(false);
                await RobotDataSvc.DeleteAsync(id).ConfigureAwait(false);
                if (_deleteOnAfterAsync != null) await _deleteOnAfterAsync(id).ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Gets the <see cref="Robot"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="RobotArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="RobotCollectionResult"/>.</returns>
        public Task<RobotCollectionResult> GetByArgsAsync(RobotArgs? args, PagingArgs? paging)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Read;
                EntityBase.CleanUp(args);
                if (_getByArgsOnPreValidateAsync != null) await _getByArgsOnPreValidateAsync(args, paging).ConfigureAwait(false);

                MultiValidator.Create()
                    .Add(args.Validate(nameof(args)).Entity(RobotArgsValidator.Default))
                    .Additional((__mv) => _getByArgsOnValidate?.Invoke(__mv, args, paging))
                    .Run().ThrowOnError();

                if (_getByArgsOnBeforeAsync != null) await _getByArgsOnBeforeAsync(args, paging).ConfigureAwait(false);
                var __result = await RobotDataSvc.GetByArgsAsync(args, paging).ConfigureAwait(false);
                if (_getByArgsOnAfterAsync != null) await _getByArgsOnAfterAsync(__result, args, paging).ConfigureAwait(false);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Raises a <see cref="Robot.PowerSource"/> change event.
        /// </summary>
        /// <param name="id">The <see cref="Robot"/> identifier.</param>
        /// <param name="powerSource">The Power Source (see <see cref="RefDataNamespace.PowerSource"/>).</param>
        public Task RaisePowerSourceChangeAsync(Guid id, RefDataNamespace.PowerSource? powerSource)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Unspecified;
                await RaisePowerSourceChangeOnImplementationAsync(id, powerSource).ConfigureAwait(false);
            });
        }
    }
}

#pragma warning restore IDE0005
#nullable restore