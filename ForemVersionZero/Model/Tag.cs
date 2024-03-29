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
    /// Tag
    /// </summary>
    [DataContract(Name = "Tag")]
    public partial class Tag : IEquatable<Tag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="bgColorHex">Background color (hexadecimal) (required).</param>
        /// <param name="textColorHex">Text color (hexadecimal) (required).</param>
        public Tag(int id = default(int), string name = default(string), string bgColorHex = default(string), string textColorHex = default(string))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Tag and cannot be null");
            }
            this.Name = name;
            // to ensure "bgColorHex" is required (not null)
            if (bgColorHex == null)
            {
                throw new ArgumentNullException("bgColorHex is a required property for Tag and cannot be null");
            }
            this.BgColorHex = bgColorHex;
            // to ensure "textColorHex" is required (not null)
            if (textColorHex == null)
            {
                throw new ArgumentNullException("textColorHex is a required property for Tag and cannot be null");
            }
            this.TextColorHex = textColorHex;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Background color (hexadecimal)
        /// </summary>
        /// <value>Background color (hexadecimal)</value>
        [DataMember(Name = "bg_color_hex", IsRequired = true, EmitDefaultValue = true)]
        public string BgColorHex { get; set; }

        /// <summary>
        /// Text color (hexadecimal)
        /// </summary>
        /// <value>Text color (hexadecimal)</value>
        [DataMember(Name = "text_color_hex", IsRequired = true, EmitDefaultValue = true)]
        public string TextColorHex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Tag {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BgColorHex: ").Append(BgColorHex).Append("\n");
            sb.Append("  TextColorHex: ").Append(TextColorHex).Append("\n");
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
            return this.Equals(input as Tag);
        }

        /// <summary>
        /// Returns true if Tag instances are equal
        /// </summary>
        /// <param name="input">Instance of Tag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.BgColorHex == input.BgColorHex ||
                    (this.BgColorHex != null &&
                    this.BgColorHex.Equals(input.BgColorHex))
                ) && 
                (
                    this.TextColorHex == input.TextColorHex ||
                    (this.TextColorHex != null &&
                    this.TextColorHex.Equals(input.TextColorHex))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.BgColorHex != null)
                {
                    hashCode = (hashCode * 59) + this.BgColorHex.GetHashCode();
                }
                if (this.TextColorHex != null)
                {
                    hashCode = (hashCode * 59) + this.TextColorHex.GetHashCode();
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
