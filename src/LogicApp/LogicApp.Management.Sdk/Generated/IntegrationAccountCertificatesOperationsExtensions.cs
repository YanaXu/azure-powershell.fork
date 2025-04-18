// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for IntegrationAccountCertificatesOperations
    /// </summary>
    public static partial class IntegrationAccountCertificatesOperationsExtensions
    {
        /// <summary>
        /// Gets a list of integration account certificates.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='top'>
        /// The number of items to be included in the result.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<IntegrationAccountCertificate> List(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, int? top = default(int?))
        {
                return ((IIntegrationAccountCertificatesOperations)operations).ListAsync(resourceGroupName, integrationAccountName, top).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of integration account certificates.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='top'>
        /// The number of items to be included in the result.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<IntegrationAccountCertificate>> ListAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, integrationAccountName, top, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets an integration account certificate.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='certificateName'>
        /// The integration account certificate name.
        /// </param>
        public static IntegrationAccountCertificate Get(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName)
        {
                return ((IIntegrationAccountCertificatesOperations)operations).GetAsync(resourceGroupName, integrationAccountName, certificateName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets an integration account certificate.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='certificateName'>
        /// The integration account certificate name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IntegrationAccountCertificate> GetAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, integrationAccountName, certificateName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or updates an integration account certificate.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='certificateName'>
        /// The integration account certificate name.
        /// </param>
        public static IntegrationAccountCertificate CreateOrUpdate(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, IntegrationAccountCertificate certificate)
        {
                return ((IIntegrationAccountCertificatesOperations)operations).CreateOrUpdateAsync(resourceGroupName, integrationAccountName, certificateName, certificate).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates an integration account certificate.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='certificateName'>
        /// The integration account certificate name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IntegrationAccountCertificate> CreateOrUpdateAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, IntegrationAccountCertificate certificate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, certificateName, certificate, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes an integration account certificate.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='certificateName'>
        /// The integration account certificate name.
        /// </param>
        public static void Delete(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName)
        {
                ((IIntegrationAccountCertificatesOperations)operations).DeleteAsync(resourceGroupName, integrationAccountName, certificateName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an integration account certificate.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='certificateName'>
        /// The integration account certificate name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, integrationAccountName, certificateName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets a list of integration account certificates.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<IntegrationAccountCertificate> ListNext(this IIntegrationAccountCertificatesOperations operations, string nextPageLink)
        {
                return ((IIntegrationAccountCertificatesOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of integration account certificates.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<IntegrationAccountCertificate>> ListNextAsync(this IIntegrationAccountCertificatesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
