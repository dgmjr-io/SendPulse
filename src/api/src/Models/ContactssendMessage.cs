﻿/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: justin@Dgmjr.com
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
    /// ContactssendMessage
    /// </summary>
    [DataContract]
    public partial class ContactssendMessage : IEquatable<ContactssendMessage>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,

            /// <summary>
            /// Enum Audio for value: audio
            /// </summary>
            [EnumMember(Value = "audio")]
            Audio = 2,

            /// <summary>
            /// Enum Photo for value: photo
            /// </summary>
            [EnumMember(Value = "photo")]
            Photo = 3,

            /// <summary>
            /// Enum Document for value: document
            /// </summary>
            [EnumMember(Value = "document")]
            Document = 4,

            /// <summary>
            /// Enum Video for value: video
            /// </summary>
            [EnumMember(Value = "video")]
            Video = 5
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactssendMessage" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="text">text.</param>
        /// <param name="audio">URL to file.</param>
        /// <param name="photo">URL to file.</param>
        /// <param name="document">URL to file.</param>
        /// <param name="video">URL to file.</param>
        /// <param name="caption">caption.</param>
        /// <param name="parseMode">Html text.</param>
        public ContactssendMessage(
            TypeEnum? type = default(TypeEnum?),
            string text = default(string),
            string audio = default(string),
            string photo = default(string),
            string document = default(string),
            string video = default(string),
            string caption = default(string),
            string parseMode = default(string)
        )
        {
            this.Type = type;
            this.Text = text;
            this.Audio = audio;
            this.Photo = photo;
            this.Document = document;
            this.Video = video;
            this.Caption = caption;
            this.ParseMode = parseMode;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// URL to file
        /// </summary>
        /// <value>URL to file</value>
        [DataMember(Name = "audio", EmitDefaultValue = true)]
        public string Audio { get; set; }

        /// <summary>
        /// URL to file
        /// </summary>
        /// <value>URL to file</value>
        [DataMember(Name = "photo", EmitDefaultValue = true)]
        public string Photo { get; set; }

        /// <summary>
        /// URL to file
        /// </summary>
        /// <value>URL to file</value>
        [DataMember(Name = "document", EmitDefaultValue = true)]
        public string Document { get; set; }

        /// <summary>
        /// URL to file
        /// </summary>
        /// <value>URL to file</value>
        [DataMember(Name = "video", EmitDefaultValue = true)]
        public string Video { get; set; }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name = "caption", EmitDefaultValue = true)]
        public string Caption { get; set; }

        /// <summary>
        /// Html text
        /// </summary>
        /// <value>Html text</value>
        [DataMember(Name = "parse_mode", EmitDefaultValue = true)]
        public string ParseMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactssendMessage {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  ParseMode: ").Append(ParseMode).Append("\n");
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
            return this.Equals(input as ContactssendMessage);
        }

        /// <summary>
        /// Returns true if ContactssendMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactssendMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactssendMessage input)
        {
            if (input == null)
                return false;

            return (this.Type == input.Type || (this.Type != null && this.Type.Equals(input.Type)))
                && (this.Text == input.Text || (this.Text != null && this.Text.Equals(input.Text)))
                && (
                    this.Audio == input.Audio
                    || (this.Audio != null && this.Audio.Equals(input.Audio))
                )
                && (
                    this.Photo == input.Photo
                    || (this.Photo != null && this.Photo.Equals(input.Photo))
                )
                && (
                    this.Document == input.Document
                    || (this.Document != null && this.Document.Equals(input.Document))
                )
                && (
                    this.Video == input.Video
                    || (this.Video != null && this.Video.Equals(input.Video))
                )
                && (
                    this.Caption == input.Caption
                    || (this.Caption != null && this.Caption.Equals(input.Caption))
                )
                && (
                    this.ParseMode == input.ParseMode
                    || (this.ParseMode != null && this.ParseMode.Equals(input.ParseMode))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Photo != null)
                    hashCode = hashCode * 59 + this.Photo.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.ParseMode != null)
                    hashCode = hashCode * 59 + this.ParseMode.GetHashCode();
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
