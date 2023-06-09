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
using System.ComponentModel.Design;
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
    /// Trigger
    /// </summary>
    [DataContract]
    public partial class Trigger : IEquatable<Trigger>, IValidatableObject
    {
        /// <summary>
        ///                      * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing
        /// </summary>
        /// <value>                     * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing                  </value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TriggerTypeEnum? Type { get; set; }

        // /// <summary>
        // ///                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive
        // /// </summary>
        // /// <value>                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  </value>
        // [JsonConverter(typeof(StringEnumConverter))]
        // public enum StatusEnum
        // {
        //     /// <summary>
        //     /// Enum Active for value: 1
        //     /// </summary>
        //     [EnumMember(Value = "Active")]
        //     Active = 1,
        //     /// <summary>
        //     /// Enum Inactive for value: 2
        //     /// </summary>
        //     [EnumMember(Value = "Inactive")]
        //     Inactive = 2        }
        /// <summary>
        ///                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive
        /// </summary>
        /// <value>                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  </value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="botId">botId.</param>
        /// <param name="flowId">flowId.</param>
        /// <param name="name">name.</param>
        /// <param name="type">                     * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing                  .</param>
        /// <param name="status">                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  .</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="execution">execution.</param>
        /// <param name="createdAt">createdAt.</param>
        public Trigger(
            string id = default(string),
            string botId = default(string),
            string flowId = default(string),
            string name = default(string),
            TriggerTypeEnum? type = default(TriggerTypeEnum?),
            StatusEnum? status = default(StatusEnum?),
            Collection<string> keywords = default(Collection<string>),
            TriggerExecution execution = default(TriggerExecution),
            string createdAt = default(string)
        )
        {
            this.Id = id;
            this.BotId = botId;
            this.FlowId = flowId;
            this.Name = name;
            this.Type = type;
            this.Status = status;
            this.Keywords = keywords;
            this.Execution = execution;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets BotId
        /// </summary>
        [DataMember(Name = "bot_id", EmitDefaultValue = true)]
        public string BotId { get; set; }

        /// <summary>
        /// Gets or Sets FlowId
        /// </summary>
        [DataMember(Name = "flow_id", EmitDefaultValue = true)]
        public string FlowId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name = "keywords", EmitDefaultValue = true)]
        public Collection<string> Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Execution
        /// </summary>
        [DataMember(Name = "execution", EmitDefaultValue = true)]
        public TriggerExecution Execution { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trigger {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BotId: ").Append(BotId).Append("\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Execution: ").Append(Execution).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as Trigger);
        }

        /// <summary>
        /// Returns true if Trigger instances are equal
        /// </summary>
        /// <param name="input">Instance of Trigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trigger input)
        {
            if (input == null)
                return false;

            return (this.Id == input.Id || (this.Id != null && this.Id.Equals(input.Id)))
                && (
                    this.BotId == input.BotId
                    || (this.BotId != null && this.BotId.Equals(input.BotId))
                )
                && (
                    this.FlowId == input.FlowId
                    || (this.FlowId != null && this.FlowId.Equals(input.FlowId))
                )
                && (this.Name == input.Name || (this.Name != null && this.Name.Equals(input.Name)))
                && (this.Type == input.Type || (this.Type != null && this.Type.Equals(input.Type)))
                && (
                    this.Status == input.Status
                    || (this.Status != null && this.Status.Equals(input.Status))
                )
                && (
                    this.Keywords == input.Keywords
                    || this.Keywords != null
                        && input.Keywords != null
                        && this.Keywords.SequenceEqual(input.Keywords)
                )
                && (
                    this.Execution == input.Execution
                    || (this.Execution != null && this.Execution.Equals(input.Execution))
                )
                && (
                    this.CreatedAt == input.CreatedAt
                    || (this.CreatedAt != null && this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BotId != null)
                    hashCode = hashCode * 59 + this.BotId.GetHashCode();
                if (this.FlowId != null)
                    hashCode = hashCode * 59 + this.FlowId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Execution != null)
                    hashCode = hashCode * 59 + this.Execution.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
