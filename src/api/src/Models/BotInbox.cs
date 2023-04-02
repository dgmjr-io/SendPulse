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
    /// BotInbox
    /// </summary>
    [DataContract]
    public partial class BotInbox : IEquatable<BotInbox>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotInbox" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="unread">unread.</param>
        public BotInbox(int? total = default(int?), int? unread = default(int?))
        {
            this.Total = total;
            this.Unread = unread;
        }

        public BotInbox() { }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public int? Total { get; set; }

        /// <summary>
        /// Gets or Sets Unread
        /// </summary>
        [DataMember(Name = "unread", EmitDefaultValue = true)]
        public int? Unread { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotInbox {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
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
            return this.Equals(input as BotInbox);
        }

        /// <summary>
        /// Returns true if BotInbox instances are equal
        /// </summary>
        /// <param name="input">Instance of BotInbox to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotInbox input)
        {
            if (input == null)
                return false;

            return (
                    this.Total == input.Total
                    || (this.Total != null && this.Total.Equals(input.Total))
                )
                && (
                    this.Unread == input.Unread
                    || (this.Unread != null && this.Unread.Equals(input.Unread))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Unread != null)
                    hashCode = hashCode * 59 + this.Unread.GetHashCode();
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