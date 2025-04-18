// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Extensions;

    /// <summary>Request for getting Marketplace SaaS resource details for a tenant Id</summary>
    public partial class MarketplaceSaaSResourceDetailsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IMarketplaceSaaSResourceDetailsRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IMarketplaceSaaSResourceDetailsRequestInternal
    {

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Creates an new <see cref="MarketplaceSaaSResourceDetailsRequest" /> instance.</summary>
        public MarketplaceSaaSResourceDetailsRequest()
        {

        }
    }
    /// Request for getting Marketplace SaaS resource details for a tenant Id
    public partial interface IMarketplaceSaaSResourceDetailsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IJsonSerializable
    {
        /// <summary>Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// Request for getting Marketplace SaaS resource details for a tenant Id
    internal partial interface IMarketplaceSaaSResourceDetailsRequestInternal

    {
        /// <summary>Tenant Id</summary>
        string TenantId { get; set; }

    }
}