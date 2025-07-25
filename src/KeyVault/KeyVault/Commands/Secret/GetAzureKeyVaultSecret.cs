﻿// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Commands.KeyVault.Models;
using Microsoft.Azure.Commands.KeyVault.Models.Secret;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using System;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Azure.Commands.KeyVault
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzurePrefix + "KeyVaultSecret", DefaultParameterSetName = ByVaultNameParameterSet)]
    [OutputType(typeof(PSKeyVaultSecretIdentityItem), typeof(PSKeyVaultSecret), typeof(PSDeletedKeyVaultSecretIdentityItem), typeof(PSDeletedKeyVaultSecret), typeof(string))]
    public class GetAzureKeyVaultSecret : KeyVaultCmdletBase
    {
        #region Parameter Set Names

        private const string ByVaultNameParameterSet = "ByVaultName";
        private const string BySecretNameParameterSet = "BySecretName";
        private const string BySecretVersionsParameterSet = "BySecretVersions";
        private const string BySecretUriParameterSet = "BySecretUri";

        private const string InputObjectByVaultNameParameterSet = "ByInputObjectVaultName";
        private const string InputObjectBySecretNameParameterSet = "ByInputObjectSecretName";
        private const string InputObjectBySecretVersionsParameterSet = "ByInputObjectSecretVersions";

        private const string ParentResourceIdByVaultNameParameterSet = "ByParentResourceIdVaultName";
        private const string ParentResourceIdBySecretNameParameterSet = "ByParentResourceIdSecretName";
        private const string ParentResourceIdBySecretVersionsParameterSet = "ByParentResourceIdSecretVersions";

        #endregion

        #region Input Parameter Definitions

        /// <summary>
        /// Vault name
        /// </summary>
        [Parameter(Mandatory = true,
            Position = 0,
            ParameterSetName = BySecretNameParameterSet,
            HelpMessage = "Vault name. Cmdlet constructs the FQDN of a vault based on the name and currently selected environment.")]
        [Parameter(Mandatory = true,
            Position = 0,
            ParameterSetName = ByVaultNameParameterSet,
            HelpMessage = "Vault name. Cmdlet constructs the FQDN of a vault based on the name and currently selected environment.")]
        [Parameter(Mandatory = true,
           Position = 0,
           ParameterSetName = BySecretVersionsParameterSet,
           HelpMessage = "Vault name. Cmdlet constructs the FQDN of a vault based on the name and currently selected environment.")]
        [ResourceNameCompleter("Microsoft.KeyVault/vaults", "FakeResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string VaultName { get; set; }

        /// <summary>
        /// KeyVault object
        /// </summary>
        [Parameter(Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = InputObjectByVaultNameParameterSet,
            HelpMessage = "KeyVault Object.")]
        [Parameter(Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = InputObjectBySecretNameParameterSet,
            HelpMessage = "KeyVault Object.")]
        [Parameter(Mandatory = true,
           Position = 0,
           ValueFromPipeline = true,
           ParameterSetName = InputObjectBySecretVersionsParameterSet,
           HelpMessage = "KeyVault Object.")]
        [ValidateNotNullOrEmpty]
        public PSKeyVault InputObject { get; set; }

        /// <summary>
        /// KeyVault Secret ID
        /// </summary>
        [Parameter(Mandatory = true,
           Position = 0,
           ParameterSetName = BySecretUriParameterSet,
           HelpMessage = "The URI of the KeyVault Secret.")]
        [Alias("SecretId")]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }


        /// <summary>
        /// KeyVault Parent Resource ID
        /// </summary>
        [Parameter(Mandatory = true,
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ParentResourceIdByVaultNameParameterSet,
            HelpMessage = "KeyVault Resource Id.")]
        [Parameter(Mandatory = true,
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = ParentResourceIdBySecretNameParameterSet,
            HelpMessage = "KeyVault Resource Id.")]
        [Parameter(Mandatory = true,
           Position = 0,
           ValueFromPipelineByPropertyName = true,
           ParameterSetName = ParentResourceIdBySecretVersionsParameterSet,
           HelpMessage = "KeyVault Resource Id.")]
        [Alias("ResourceId")]
        [ValidateNotNullOrEmpty]
        public string ParentResourceId { get; set; }

        /// <summary>
        /// Secret name
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 1,
            ParameterSetName = ByVaultNameParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = false,
            Position = 1,
            ParameterSetName = InputObjectByVaultNameParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = false,
            Position = 1,
            ParameterSetName = ParentResourceIdByVaultNameParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = true,
            Position = 1,
            ParameterSetName = BySecretNameParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = true,
            Position = 1,
            ParameterSetName = InputObjectBySecretNameParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = true,
            Position = 1,
            ParameterSetName = ParentResourceIdBySecretNameParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = true,
            Position = 1,
            ParameterSetName = BySecretVersionsParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = true,
            Position = 1,
            ParameterSetName = InputObjectBySecretVersionsParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [Parameter(Mandatory = true,
            Position = 1,
            ParameterSetName = ParentResourceIdBySecretVersionsParameterSet,
            HelpMessage = "Secret name. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment and secret name.")]
        [ValidateNotNullOrEmpty]
        [Alias(Constants.SecretName)]
        [SupportsWildcards]
        public string Name { get; set; }

        /// <summary>
        /// Secret version
        /// </summary>
        [Parameter(Mandatory = true,
            ParameterSetName = BySecretNameParameterSet,
            Position = 2,
            HelpMessage = "Secret version. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment, secret name and secret version.")]
        [Parameter(Mandatory = true,
            ParameterSetName = InputObjectBySecretNameParameterSet,
            Position = 2,
            HelpMessage = "Secret version. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment, secret name and secret version.")]
        [Parameter(Mandatory = true,
            ParameterSetName = ParentResourceIdBySecretNameParameterSet,
            Position = 2,
            HelpMessage = "Secret version. Cmdlet constructs the FQDN of a secret from vault name, currently selected environment, secret name and secret version.")]
        [Alias("SecretVersion")]
        public string Version { get; set; }

        [Parameter(Mandatory = true,
            ParameterSetName = BySecretVersionsParameterSet,
            HelpMessage = "Specifies whether to include the versions of the secret in the output.")]
        [Parameter(Mandatory = true,
            ParameterSetName = InputObjectBySecretVersionsParameterSet,
            HelpMessage = "Specifies whether to include the versions of the secret in the output.")]
        [Parameter(Mandatory = true,
            ParameterSetName = ParentResourceIdBySecretVersionsParameterSet,
            HelpMessage = "Specifies whether to include the versions of the secret in the output.")]
        public SwitchParameter IncludeVersions { get; set; }

        [Parameter(Mandatory = false,
            ParameterSetName = ByVaultNameParameterSet,
            HelpMessage = "Specifies whether to show the previously deleted secrets in the output.")]
        [Parameter(Mandatory = false,
            ParameterSetName = InputObjectByVaultNameParameterSet,
            HelpMessage = "Specifies whether to show the previously deleted secrets in the output.")]
        [Parameter(Mandatory = false,
            ParameterSetName = ParentResourceIdByVaultNameParameterSet,
            HelpMessage = "Specifies whether to show the previously deleted secrets in the output.")]
        [Parameter(Mandatory = false,
            ParameterSetName = BySecretUriParameterSet,
            HelpMessage = "Specifies whether to show the previously deleted secrets in the output.")]
        public SwitchParameter InRemovedState { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = BySecretNameParameterSet, HelpMessage = "When set, the cmdlet will convert secret in secure string to the decrypted plaintext string as output.")]
        [Parameter(Mandatory = false, ParameterSetName = ByVaultNameParameterSet)]
        [Parameter(Mandatory = false, ParameterSetName = BySecretUriParameterSet)]
        [Parameter(Mandatory = false, ParameterSetName = InputObjectBySecretNameParameterSet)]
        [Parameter(Mandatory = false, ParameterSetName = InputObjectByVaultNameParameterSet)]
        [Parameter(Mandatory = false, ParameterSetName = ParentResourceIdBySecretNameParameterSet)]
        [Parameter(Mandatory = false, ParameterSetName = ParentResourceIdByVaultNameParameterSet)]
        public SwitchParameter AsPlainText { get; set; }
        #endregion

        public override void ExecuteCmdlet()
        {
            PSKeyVaultSecret secret;

            // Check input object
            if (InputObject != null)
            {
                VaultName = InputObject.VaultName.ToString();
            }
            else if (!string.IsNullOrEmpty(ParentResourceId))
            {
                var parsedParentResourceId = new ResourceIdentifier(ParentResourceId);
                VaultName = parsedParentResourceId.ResourceName;
            }

            // Handle SecretId (uri) parameter
            if (ParameterSetName == BySecretUriParameterSet)
            {
                SecretUriComponents splitUri = new SecretUriComponents(Id);

                VaultName = splitUri.VaultName;
                Name = splitUri.SecretName;
                Version = splitUri.SecretVersion;
            }

            // Check Version/s of Secret to get.
            if (!string.IsNullOrEmpty(Version))
            {
                secret = DataServiceClient.GetSecret(VaultName, Name, Version);
                WriteSecret(secret);
            }
            else if (IncludeVersions)
            {
                GetAndWriteSecretVersions(VaultName, Name);
            }
            else if (InRemovedState)
            {
                if (string.IsNullOrEmpty(Name) || WildcardPattern.ContainsWildcardCharacters(Name))
                {
                    GetAndWriteDeletedSecrets(VaultName, Name);
                }
                else
                {
                    PSDeletedKeyVaultSecret deletedSecret = DataServiceClient.GetDeletedSecret(VaultName, Name);
                    WriteObject(deletedSecret);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(Name) || WildcardPattern.ContainsWildcardCharacters(Name))
                {
                    GetAndWriteSecrets(VaultName, Name);
                }
                else
                {
                    secret = DataServiceClient.GetSecret(VaultName, Name, string.Empty);
                    WriteSecret(secret);
                }
            }
        }

        private void GetAndWriteDeletedSecrets(string vaultName, string name) =>
            GetAndWriteObjects(new KeyVaultObjectFilterOptions
                {
                    VaultName = vaultName,
                    NextLink = null
                },
                (options) => KVSubResourceWildcardFilter(name, DataServiceClient.GetDeletedSecrets(options)));

        private void GetAndWriteSecrets(string vaultName, string name) =>
            GetAndWriteObjects(new KeyVaultObjectFilterOptions
                {
                    VaultName = vaultName,
                    NextLink = null
                },
                (options) => KVSubResourceWildcardFilter(name, DataServiceClient.GetSecrets(options)));

        private void GetAndWriteSecretVersions(string vaultName, string name) =>
            GetAndWriteObjects(new KeyVaultObjectFilterOptions
                {
                    VaultName = vaultName,
                    Name = name,
                    NextLink = null
                },
                (options) => DataServiceClient.GetSecretVersions(options));

        private void WriteSecret(PSKeyVaultSecret secret)
        {
            if (AsPlainText)
            {
                WriteObject(ConvertFromSecureString(secret?.SecretValue));
            }
            else
            {
                WriteObject(secret);
            }
        }

        private string ConvertFromSecureString(SecureString secretValue)
        {
            if(secretValue == null)
            {
                return null;
            }
            var ssPtr = Marshal.SecureStringToBSTR(secretValue);
            try
            {
                return Marshal.PtrToStringBSTR(ssPtr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(ssPtr);
            }
        }
    }
}
