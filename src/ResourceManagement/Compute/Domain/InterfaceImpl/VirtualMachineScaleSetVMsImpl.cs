// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;

    internal partial class VirtualMachineScaleSetVMsImpl
    {
        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <return>List of resources.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVM> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVM>.List()
        {
            return this.List() as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVM>;
        }

        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <return>List of resources.</return>
        async Task<Microsoft.Azure.Management.ResourceManager.Fluent.Core.IPagedCollection<IVirtualMachineScaleSetVM>> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVM>.ListAsync(bool loadAllPages, CancellationToken cancellationToken)
        {
            return await this.ListAsync(loadAllPages, cancellationToken) as Microsoft.Azure.Management.ResourceManager.Fluent.Core.IPagedCollection<IVirtualMachineScaleSetVM>;
        }

        /// <summary>
        /// Deletes the specified virtual machine instances from the scale set.
        /// </summary>
        /// <param name="instanceIds">Instance IDs of the virtual machine scale set instances to be deleted.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        Task Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVMsBeta.DeleteInstancesAsync(IList<string> instanceIds, CancellationToken cancellationToken)
        {
            return this.DeleteInstancesAsync(instanceIds, cancellationToken);
        }

        /// <summary>
        /// Updates the specified virtual machine instances from the scale set.
        /// </summary>
        /// <param name="instanceIds">Instance IDs of the virtual machine scale set instances to be updated.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        Task Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVMsBeta.UpdateInstancesAsync(IList<string> instanceIds, CancellationToken cancellationToken)
        {
            return this.UpdateInstancesAsync(instanceIds, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified virtual machine instances from the scale set.
        /// </summary>
        /// <param name="instanceIds">Instance IDs of the virtual machine scale set instances to be deleted.</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVMsBeta.DeleteInstances(IList<string> instanceIds)
        {
            this.DeleteInstances(instanceIds);
        }

        /// <summary>
        /// Deletes the specified virtual machine instances from the scale set.
        /// </summary>
        /// <param name="instanceIds">Instance IDs of the virtual machine scale set instances to be deleted.</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVMsBeta.DeleteInstances(params string[] instanceIds)
        {
            this.DeleteInstances(instanceIds);
        }

        /// <summary>
        /// Updates the specified virtual machine instances from the scale set.
        /// </summary>
        /// <param name="instanceIds">Instance IDs of the virtual machine scale set instances to be updated.</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVMsBeta.UpdateInstances(IList<string> instanceIds)
        {
            this.UpdateInstances(instanceIds);
        }

        /// <summary>
        /// Updates the specified virtual machine instances from the scale set.
        /// </summary>
        /// <param name="instanceIds">Instance IDs of the virtual machine scale set instances to be updated.</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSetVMsBeta.UpdateInstances(params string[] instanceIds)
        {
            this.UpdateInstances(instanceIds);
        }
    }
}