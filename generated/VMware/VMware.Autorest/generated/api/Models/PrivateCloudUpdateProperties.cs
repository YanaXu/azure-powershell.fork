// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The properties of a private cloud resource that may be updated</summary>
    public partial class PrivateCloudUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Availability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityProperties _availability;

        /// <summary>Properties describing how the cloud is distributed across availability zones</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityProperties Availability { get => (this._availability = this._availability ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.AvailabilityProperties()); set => this._availability = value; }

        /// <summary>The secondary availability zone for the private cloud</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public int? AvailabilitySecondaryZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityPropertiesInternal)Availability).SecondaryZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityPropertiesInternal)Availability).SecondaryZone = value ?? default(int); }

        /// <summary>The availability strategy for the private cloud</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string AvailabilityStrategy { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityPropertiesInternal)Availability).Strategy; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityPropertiesInternal)Availability).Strategy = value ?? null; }

        /// <summary>The primary availability zone for the private cloud</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public int? AvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityPropertiesInternal)Availability).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityPropertiesInternal)Availability).Zone = value ?? default(int); }

        /// <summary>Backing field for <see cref="DnsZoneType" /> property.</summary>
        private string _dnsZoneType;

        /// <summary>The type of DNS zone to use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string DnsZoneType { get => this._dnsZoneType; set => this._dnsZoneType = value; }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryption _encryption;

        /// <summary>Customer managed key encryption, can be enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryption Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Encryption()); set => this._encryption = value; }

        /// <summary>Status of customer managed encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string EncryptionStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).Status = value ?? null; }

        /// <summary>Backing field for <see cref="ExtendedNetworkBlock" /> property.</summary>
        private System.Collections.Generic.List<string> _extendedNetworkBlock;

        /// <summary>
        /// Array of additional networks noncontiguous with networkBlock. Networks must be
        /// unique and non-overlapping across VNet in your subscription, on-premise, and
        /// this privateCloud networkBlock attribute. Make sure the CIDR format conforms to
        /// (A.B.C.D/X).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ExtendedNetworkBlock { get => this._extendedNetworkBlock; set => this._extendedNetworkBlock = value; }

        /// <summary>Backing field for <see cref="IdentitySource" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IIdentitySource> _identitySource;

        /// <summary>vCenter Single Sign On Identity Sources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IIdentitySource> IdentitySource { get => this._identitySource; set => this._identitySource = value; }

        /// <summary>Backing field for <see cref="Internet" /> property.</summary>
        private string _internet;

        /// <summary>Connectivity to internet is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string Internet { get => this._internet; set => this._internet = value; }

        /// <summary>The auto-detected version of the key if versionType is auto-detected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyAutoDetectedKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyAutoDetectedKeyVersion; }

        /// <summary>The name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyName = value ?? null; }

        /// <summary>The state of key provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyState; }

        /// <summary>The URL of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVaultUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyVaultUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyVaultUrl = value ?? null; }

        /// <summary>The version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyVersion = value ?? null; }

        /// <summary>Property of the key if user provided or auto detected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyVersionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyVersionType; }

        /// <summary>Backing field for <see cref="ManagementCluster" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementCluster _managementCluster;

        /// <summary>The default cluster used for management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementCluster ManagementCluster { get => (this._managementCluster = this._managementCluster ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.ManagementCluster()); set => this._managementCluster = value; }

        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ManagementClusterHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).Host; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).Host = value ?? null /* arrayOf */; }

        /// <summary>The identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public int? ManagementClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ClusterId; }

        /// <summary>The state of the cluster provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string ManagementClusterProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ProvisioningState; }

        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public int? ManagementClusterSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ClusterSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ClusterSize = value ?? default(int); }

        /// <summary>Name of the vsan datastore associated with the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string ManagementClusterVsanDatastoreName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).VsanDatastoreName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).VsanDatastoreName = value ?? null; }

        /// <summary>Internal Acessors for Availability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityProperties Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.Availability { get => (this._availability = this._availability ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.AvailabilityProperties()); set { {_availability = value;} } }

        /// <summary>Internal Acessors for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryption Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.Encryption { get => (this._encryption = this._encryption ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Encryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.EncryptionKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for KeyVaultPropertyAutoDetectedKeyVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.KeyVaultPropertyAutoDetectedKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyAutoDetectedKeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyAutoDetectedKeyVersion = value ?? null; }

        /// <summary>Internal Acessors for KeyVaultPropertyKeyState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.KeyVaultPropertyKeyState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyKeyState = value ?? null; }

        /// <summary>Internal Acessors for KeyVaultPropertyVersionType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.KeyVaultPropertyVersionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyVersionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionInternal)Encryption).KeyVaultPropertyVersionType = value ?? null; }

        /// <summary>Internal Acessors for ManagementCluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementCluster Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.ManagementCluster { get => (this._managementCluster = this._managementCluster ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.ManagementCluster()); set { {_managementCluster = value;} } }

        /// <summary>Internal Acessors for ManagementClusterId</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.ManagementClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ClusterId = value ?? default(int); }

        /// <summary>Internal Acessors for ManagementClusterProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IPrivateCloudUpdatePropertiesInternal.ManagementClusterProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementClusterInternal)ManagementCluster).ProvisioningState = value ?? null; }

        /// <summary>Creates an new <see cref="PrivateCloudUpdateProperties" /> instance.</summary>
        public PrivateCloudUpdateProperties()
        {

        }
    }
    /// The properties of a private cloud resource that may be updated
    public partial interface IPrivateCloudUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>The secondary availability zone for the private cloud</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The secondary availability zone for the private cloud",
        SerializedName = @"secondaryZone",
        PossibleTypes = new [] { typeof(int) })]
        int? AvailabilitySecondaryZone { get; set; }
        /// <summary>The availability strategy for the private cloud</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The availability strategy for the private cloud",
        SerializedName = @"strategy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("SingleZone", "DualZone")]
        string AvailabilityStrategy { get; set; }
        /// <summary>The primary availability zone for the private cloud</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The primary availability zone for the private cloud",
        SerializedName = @"zone",
        PossibleTypes = new [] { typeof(int) })]
        int? AvailabilityZone { get; set; }
        /// <summary>The type of DNS zone to use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of DNS zone to use.",
        SerializedName = @"dnsZoneType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Public", "Private")]
        string DnsZoneType { get; set; }
        /// <summary>Status of customer managed encryption key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of customer managed encryption key",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionStatus { get; set; }
        /// <summary>
        /// Array of additional networks noncontiguous with networkBlock. Networks must be
        /// unique and non-overlapping across VNet in your subscription, on-premise, and
        /// this privateCloud networkBlock attribute. Make sure the CIDR format conforms to
        /// (A.B.C.D/X).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of additional networks noncontiguous with networkBlock. Networks must be
        unique and non-overlapping across VNet in your subscription, on-premise, and
        this privateCloud networkBlock attribute. Make sure the CIDR format conforms to
        (A.B.C.D/X).",
        SerializedName = @"extendedNetworkBlocks",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ExtendedNetworkBlock { get; set; }
        /// <summary>vCenter Single Sign On Identity Sources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"vCenter Single Sign On Identity Sources",
        SerializedName = @"identitySources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IIdentitySource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IIdentitySource> IdentitySource { get; set; }
        /// <summary>Connectivity to internet is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Connectivity to internet is enabled or disabled",
        SerializedName = @"internet",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Internet { get; set; }
        /// <summary>The auto-detected version of the key if versionType is auto-detected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The auto-detected version of the key if versionType is auto-detected.",
        SerializedName = @"autoDetectedKeyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyAutoDetectedKeyVersion { get;  }
        /// <summary>The name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The state of key provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The state of key provided",
        SerializedName = @"keyState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Connected", "AccessDenied")]
        string KeyVaultPropertyKeyState { get;  }
        /// <summary>The URL of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL of the vault.",
        SerializedName = @"keyVaultUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVaultUrl { get; set; }
        /// <summary>The version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The version of the key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>Property of the key if user provided or auto detected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Property of the key if user provided or auto detected",
        SerializedName = @"versionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Fixed", "AutoDetected")]
        string KeyVaultPropertyVersionType { get;  }
        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The hosts",
        SerializedName = @"hosts",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ManagementClusterHost { get; set; }
        /// <summary>The identity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity",
        SerializedName = @"clusterId",
        PossibleTypes = new [] { typeof(int) })]
        int? ManagementClusterId { get;  }
        /// <summary>The state of the cluster provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The state of the cluster provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Cancelled", "Deleting", "Updating")]
        string ManagementClusterProvisioningState { get;  }
        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cluster size",
        SerializedName = @"clusterSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ManagementClusterSize { get; set; }
        /// <summary>Name of the vsan datastore associated with the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the vsan datastore associated with the cluster",
        SerializedName = @"vsanDatastoreName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagementClusterVsanDatastoreName { get; set; }

    }
    /// The properties of a private cloud resource that may be updated
    internal partial interface IPrivateCloudUpdatePropertiesInternal

    {
        /// <summary>Properties describing how the cloud is distributed across availability zones</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IAvailabilityProperties Availability { get; set; }
        /// <summary>The secondary availability zone for the private cloud</summary>
        int? AvailabilitySecondaryZone { get; set; }
        /// <summary>The availability strategy for the private cloud</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("SingleZone", "DualZone")]
        string AvailabilityStrategy { get; set; }
        /// <summary>The primary availability zone for the private cloud</summary>
        int? AvailabilityZone { get; set; }
        /// <summary>The type of DNS zone to use.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Public", "Private")]
        string DnsZoneType { get; set; }
        /// <summary>Customer managed key encryption, can be enabled or disabled</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryption Encryption { get; set; }
        /// <summary>The key vault where the encryption key is stored</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IEncryptionKeyVaultProperties EncryptionKeyVaultProperty { get; set; }
        /// <summary>Status of customer managed encryption key</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionStatus { get; set; }
        /// <summary>
        /// Array of additional networks noncontiguous with networkBlock. Networks must be
        /// unique and non-overlapping across VNet in your subscription, on-premise, and
        /// this privateCloud networkBlock attribute. Make sure the CIDR format conforms to
        /// (A.B.C.D/X).
        /// </summary>
        System.Collections.Generic.List<string> ExtendedNetworkBlock { get; set; }
        /// <summary>vCenter Single Sign On Identity Sources</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IIdentitySource> IdentitySource { get; set; }
        /// <summary>Connectivity to internet is enabled or disabled</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Internet { get; set; }
        /// <summary>The auto-detected version of the key if versionType is auto-detected.</summary>
        string KeyVaultPropertyAutoDetectedKeyVersion { get; set; }
        /// <summary>The name of the key.</summary>
        string KeyVaultPropertyKeyName { get; set; }
        /// <summary>The state of key provided</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Connected", "AccessDenied")]
        string KeyVaultPropertyKeyState { get; set; }
        /// <summary>The URL of the vault.</summary>
        string KeyVaultPropertyKeyVaultUrl { get; set; }
        /// <summary>The version of the key.</summary>
        string KeyVaultPropertyKeyVersion { get; set; }
        /// <summary>Property of the key if user provided or auto detected</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Fixed", "AutoDetected")]
        string KeyVaultPropertyVersionType { get; set; }
        /// <summary>The default cluster used for management</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IManagementCluster ManagementCluster { get; set; }
        /// <summary>The hosts</summary>
        System.Collections.Generic.List<string> ManagementClusterHost { get; set; }
        /// <summary>The identity</summary>
        int? ManagementClusterId { get; set; }
        /// <summary>The state of the cluster provisioning</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.VMware.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Cancelled", "Deleting", "Updating")]
        string ManagementClusterProvisioningState { get; set; }
        /// <summary>The cluster size</summary>
        int? ManagementClusterSize { get; set; }
        /// <summary>Name of the vsan datastore associated with the cluster</summary>
        string ManagementClusterVsanDatastoreName { get; set; }

    }
}