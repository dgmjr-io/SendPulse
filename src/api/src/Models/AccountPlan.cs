﻿/*
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
    /// &#x60;-1&#x60; - unlimited
    /// </summary>
    [DataContract]
    public partial class AccountPlan : IEquatable<AccountPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPlan" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="maxBots">maxBots.</param>
        /// <param name="maxContacts">maxContacts.</param>
        /// <param name="maxMessages">maxMessages.</param>
        /// <param name="maxTags">maxTags.</param>
        /// <param name="maxVariables">maxVariables.</param>
        /// <param name="branding">branding.</param>
        /// <param name="isExceeded">isExceeded.</param>
        /// <param name="isExpired">isExpired.</param>
        /// <param name="expiredAt">expiredAt.</param>
        public AccountPlan(
            string code = default(string),
            int? maxBots = default(int?),
            int? maxContacts = default(int?),
            int? maxMessages = default(int?),
            int? maxTags = default(int?),
            int? maxVariables = default(int?),
            bool? branding = default(bool?),
            bool? isExceeded = default(bool?),
            bool? isExpired = default(bool?),
            string expiredAt = default(string)
        )
        {
            this.Code = code;
            this.MaxBots = maxBots;
            this.MaxContacts = maxContacts;
            this.MaxMessages = maxMessages;
            this.MaxTags = maxTags;
            this.MaxVariables = maxVariables;
            this.Branding = branding;
            this.IsExceeded = isExceeded;
            this.IsExpired = isExpired;
            this.ExpiredAt = expiredAt;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets MaxBots
        /// </summary>
        [DataMember(Name = "max_bots", EmitDefaultValue = true)]
        public int? MaxBots { get; set; }

        /// <summary>
        /// Gets or Sets MaxContacts
        /// </summary>
        [DataMember(Name = "max_contacts", EmitDefaultValue = true)]
        public int? MaxContacts { get; set; }

        /// <summary>
        /// Gets or Sets MaxMessages
        /// </summary>
        [DataMember(Name = "max_messages", EmitDefaultValue = true)]
        public int? MaxMessages { get; set; }

        /// <summary>
        /// Gets or Sets MaxTags
        /// </summary>
        [DataMember(Name = "max_tags", EmitDefaultValue = true)]
        public int? MaxTags { get; set; }

        /// <summary>
        /// Gets or Sets MaxVariables
        /// </summary>
        [DataMember(Name = "max_variables", EmitDefaultValue = true)]
        public int? MaxVariables { get; set; }

        /// <summary>
        /// Gets or Sets Branding
        /// </summary>
        [DataMember(Name = "branding", EmitDefaultValue = true)]
        public bool? Branding { get; set; }

        /// <summary>
        /// Gets or Sets IsExceeded
        /// </summary>
        [DataMember(Name = "is_exceeded", EmitDefaultValue = true)]
        public bool? IsExceeded { get; set; }

        /// <summary>
        /// Gets or Sets IsExpired
        /// </summary>
        [DataMember(Name = "is_expired", EmitDefaultValue = true)]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// Gets or Sets ExpiredAt
        /// </summary>
        [DataMember(Name = "expired_at", EmitDefaultValue = true)]
        public string ExpiredAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPlan {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MaxBots: ").Append(MaxBots).Append("\n");
            sb.Append("  MaxContacts: ").Append(MaxContacts).Append("\n");
            sb.Append("  MaxMessages: ").Append(MaxMessages).Append("\n");
            sb.Append("  MaxTags: ").Append(MaxTags).Append("\n");
            sb.Append("  MaxVariables: ").Append(MaxVariables).Append("\n");
            sb.Append("  Branding: ").Append(Branding).Append("\n");
            sb.Append("  IsExceeded: ").Append(IsExceeded).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  ExpiredAt: ").Append(ExpiredAt).Append("\n");
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
            return this.Equals(input as AccountPlan);
        }

        /// <summary>
        /// Returns true if AccountPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPlan input)
        {
            if (input == null)
                return false;

            return (this.Code == input.Code || (this.Code != null && this.Code.Equals(input.Code)))
                && (
                    this.MaxBots == input.MaxBots
                    || (this.MaxBots != null && this.MaxBots.Equals(input.MaxBots))
                )
                && (
                    this.MaxContacts == input.MaxContacts
                    || (this.MaxContacts != null && this.MaxContacts.Equals(input.MaxContacts))
                )
                && (
                    this.MaxMessages == input.MaxMessages
                    || (this.MaxMessages != null && this.MaxMessages.Equals(input.MaxMessages))
                )
                && (
                    this.MaxTags == input.MaxTags
                    || (this.MaxTags != null && this.MaxTags.Equals(input.MaxTags))
                )
                && (
                    this.MaxVariables == input.MaxVariables
                    || (this.MaxVariables != null && this.MaxVariables.Equals(input.MaxVariables))
                )
                && (
                    this.Branding == input.Branding
                    || (this.Branding != null && this.Branding.Equals(input.Branding))
                )
                && (
                    this.IsExceeded == input.IsExceeded
                    || (this.IsExceeded != null && this.IsExceeded.Equals(input.IsExceeded))
                )
                && (
                    this.IsExpired == input.IsExpired
                    || (this.IsExpired != null && this.IsExpired.Equals(input.IsExpired))
                )
                && (
                    this.ExpiredAt == input.ExpiredAt
                    || (this.ExpiredAt != null && this.ExpiredAt.Equals(input.ExpiredAt))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.MaxBots != null)
                    hashCode = hashCode * 59 + this.MaxBots.GetHashCode();
                if (this.MaxContacts != null)
                    hashCode = hashCode * 59 + this.MaxContacts.GetHashCode();
                if (this.MaxMessages != null)
                    hashCode = hashCode * 59 + this.MaxMessages.GetHashCode();
                if (this.MaxTags != null)
                    hashCode = hashCode * 59 + this.MaxTags.GetHashCode();
                if (this.MaxVariables != null)
                    hashCode = hashCode * 59 + this.MaxVariables.GetHashCode();
                if (this.Branding != null)
                    hashCode = hashCode * 59 + this.Branding.GetHashCode();
                if (this.IsExceeded != null)
                    hashCode = hashCode * 59 + this.IsExceeded.GetHashCode();
                if (this.IsExpired != null)
                    hashCode = hashCode * 59 + this.IsExpired.GetHashCode();
                if (this.ExpiredAt != null)
                    hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
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

        [JExtension]
        public JExtensionDict ExtensionData { get; set; }
    }
}
