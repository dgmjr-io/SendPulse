/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: david@dgmjr.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = SendPulse.Api.Client.SwaggerDateConverter;

namespace SendPulse.Api.Models
{
    /// <summary>
    /// AccountStatistics
    /// </summary>
    [DataContract]
    public partial class AccountStatistics : IEquatable<AccountStatistics>, IValidatableObject
    {
        // /// <summary>
        // /// Initializes a new instance of the <see cref="AccountStatistics" /> class.
        // /// </summary>
        // /// <param name="messages">messages.</param>
        // /// <param name="bots">bots.</param>
        // /// <param name="contacts">contacts.</param>
        // /// <param name="variables">variables.</param>
        // public AccountStatistics(int? messages = default(int?), int? bots = default(int?), int? contacts = default(int?), int? variables = default(int?))
        // {
        //     this.Messages = messages;
        //     this.Bots = bots;
        //     this.Contacts = contacts;
        //     this.Variables = variables;
        // }


        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = true)]
        public int? Messages { get; set; }

        /// <summary>
        /// Gets or Sets Bots
        /// </summary>
        [DataMember(Name = "bots", EmitDefaultValue = true)]
        public int? Bots { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name = "contacts", EmitDefaultValue = true)]
        public int? Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public int? Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountStatistics {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Bots: ").Append(Bots).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountStatistics);
        }

        /// <summary>
        /// Returns true if AccountStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStatistics input)
        {
            if (input == null)
                return false;

            return (
                    this.Messages == input.Messages
                    || (this.Messages != null && this.Messages.Equals(input.Messages))
                )
                && (this.Bots == input.Bots || (this.Bots != null && this.Bots.Equals(input.Bots)))
                && (
                    this.Contacts == input.Contacts
                    || (this.Contacts != null && this.Contacts.Equals(input.Contacts))
                )
                && (
                    this.Variables == input.Variables
                    || (this.Variables != null && this.Variables.Equals(input.Variables))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Bots != null)
                    hashCode = hashCode * 59 + this.Bots.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext
        )
        {
            yield break;
        }
    }
}
