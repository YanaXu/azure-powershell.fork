// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>AgentPoolConfiguration specifies the configuration of a pool of nodes.</summary>
    public partial class AgentPoolConfiguration
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject into a new instance of <see cref="AgentPoolConfiguration" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AgentPoolConfiguration(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_administratorConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("administratorConfiguration"), out var __jsonAdministratorConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AdministratorConfiguration.FromJson(__jsonAdministratorConfiguration) : AdministratorConfiguration;}
            {_agentOption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("agentOptions"), out var __jsonAgentOptions) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AgentOptions.FromJson(__jsonAgentOptions) : AgentOption;}
            {_attachedNetworkConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("attachedNetworkConfiguration"), out var __jsonAttachedNetworkConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AttachedNetworkConfiguration.FromJson(__jsonAttachedNetworkConfiguration) : AttachedNetworkConfiguration;}
            {_upgradeSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("upgradeSettings"), out var __jsonUpgradeSettings) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AgentPoolUpgradeSettings.FromJson(__jsonUpgradeSettings) : UpgradeSetting;}
            {_availabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("availabilityZones"), out var __jsonAvailabilityZones) ? If( __jsonAvailabilityZones as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : AvailabilityZone;}
            {_count = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNumber>("count"), out var __jsonCount) ? (long)__jsonCount : Count;}
            {_label = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("labels"), out var __jsonLabels) ? If( __jsonLabels as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesLabel[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesLabel) (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesLabel.FromJson(__p) )) ))() : null : Label;}
            {_mode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("mode"), out var __jsonMode) ? (string)__jsonMode : (string)Mode;}
            {_taint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray>("taints"), out var __jsonTaints) ? If( __jsonTaints as Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesLabel[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesLabel) (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesLabel.FromJson(__k) )) ))() : null : Taint;}
            {_vMSkuName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("vmSkuName"), out var __jsonVMSkuName) ? (string)__jsonVMSkuName : (string)VMSkuName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAgentPoolConfiguration.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAgentPoolConfiguration.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IAgentPoolConfiguration FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json ? new AgentPoolConfiguration(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AgentPoolConfiguration" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AgentPoolConfiguration" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._administratorConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._administratorConfiguration.ToJson(null,serializationMode) : null, "administratorConfiguration" ,container.Add );
            AddIf( null != this._agentOption ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._agentOption.ToJson(null,serializationMode) : null, "agentOptions" ,container.Add );
            AddIf( null != this._attachedNetworkConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._attachedNetworkConfiguration.ToJson(null,serializationMode) : null, "attachedNetworkConfiguration" ,container.Add );
            AddIf( null != this._upgradeSetting ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._upgradeSetting.ToJson(null,serializationMode) : null, "upgradeSettings" ,container.Add );
            if (null != this._availabilityZone)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                foreach( var __x in this._availabilityZone )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("availabilityZones",__w);
            }
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNumber(this._count), "count" ,container.Add );
            if (null != this._label)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                foreach( var __s in this._label )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("labels",__r);
            }
            AddIf( null != (((object)this._mode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._mode.ToString()) : null, "mode" ,container.Add );
            if (null != this._taint)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.XNodeArray();
                foreach( var __n in this._taint )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("taints",__m);
            }
            AddIf( null != (((object)this._vMSkuName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._vMSkuName.ToString()) : null, "vmSkuName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}