/*
 * Forem API V1
 *
 * Access Forem articles, users and other resources via API.         For a real-world example of Forem in action, check out [DEV](https://www.dev.to).         All endpoints can be accessed with the 'api-key' header and a accept header, but         some of them are accessible publicly without authentication.          Dates and date times, unless otherwise specified, must be in         the [RFC 3339](https://tools.ietf.org/html/rfc3339) format.
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = ForemVersionOne.Client.OpenAPIDateConverter;

namespace ForemVersionOne.Model
{
    /// <summary>
    /// Flare tag of the article
    /// </summary>
    [DataContract(Name = "ArticleFlareTag")]
    public partial class ArticleFlareTag : IEquatable<ArticleFlareTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleFlareTag" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="bgColorHex">Background color (hexadecimal).</param>
        /// <param name="textColorHex">Text color (hexadecimal).</param>
        public ArticleFlareTag(string name = default(string), string bgColorHex = default(string), string textColorHex = default(string))
        {
            this.Name = name;
            this.BgColorHex = bgColorHex;
            this.TextColorHex = textColorHex;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Background color (hexadecimal)
        /// </summary>
        /// <value>Background color (hexadecimal)</value>
        [DataMember(Name = "bg_color_hex", EmitDefaultValue = false)]
        public string BgColorHex { get; set; }

        /// <summary>
        /// Text color (hexadecimal)
        /// </summary>
        /// <value>Text color (hexadecimal)</value>
        [DataMember(Name = "text_color_hex", EmitDefaultValue = false)]
        public string TextColorHex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArticleFlareTag {\n");
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
            return this.Equals(input as ArticleFlareTag);
        }

        /// <summary>
        /// Returns true if ArticleFlareTag instances are equal
        /// </summary>
        /// <param name="input">Instance of ArticleFlareTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleFlareTag input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
