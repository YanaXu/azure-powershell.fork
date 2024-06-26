// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The authorization properties for accessing the source code repository.</summary>
    public partial class AuthInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAuthInfo,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAuthInfoInternal
    {

        /// <summary>Backing field for <see cref="ExpiresIn" /> property.</summary>
        private int? _expiresIn;

        /// <summary>Time in seconds that the token remains valid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public int? ExpiresIn { get => this._expiresIn; set => this._expiresIn = value; }

        /// <summary>Backing field for <see cref="RefreshToken" /> property.</summary>
        private string _refreshToken;

        /// <summary>The refresh token used to refresh the access token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string RefreshToken { get => this._refreshToken; set => this._refreshToken = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The scope of the access token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Backing field for <see cref="Token" /> property.</summary>
        private string _token;

        /// <summary>The access token used to access the source control provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Token { get => this._token; set => this._token = value; }

        /// <summary>Backing field for <see cref="TokenType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType _tokenType;

        /// <summary>The type of Auth token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType TokenType { get => this._tokenType; set => this._tokenType = value; }

        /// <summary>Creates an new <see cref="AuthInfo" /> instance.</summary>
        public AuthInfo()
        {

        }
    }
    /// The authorization properties for accessing the source code repository.
    public partial interface IAuthInfo :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Time in seconds that the token remains valid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time in seconds that the token remains valid",
        SerializedName = @"expiresIn",
        PossibleTypes = new [] { typeof(int) })]
        int? ExpiresIn { get; set; }
        /// <summary>The refresh token used to refresh the access token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The refresh token used to refresh the access token.",
        SerializedName = @"refreshToken",
        PossibleTypes = new [] { typeof(string) })]
        string RefreshToken { get; set; }
        /// <summary>The scope of the access token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope of the access token.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }
        /// <summary>The access token used to access the source control provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The access token used to access the source control provider.",
        SerializedName = @"token",
        PossibleTypes = new [] { typeof(string) })]
        string Token { get; set; }
        /// <summary>The type of Auth token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of Auth token.",
        SerializedName = @"tokenType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType TokenType { get; set; }

    }
    /// The authorization properties for accessing the source code repository.
    internal partial interface IAuthInfoInternal

    {
        /// <summary>Time in seconds that the token remains valid</summary>
        int? ExpiresIn { get; set; }
        /// <summary>The refresh token used to refresh the access token.</summary>
        string RefreshToken { get; set; }
        /// <summary>The scope of the access token.</summary>
        string Scope { get; set; }
        /// <summary>The access token used to access the source control provider.</summary>
        string Token { get; set; }
        /// <summary>The type of Auth token.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType TokenType { get; set; }

    }
}