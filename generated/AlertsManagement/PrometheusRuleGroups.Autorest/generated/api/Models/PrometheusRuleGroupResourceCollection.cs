// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Runtime.Extensions;

    /// <summary>Represents a collection of alert rule resources.</summary>
    public partial class PrometheusRuleGroupResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResourceCollectionInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResource> _value;

        /// <summary>the values for the alert rule resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Origin(Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrometheusRuleGroupResourceCollection" /> instance.</summary>
        public PrometheusRuleGroupResourceCollection()
        {

        }
    }
    /// Represents a collection of alert rule resources.
    public partial interface IPrometheusRuleGroupResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Runtime.IJsonSerializable
    {
        /// <summary>the values for the alert rule resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the values for the alert rule resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResource> Value { get; set; }

    }
    /// Represents a collection of alert rule resources.
    internal partial interface IPrometheusRuleGroupResourceCollectionInternal

    {
        /// <summary>the values for the alert rule resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.PrometheusRuleGroups.Models.IPrometheusRuleGroupResource> Value { get; set; }

    }
}