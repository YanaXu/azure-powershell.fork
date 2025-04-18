// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataShare.Models
{
    using System.Linq;

    /// <summary>
    /// A consumer Invitation data transfer object.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ConsumerInvitation : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the ConsumerInvitation class.
        /// </summary>
        public ConsumerInvitation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsumerInvitation class.
        /// </summary>

        /// <param name="id">The resource id of the azure resource
        /// </param>

        /// <param name="name">Name of the azure resource
        /// </param>

        /// <param name="type">Type of the azure resource
        /// </param>

        /// <param name="invitationStatus">The status of the invitation.
        /// Possible values include: &#39;Pending&#39;, &#39;Accepted&#39;, &#39;Rejected&#39;, &#39;Withdrawn&#39;</param>

        /// <param name="dataSetCount">Number of data sets in a share
        /// </param>

        /// <param name="description">Description shared when the invitation was created
        /// </param>

        /// <param name="invitationId">Unique id of the invitation.
        /// </param>

        /// <param name="location">invitation location
        /// </param>

        /// <param name="providerEmail">Email of the provider who created the resource
        /// </param>

        /// <param name="providerName">Name of the provider who created the resource
        /// </param>

        /// <param name="providerTenantName">Tenant name of the provider who created the resource
        /// </param>

        /// <param name="respondedAt">The time the recipient responded to the invitation.
        /// </param>

        /// <param name="sentAt">Gets the time at which the invitation was sent.
        /// </param>

        /// <param name="shareName">Gets the source share Name.
        /// </param>

        /// <param name="termsOfUse">Terms of use shared when the invitation was created
        /// </param>

        /// <param name="userEmail">Email of the user who created the resource
        /// </param>

        /// <param name="userName">Name of the user who created the resource
        /// </param>
        public ConsumerInvitation(string invitationId, string id = default(string), string name = default(string), string type = default(string), string invitationStatus = default(string), int? dataSetCount = default(int?), string description = default(string), string location = default(string), string providerEmail = default(string), string providerName = default(string), string providerTenantName = default(string), System.DateTime? respondedAt = default(System.DateTime?), System.DateTime? sentAt = default(System.DateTime?), string shareName = default(string), string termsOfUse = default(string), string userEmail = default(string), string userName = default(string))

        : base(id, name, type)
        {
            this.InvitationStatus = invitationStatus;
            this.DataSetCount = dataSetCount;
            this.Description = description;
            this.InvitationId = invitationId;
            this.Location = location;
            this.ProviderEmail = providerEmail;
            this.ProviderName = providerName;
            this.ProviderTenantName = providerTenantName;
            this.RespondedAt = respondedAt;
            this.SentAt = sentAt;
            this.ShareName = shareName;
            this.TermsOfUse = termsOfUse;
            this.UserEmail = userEmail;
            this.UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the status of the invitation. Possible values include: &#39;Pending&#39;, &#39;Accepted&#39;, &#39;Rejected&#39;, &#39;Withdrawn&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.invitationStatus")]
        public string InvitationStatus {get; private set; }

        /// <summary>
        /// Gets number of data sets in a share
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataSetCount")]
        public int? DataSetCount {get; private set; }

        /// <summary>
        /// Gets description shared when the invitation was created
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description {get; private set; }

        /// <summary>
        /// Gets or sets unique id of the invitation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.invitationId")]
        public string InvitationId {get; set; }

        /// <summary>
        /// Gets invitation location
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.location")]
        public string Location {get; private set; }

        /// <summary>
        /// Gets email of the provider who created the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.providerEmail")]
        public string ProviderEmail {get; private set; }

        /// <summary>
        /// Gets name of the provider who created the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.providerName")]
        public string ProviderName {get; private set; }

        /// <summary>
        /// Gets tenant name of the provider who created the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.providerTenantName")]
        public string ProviderTenantName {get; private set; }

        /// <summary>
        /// Gets the time the recipient responded to the invitation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.respondedAt")]
        public System.DateTime? RespondedAt {get; private set; }

        /// <summary>
        /// Gets gets the time at which the invitation was sent.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sentAt")]
        public System.DateTime? SentAt {get; private set; }

        /// <summary>
        /// Gets gets the source share Name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.shareName")]
        public string ShareName {get; private set; }

        /// <summary>
        /// Gets terms of use shared when the invitation was created
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.termsOfUse")]
        public string TermsOfUse {get; private set; }

        /// <summary>
        /// Gets email of the user who created the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userEmail")]
        public string UserEmail {get; private set; }

        /// <summary>
        /// Gets name of the user who created the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userName")]
        public string UserName {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.InvitationId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "InvitationId");
            }











        }
    }
}