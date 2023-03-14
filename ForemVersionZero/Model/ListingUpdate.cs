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
    /// ListingUpdate
    /// </summary>
    [DataContract(Name = "ListingUpdate")]
    public partial class ListingUpdate : IEquatable<ListingUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingUpdate" /> class.
        /// </summary>
        /// <param name="listing">listing.</param>
        public ListingUpdate(ListingUpdateListing listing = default(ListingUpdateListing))
        {
            this.Listing = listing;
        }

        /// <summary>
        /// Gets or Sets Listing
        /// </summary>
        [DataMember(Name = "listing", EmitDefaultValue = false)]
        public ListingUpdateListing Listing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListingUpdate {\n");
            sb.Append("  Listing: ").Append(Listing).Append("\n");
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
            return this.Equals(input as ListingUpdate);
        }

        /// <summary>
        /// Returns true if ListingUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Listing == input.Listing ||
                    (this.Listing != null &&
                    this.Listing.Equals(input.Listing))
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
                if (this.Listing != null)
                {
                    hashCode = (hashCode * 59) + this.Listing.GetHashCode();
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
