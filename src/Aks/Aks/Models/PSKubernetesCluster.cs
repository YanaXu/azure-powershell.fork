// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Microsoft.Azure.Management.ContainerService.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Aks.Models
{
    public class PSKubernetesCluster : PSResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedCluster class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response.</param>
        /// <param name="dnsPrefix">DNS prefix specified when creating the
        /// managed cluster.</param>
        /// <param name="fqdn">FQDN for the master pool.</param>
        /// <param name="kubernetesVersion">Version of Kubernetes specified
        /// when creating the managed cluster.</param>
        /// <param name="agentPoolProfiles">Properties of the agent
        /// pool.</param>
        /// <param name="linuxProfile">Profile for Linux VMs in the container
        /// service cluster.</param>
        /// <param name="servicePrincipalProfile">Information about a service
        /// principal identity for the cluster to use for manipulating Azure
        /// APIs. Either secret or keyVaultSecretRef must be specified.</param>
        public PSKubernetesCluster(string location, string id = default(string), string name = default(string),
            string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>),
            string provisioningState = default(string), string dnsPrefix = default(string),
            string fqdn = default(string), string kubernetesVersion = default(string),
            IList<PSContainerServiceAgentPoolProfile> agentPoolProfiles =
                default(IList<PSContainerServiceAgentPoolProfile>),
            PSContainerServiceLinuxProfile linuxProfile = default(PSContainerServiceLinuxProfile),
            PSContainerServiceServicePrincipalProfile servicePrincipalProfile =
                default(PSContainerServiceServicePrincipalProfile))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
            KubernetesVersion = kubernetesVersion;
            AgentPoolProfiles = agentPoolProfiles;
            LinuxProfile = linuxProfile;
            ServicePrincipalProfile = servicePrincipalProfile;
        }
        /// <summary>
        /// Gets the Power State of the cluster.
        /// </summary>
        public PSPowerState PowerState { get; private set; }

        /// <summary>
        /// Gets or sets the managed cluster SKU.
        /// </summary>
        public ManagedClusterSKU Sku { get; set; }

        /// <summary>
        /// Gets or sets the extended location of the Virtual Machine.
        /// </summary>
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Gets or sets the identity of the managed cluster, if configured.
        /// </summary>
        public PSManagedClusterIdentity Identity { get; set; }

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the max number of agent pools for the managed cluster.
        /// </summary>
        public int? MaxAgentPools { get; private set; }

        /// <summary>
        /// Gets or sets version of Kubernetes specified when creating the
        /// managed cluster.
        /// </summary>
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// Gets the version of Kubernetes the Managed Cluster is running.
        /// </summary>
        public string CurrentKubernetesVersion { get; private set; }

        /// <summary>
        /// Gets or sets DNS prefix specified when creating the managed
        /// cluster.
        /// </summary>
        public string DnsPrefix { get; set; }

        /// <summary>
        /// Gets or sets the FQDN subdomain of the private cluster with custom private dns.
        /// </summary>
        public string FqdnSubdomain { get; set; }

        /// <summary>
        /// Gets FQDN for the master pool.
        /// </summary>
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets FQDN of private cluster.
        /// </summary>
        public string PrivateFQDN { get; private set; }

        /// <summary>
        /// Gets the special FQDN used by the Azure Portal to access the Managed Cluster.
        /// This FQDN is for use only by the Azure Portal and should not be used by other
        /// clients.
        /// </summary>
        public string AzurePortalFQDN { get; private set; }

        /// <summary>
        /// Gets or sets properties of the agent pool.
        /// </summary>
        public IList<PSContainerServiceAgentPoolProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Gets or sets profile for Linux VMs in the container service
        /// cluster.
        /// </summary>
        public PSContainerServiceLinuxProfile LinuxProfile { get; set; }

        /// <summary>
        /// Gets or sets profile for Windows VMs in the container service
        /// cluster.
        /// </summary>
        public PSManagedClusterWindowsProfile WindowsProfile { get; set; }

        /// <summary>
        /// Gets or sets information about a service principal identity for the
        /// cluster to use for manipulating Azure APIs. Either secret or
        /// keyVaultSecretRef must be specified.
        /// </summary>
        public PSContainerServiceServicePrincipalProfile ServicePrincipalProfile { get; set; }

        /// <summary>
        /// Gets or sets profile of managed cluster add-on.
        /// </summary>
        public IDictionary<string, PSManagedClusterAddonProfile> AddonProfiles { get; set; }

        /// <summary>
        /// Gets or sets the pod identity profile of the Managed Cluster.
        /// </summary>
        public PSManagedClusterPodIdentityProfile PodIdentityProfile { get; set; }

        /// <summary>
        /// Gets or sets the OIDC issuer profile of the Managed Cluster.
        /// </summary>
        public ManagedClusterOidcIssuerProfile OidcIssuerProfile { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource group containing agent pool
        /// nodes.
        /// </summary>
        public string NodeResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets whether to enable Kubernetes Role-Based Access
        /// Control.
        /// </summary>
        public bool? EnableRBAC { get; set; }

        /// <summary>
        /// Gets or sets (DEPRECATING) Whether to enable Kubernetes pod
        /// security policy (preview). This feature is set for removal on
        /// October 15th, 2020. Learn more at aka.ms/aks/azpodpolicy.
        /// </summary>
        public bool? EnablePodSecurityPolicy { get; set; }

        /// <summary>
        /// Gets or sets the network configuration profile.
        /// </summary>
        public PSContainerServiceNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets profile of Azure Active Directory configuration.
        /// </summary>
        public PSManagedClusterAadProfile AadProfile { get; set; }

        /// <summary>
        /// Gets or sets the auto upgrade configuration.
        /// </summary>
        public PSManagedClusterAutoUpgradeProfile AutoUpgradeProfile { get; set; }

        /// <summary>
        /// Gets or sets parameters to be applied to the cluster-autoscaler
        /// when enabled
        /// </summary>
        public ManagedClusterPropertiesAutoScalerProfile AutoScalerProfile { get; set; }

        /// <summary>
        /// Gets or sets the access profile for managed cluster API server.
        /// </summary>
        public PSManagedClusterAPIServerAccessProfile ApiServerAccessProfile { get; set; }

        /// <summary>
        /// Gets or sets the Resource ID of the disk encryption set to use for
        /// enabling encryption at rest.
        /// </summary>
        public string DiskEncryptionSetID { get; set; }

        /// <summary>
        /// Gets or sets identities associated with the cluster.
        /// </summary>
        public IDictionary<string, PSManagedClusterPropertiesIdentityProfile> IdentityProfile { get; set; }

        /// <summary>
        /// Gets or sets private link resources associated with the cluster.
        /// </summary>
        public IList<PrivateLinkResource> PrivateLinkResources { get; set; }

        /// <summary>
        /// Gets or sets if local accounts should be disabled on the Managed
        /// Cluster.
        /// </summary>
        public bool? DisableLocalAccounts { get; set; }

        /// <summary>
        /// Gets or sets configurations for provisioning the cluster with HTTP proxy servers.
        /// </summary>
        public PSManagedClusterHTTPProxyConfig HttpProxyConfig { get; set; }

        /// <summary>
        /// Gets or sets security profile for the managed cluster.
        /// </summary>
        public ManagedClusterSecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets storage profile for the managed cluster.
        /// </summary>
        public ManagedClusterStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets publicNetworkAccess of the managedCluster
        /// </summary>
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets the ResourceGroupName from ResourceId.
        /// </summary>
        public string ResourceGroupName
        {
            get
            {
                var resource = new ResourceIdentifier(Id);
                return resource.ResourceGroupName;
            }
        }

        /// <summary>
        /// This is used by pipeline to autorest based cmdlets.
        /// </summary>
        /// <returns></returns>
        public string ToJsonString()
        {
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            });
        }
    }
}