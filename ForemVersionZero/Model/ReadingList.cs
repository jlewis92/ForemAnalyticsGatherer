/*
 * DEV API (beta)
 *
 *  Access Forem articles, users and other resources via API.  For a real-world example of Forem in action, check out [DEV](https://www.dev.to).  All endpoints that don't require authentication are CORS enabled.  All requests must send a user-agent header.  Dates and date times, unless otherwise specified, must be in the [RFC 3339](https://tools.ietf.org/html/rfc3339) format. 
 *
 * The version of the OpenAPI document: 0.9.7
 * Contact: yo@dev.to
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ForemVersionZero.Client.OpenAPIDateConverter;

namespace ForemVersionZero.Model
{
    /// <summary>
    /// ReadingList
    /// </summary>
    [DataContract(Name = "ReadingList")]
    public partial class ReadingList : IEquatable<ReadingList>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 1,

            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 2,

            /// <summary>
            /// Enum Confirmed for value: confirmed
            /// </summary>
            [EnumMember(Value = "confirmed")]
            Confirmed = 3,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 4

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadingList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReadingList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadingList" /> class.
        /// </summary>
        /// <param name="typeOf">typeOf (required).</param>
        /// <param name="id">Follow id (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="article">article (required).</param>
        public ReadingList(string typeOf = default(string), int id = default(int), StatusEnum status = default(StatusEnum), DateTime createdAt = default(DateTime), ArticleIndex article = default(ArticleIndex))
        {
            // to ensure "typeOf" is required (not null)
            if (typeOf == null)
            {
                throw new ArgumentNullException("typeOf is a required property for ReadingList and cannot be null");
            }
            this.TypeOf = typeOf;
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
            // to ensure "article" is required (not null)
            if (article == null)
            {
                throw new ArgumentNullException("article is a required property for ReadingList and cannot be null");
            }
            this.Article = article;
        }

        /// <summary>
        /// Gets or Sets TypeOf
        /// </summary>
        [DataMember(Name = "type_of", IsRequired = true, EmitDefaultValue = true)]
        public string TypeOf { get; set; }

        /// <summary>
        /// Follow id
        /// </summary>
        /// <value>Follow id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name = "article", IsRequired = true, EmitDefaultValue = true)]
        public ArticleIndex Article { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadingList {\n");
            sb.Append("  TypeOf: ").Append(TypeOf).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReadingList);
        }

        /// <summary>
        /// Returns true if ReadingList instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadingList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadingList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TypeOf == input.TypeOf ||
                    (this.TypeOf != null &&
                    this.TypeOf.Equals(input.TypeOf))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Article == input.Article ||
                    (this.Article != null &&
                    this.Article.Equals(input.Article))
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
                if (this.TypeOf != null)
                {
                    hashCode = (hashCode * 59) + this.TypeOf.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Article != null)
                {
                    hashCode = (hashCode * 59) + this.Article.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}