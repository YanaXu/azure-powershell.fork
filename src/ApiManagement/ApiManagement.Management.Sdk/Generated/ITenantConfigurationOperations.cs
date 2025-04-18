// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// TenantConfigurationOperations operations.
    /// </summary>
    public partial interface ITenantConfigurationOperations
    {
        /// <summary>
        /// This operation applies changes from the specified Git branch to the
        /// configuration database. This is a long running operation and could take
        /// several minutes to complete.
        /// </summary>
        /// <remarks>
        /// This operation applies changes from the specified Git branch to the
        /// configuration database. This is a long running operation and could take
        /// several minutes to complete.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='parameters'>
        /// Deploy Configuration parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<OperationResultContract>> DeployWithHttpMessagesAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// This operation creates a commit with the current configuration snapshot to
        /// the specified branch in the repository. This is a long running operation
        /// and could take several minutes to complete.
        /// </summary>
        /// <remarks>
        /// This operation creates a commit with the current configuration snapshot to
        /// the specified branch in the repository. This is a long running operation
        /// and could take several minutes to complete.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='parameters'>
        /// Save Configuration parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<OperationResultContract>> SaveWithHttpMessagesAsync(string resourceGroupName, string serviceName, SaveConfigurationParameter parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// This operation validates the changes in the specified Git branch. This is a
        /// long running operation and could take several minutes to complete.
        /// </summary>
        /// <remarks>
        /// This operation validates the changes in the specified Git branch. This is a
        /// long running operation and could take several minutes to complete.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='parameters'>
        /// Validate Configuration parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<OperationResultContract>> ValidateWithHttpMessagesAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the status of the most recent synchronization between the
        /// configuration database and the Git repository.
        /// </summary>
        /// <remarks>
        /// Gets the status of the most recent synchronization between the
        /// configuration database and the Git repository.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<TenantConfigurationSyncStateContract>> GetSyncStateWithHttpMessagesAsync(string resourceGroupName, string serviceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// This operation applies changes from the specified Git branch to the
        /// configuration database. This is a long running operation and could take
        /// several minutes to complete.
        /// </summary>
        /// <remarks>
        /// This operation applies changes from the specified Git branch to the
        /// configuration database. This is a long running operation and could take
        /// several minutes to complete.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='parameters'>
        /// Deploy Configuration parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<OperationResultContract>> BeginDeployWithHttpMessagesAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// This operation creates a commit with the current configuration snapshot to
        /// the specified branch in the repository. This is a long running operation
        /// and could take several minutes to complete.
        /// </summary>
        /// <remarks>
        /// This operation creates a commit with the current configuration snapshot to
        /// the specified branch in the repository. This is a long running operation
        /// and could take several minutes to complete.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='parameters'>
        /// Save Configuration parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<OperationResultContract>> BeginSaveWithHttpMessagesAsync(string resourceGroupName, string serviceName, SaveConfigurationParameter parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// This operation validates the changes in the specified Git branch. This is a
        /// long running operation and could take several minutes to complete.
        /// </summary>
        /// <remarks>
        /// This operation validates the changes in the specified Git branch. This is a
        /// long running operation and could take several minutes to complete.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='parameters'>
        /// Validate Configuration parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<OperationResultContract>> BeginValidateWithHttpMessagesAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}