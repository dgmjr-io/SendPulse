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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SendPulse.Api.Client.SwaggerDateConverter;

namespace SendPulse.Api.Models
{
    /// <summary>
    /// ContactsSetPauseAutomationBody
    /// </summary>
    [DataContract]
    public partial class ContactsSetPauseAutomationBody
        : IEquatable<ContactsSetPauseAutomationBody>,
            IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsSetPauseAutomationBody" /> class.
        /// </summary>
        /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact. (required).</param>
        /// <param name="minutes">Minutes (required).</param>
        public ContactsSetPauseAutomationBody(
            string contactId = default(string),
            int? minutes = default(int?)
        )
        {
            // to ensure "contactId" is required (not null)
            if (contactId == null)
            {
                throw new InvalidDataException(
                    "contactId is a required property for ContactsSetPauseAutomationBody and cannot be null"
                );
            }
            else
            {
                this.ContactId = contactId;
            }
            // to ensure "minutes" is required (not null)
            if (minutes == null)
            {
                throw new InvalidDataException(
                    "minutes is a required property for ContactsSetPauseAutomationBody and cannot be null"
                );
            }
            else
            {
                this.Minutes = minutes;
            }
        }

        /// <summary>
        /// Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.
        /// </summary>
        /// <value>Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</value>
        [DataMember(Name = "contact_id", EmitDefaultValue = true)]
        public string ContactId { get; set; }

        /// <summary>
        /// Minutes
        /// </summary>
        /// <value>Minutes</value>
        [DataMember(Name = "minutes", EmitDefaultValue = true)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsSetPauseAutomationBody {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
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
            return this.Equals(input as ContactsSetPauseAutomationBody);
        }

        /// <summary>
        /// Returns true if ContactsSetPauseAutomationBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactsSetPauseAutomationBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactsSetPauseAutomationBody input)
        {
            if (input == null)
                return false;

            return (
                    this.ContactId == input.ContactId
                    || (this.ContactId != null && this.ContactId.Equals(input.ContactId))
                )
                && (
                    this.Minutes == input.Minutes
                    || (this.Minutes != null && this.Minutes.Equals(input.Minutes))
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
                if (this.Minutes != null)
                    hashCode = hashCode * 59 + this.Minutes.GetHashCode();
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
