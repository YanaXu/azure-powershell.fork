// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.Extensions;

    /// <summary>The type used for update operations of the Instance Resource.</summary>
    public partial class InstanceResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdate _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdate Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.AzureResourceManagerCommonTypesManagedServiceIdentityUpdate()); set => this._identity = value; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdate Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.AzureResourceManagerCommonTypesManagedServiceIdentityUpdate()); set { {_identity = value;} } }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdateTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.InstanceResourceUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="InstanceResourceUpdate" /> instance.</summary>
        public InstanceResourceUpdate()
        {

        }
    }
    /// The type used for update operations of the Instance Resource.
    public partial interface IInstanceResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.IJsonSerializable
    {
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdateTags Tag { get; set; }

    }
    /// The type used for update operations of the Instance Resource.
    internal partial interface IInstanceResourceUpdateInternal

    {
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdate Identity { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IAzureResourceManagerCommonTypesManagedServiceIdentityUpdateUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceUpdateTags Tag { get; set; }

    }
}