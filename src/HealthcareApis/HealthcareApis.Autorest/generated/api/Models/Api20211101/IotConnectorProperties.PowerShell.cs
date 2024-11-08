// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.PowerShell;

    /// <summary>IoT Connector properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(IotConnectorPropertiesTypeConverter))]
    public partial class IotConnectorProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IotConnectorProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IotConnectorProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IotConnectorProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="IotConnectorProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IotConnectorProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IngestionEndpointConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotEventHubIngestionEndpointConfiguration) content.GetValueForProperty("IngestionEndpointConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfiguration, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotEventHubIngestionEndpointConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceMapping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMapping = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingProperties) content.GetValueForProperty("DeviceMapping",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMapping, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("IngestionEndpointConfigurationEventHubName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationEventHubName = (string) content.GetValueForProperty("IngestionEndpointConfigurationEventHubName",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationEventHubName, global::System.Convert.ToString);
            }
            if (content.Contains("IngestionEndpointConfigurationConsumerGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationConsumerGroup = (string) content.GetValueForProperty("IngestionEndpointConfigurationConsumerGroup",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationConsumerGroup, global::System.Convert.ToString);
            }
            if (content.Contains("IngestionEndpointConfigurationFullyQualifiedEventHubNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationFullyQualifiedEventHubNamespace = (string) content.GetValueForProperty("IngestionEndpointConfigurationFullyQualifiedEventHubNamespace",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationFullyQualifiedEventHubNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceMappingContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMappingContent = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingPropertiesContent) content.GetValueForProperty("DeviceMappingContent",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMappingContent, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesContentTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IotConnectorProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("IngestionEndpointConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotEventHubIngestionEndpointConfiguration) content.GetValueForProperty("IngestionEndpointConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfiguration, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotEventHubIngestionEndpointConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceMapping"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMapping = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingProperties) content.GetValueForProperty("DeviceMapping",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMapping, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("IngestionEndpointConfigurationEventHubName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationEventHubName = (string) content.GetValueForProperty("IngestionEndpointConfigurationEventHubName",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationEventHubName, global::System.Convert.ToString);
            }
            if (content.Contains("IngestionEndpointConfigurationConsumerGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationConsumerGroup = (string) content.GetValueForProperty("IngestionEndpointConfigurationConsumerGroup",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationConsumerGroup, global::System.Convert.ToString);
            }
            if (content.Contains("IngestionEndpointConfigurationFullyQualifiedEventHubNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationFullyQualifiedEventHubNamespace = (string) content.GetValueForProperty("IngestionEndpointConfigurationFullyQualifiedEventHubNamespace",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).IngestionEndpointConfigurationFullyQualifiedEventHubNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceMappingContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMappingContent = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotMappingPropertiesContent) content.GetValueForProperty("DeviceMappingContent",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IIotConnectorPropertiesInternal)this).DeviceMappingContent, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IotMappingPropertiesContentTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// IoT Connector properties.
    [System.ComponentModel.TypeConverter(typeof(IotConnectorPropertiesTypeConverter))]
    public partial interface IIotConnectorProperties

    {

    }
}