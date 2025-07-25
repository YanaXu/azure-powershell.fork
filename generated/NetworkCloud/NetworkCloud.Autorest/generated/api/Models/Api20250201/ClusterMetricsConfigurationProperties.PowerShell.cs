// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.PowerShell;

    /// <summary>
    /// ClusterMetricsConfigurationProperties represents the properties of metrics configuration for the cluster.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterMetricsConfigurationPropertiesTypeConverter))]
    public partial class ClusterMetricsConfigurationProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterMetricsConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClusterMetricsConfigurationProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CollectionInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).CollectionInterval = (long) content.GetValueForProperty("CollectionInterval",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).CollectionInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DetailedStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus?) content.GetValueForProperty("DetailedStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus.CreateFrom);
            }
            if (content.Contains("DetailedStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatusMessage = (string) content.GetValueForProperty("DetailedStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("DisabledMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DisabledMetric = (string[]) content.GetValueForProperty("DisabledMetric",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DisabledMetric, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EnabledMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).EnabledMetric = (string[]) content.GetValueForProperty("EnabledMetric",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).EnabledMetric, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterMetricsConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClusterMetricsConfigurationProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CollectionInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).CollectionInterval = (long) content.GetValueForProperty("CollectionInterval",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).CollectionInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DetailedStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus?) content.GetValueForProperty("DetailedStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationDetailedStatus.CreateFrom);
            }
            if (content.Contains("DetailedStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatusMessage = (string) content.GetValueForProperty("DetailedStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DetailedStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("DisabledMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DisabledMetric = (string[]) content.GetValueForProperty("DisabledMetric",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).DisabledMetric, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EnabledMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).EnabledMetric = (string[]) content.GetValueForProperty("EnabledMetric",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).EnabledMetric, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ClusterMetricsConfigurationProvisioningState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterMetricsConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClusterMetricsConfigurationProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterMetricsConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClusterMetricsConfigurationProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClusterMetricsConfigurationProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ClusterMetricsConfigurationProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// ClusterMetricsConfigurationProperties represents the properties of metrics configuration for the cluster.
    [System.ComponentModel.TypeConverter(typeof(ClusterMetricsConfigurationPropertiesTypeConverter))]
    public partial interface IClusterMetricsConfigurationProperties

    {

    }
}