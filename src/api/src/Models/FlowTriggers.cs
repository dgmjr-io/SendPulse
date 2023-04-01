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
    /// FlowTriggers
    /// </summary>
    [DataContract]
    public partial class FlowTriggers : IEquatable<FlowTriggers>, IValidatableObject
    {
        // /// <summary>
        // ///                      * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing
        // /// </summary>
        // /// <value>                     * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing                  </value>
        // [JsonConverter(typeof(StringEnumConverter))]
        // public enum TypeEnum
        // {
        //     /// <summary>
        //     /// Enum StartsImmediatelyUponSubscription for value: 1
        //     /// </summary>
        //     [EnumMember(Value = "StartsImmediatelyUponSubscription")]
        //     StartsImmediatelyUponSubscription = 1,
        //     /// <summary>
        //     /// Enum StartsWhenUnsubscribed for value: 2
        //     /// </summary>
        //     [EnumMember(Value = "StartsWhenUnsubscribed")]
        //     StartsWhenUnsubscribed = 2,
        //     /// <summary>
        //     /// Enum DefaultReply for value: 3
        //     /// </summary>
        //     [EnumMember(Value = "DefaultReply")]
        //     DefaultReply = 3,
        //     /// <summary>
        //     /// Enum StartsWhenTheSpecifiedKeywordIsEntered for value: 4
        //     /// </summary>
        //     [EnumMember(Value = "StartsWhenTheSpecifiedKeywordIsEntered")]
        //     StartsWhenTheSpecifiedKeywordIsEntered = 4,
        //     /// <summary>
        //     /// Enum StartsAtTheSpecifiedTimeWhenSubscribing for value: 5
        //     /// </summary>
        //     [EnumMember(Value = "StartsAtTheSpecifiedTimeWhenSubscribing")]
        //     StartsAtTheSpecifiedTimeWhenSubscribing = 5        }
        /// <summary>
        ///                      * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing
        /// </summary>
        /// <value>                     * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing                  </value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowTriggers" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="type">                     * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing                  .</param>
        public FlowTriggers(
            string id = default(string),
            string name = default(string),
            TypeEnum? type = default(TypeEnum?)
        )
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowTriggers {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as FlowTriggers);
        }

        /// <summary>
        /// Returns true if FlowTriggers instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowTriggers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowTriggers input)
        {
            if (input == null)
                return false;

            return (this.Id == input.Id || (this.Id != null && this.Id.Equals(input.Id)))
                && (this.Name == input.Name || (this.Name != null && this.Name.Equals(input.Name)))
                && (this.Type == input.Type || (this.Type != null && this.Type.Equals(input.Type)));
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
