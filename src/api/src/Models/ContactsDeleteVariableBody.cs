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
    /// ContactsDeleteVariableBody
    /// </summary>
    [DataContract]
    public partial class ContactsDeleteVariableBody
        : IEquatable<ContactsDeleteVariableBody>,
            IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsDeleteVariableBody" /> class.
        /// </summary>
        /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact..</param>
        /// <param name="variableId">The ID of the created variable can be obtained via other methods.</param>
        /// <param name="variableName">Name of the variable.</param>
        public ContactsDeleteVariableBody(
            string contactId = default(string),
            string variableId = default(string),
            string variableName = default(string)
        )
        {
            this.ContactId = contactId;
            this.VariableId = variableId;
            this.VariableName = variableName;
        }

        /// <summary>
        /// Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.
        /// </summary>
        /// <value>Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</value>
        [DataMember(Name = "contact_id", EmitDefaultValue = true)]
        public string ContactId { get; set; }

        /// <summary>
        /// The ID of the created variable can be obtained via other methods
        /// </summary>
        /// <value>The ID of the created variable can be obtained via other methods</value>
        [DataMember(Name = "variable_id", EmitDefaultValue = true)]
        public string VariableId { get; set; }

        /// <summary>
        /// Name of the variable
        /// </summary>
        /// <value>Name of the variable</value>
        [DataMember(Name = "variable_name", EmitDefaultValue = true)]
        public string VariableName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsDeleteVariableBody {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  VariableId: ").Append(VariableId).Append("\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
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
            return this.Equals(input as ContactsDeleteVariableBody);
        }

        /// <summary>
        /// Returns true if ContactsDeleteVariableBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactsDeleteVariableBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactsDeleteVariableBody input)
        {
            if (input == null)
                return false;

            return (
                    this.ContactId == input.ContactId
                    || (this.ContactId != null && this.ContactId.Equals(input.ContactId))
                )
                && (
                    this.VariableId == input.VariableId
                    || (this.VariableId != null && this.VariableId.Equals(input.VariableId))
                )
                && (
                    this.VariableName == input.VariableName
                    || (this.VariableName != null && this.VariableName.Equals(input.VariableName))
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
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.VariableId != null)
                    hashCode = hashCode * 59 + this.VariableId.GetHashCode();
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
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
