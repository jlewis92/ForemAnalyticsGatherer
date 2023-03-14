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
    /// ApiDisplayAdsGetRequest
    /// </summary>
    [DataContract(Name = "_api_display_ads_get_request")]
    public partial class ApiDisplayAdsGetRequest : IEquatable<ApiDisplayAdsGetRequest>, IValidatableObject
    {
        /// <summary>
        /// Potentially limits visitors to whom the ad is visible
        /// </summary>
        /// <value>Potentially limits visitors to whom the ad is visible</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayToEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum LoggedIn for value: logged_in
            /// </summary>
            [EnumMember(Value = "logged_in")]
            LoggedIn = 2,

            /// <summary>
            /// Enum LoggedOut for value: logged_out
            /// </summary>
            [EnumMember(Value = "logged_out")]
            LoggedOut = 3

        }


        /// <summary>
        /// Potentially limits visitors to whom the ad is visible
        /// </summary>
        /// <value>Potentially limits visitors to whom the ad is visible</value>
        [DataMember(Name = "display_to", EmitDefaultValue = false)]
        public DisplayToEnum? DisplayTo { get; set; }
        /// <summary>
        /// Identifies which area of site layout the ad can appear in
        /// </summary>
        /// <value>Identifies which area of site layout the ad can appear in</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlacementAreaEnum
        {
            /// <summary>
            /// Enum SidebarLeft for value: sidebar_left
            /// </summary>
            [EnumMember(Value = "sidebar_left")]
            SidebarLeft = 1,

            /// <summary>
            /// Enum SidebarLeft2 for value: sidebar_left_2
            /// </summary>
            [EnumMember(Value = "sidebar_left_2")]
            SidebarLeft2 = 2,

            /// <summary>
            /// Enum SidebarRight for value: sidebar_right
            /// </summary>
            [EnumMember(Value = "sidebar_right")]
            SidebarRight = 3,

            /// <summary>
            /// Enum PostSidebar for value: post_sidebar
            /// </summary>
            [EnumMember(Value = "post_sidebar")]
            PostSidebar = 4,

            /// <summary>
            /// Enum PostComments for value: post_comments
            /// </summary>
            [EnumMember(Value = "post_comments")]
            PostComments = 5

        }


        /// <summary>
        /// Identifies which area of site layout the ad can appear in
        /// </summary>
        /// <value>Identifies which area of site layout the ad can appear in</value>
        [DataMember(Name = "placement_area", IsRequired = true, EmitDefaultValue = true)]
        public PlacementAreaEnum PlacementArea { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDisplayAdsGetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiDisplayAdsGetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDisplayAdsGetRequest" /> class.
        /// </summary>
        /// <param name="name">For internal use, helps distinguish ads from one another (required).</param>
        /// <param name="bodyMarkdown">The text (in markdown) of the ad (required) (required).</param>
        /// <param name="approved">Ad must be both published and approved to be in rotation.</param>
        /// <param name="published">Ad must be both published and approved to be in rotation.</param>
        /// <param name="organizationId">Identifies the organization to which the ad belongs.</param>
        /// <param name="displayTo">Potentially limits visitors to whom the ad is visible (default to DisplayToEnum.All).</param>
        /// <param name="placementArea">Identifies which area of site layout the ad can appear in (required).</param>
        /// <param name="tagList">Tags on which this ad can be displayed (blank is all/any tags).</param>
        public ApiDisplayAdsGetRequest(string name = default(string), string bodyMarkdown = default(string), bool approved = default(bool), bool published = default(bool), int organizationId = default(int), DisplayToEnum? displayTo = DisplayToEnum.All, PlacementAreaEnum placementArea = default(PlacementAreaEnum), string tagList = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApiDisplayAdsGetRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "bodyMarkdown" is required (not null)
            if (bodyMarkdown == null)
            {
                throw new ArgumentNullException("bodyMarkdown is a required property for ApiDisplayAdsGetRequest and cannot be null");
            }
            this.BodyMarkdown = bodyMarkdown;
            this.PlacementArea = placementArea;
            this.Approved = approved;
            this.Published = published;
            this.OrganizationId = organizationId;
            this.DisplayTo = displayTo;
            this.TagList = tagList;
        }

        /// <summary>
        /// For internal use, helps distinguish ads from one another
        /// </summary>
        /// <value>For internal use, helps distinguish ads from one another</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The text (in markdown) of the ad (required)
        /// </summary>
        /// <value>The text (in markdown) of the ad (required)</value>
        [DataMember(Name = "body_markdown", IsRequired = true, EmitDefaultValue = true)]
        public string BodyMarkdown { get; set; }

        /// <summary>
        /// Ad must be both published and approved to be in rotation
        /// </summary>
        /// <value>Ad must be both published and approved to be in rotation</value>
        [DataMember(Name = "approved", EmitDefaultValue = true)]
        public bool Approved { get; set; }

        /// <summary>
        /// Ad must be both published and approved to be in rotation
        /// </summary>
        /// <value>Ad must be both published and approved to be in rotation</value>
        [DataMember(Name = "published", EmitDefaultValue = true)]
        public bool Published { get; set; }

        /// <summary>
        /// Identifies the organization to which the ad belongs
        /// </summary>
        /// <value>Identifies the organization to which the ad belongs</value>
        [DataMember(Name = "organization_id", EmitDefaultValue = false)]
        public int OrganizationId { get; set; }

        /// <summary>
        /// Tags on which this ad can be displayed (blank is all/any tags)
        /// </summary>
        /// <value>Tags on which this ad can be displayed (blank is all/any tags)</value>
        [DataMember(Name = "tag_list", EmitDefaultValue = false)]
        public string TagList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiDisplayAdsGetRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BodyMarkdown: ").Append(BodyMarkdown).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  DisplayTo: ").Append(DisplayTo).Append("\n");
            sb.Append("  PlacementArea: ").Append(PlacementArea).Append("\n");
            sb.Append("  TagList: ").Append(TagList).Append("\n");
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
            return this.Equals(input as ApiDisplayAdsGetRequest);
        }

        /// <summary>
        /// Returns true if ApiDisplayAdsGetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiDisplayAdsGetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiDisplayAdsGetRequest input)
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
                    this.BodyMarkdown == input.BodyMarkdown ||
                    (this.BodyMarkdown != null &&
                    this.BodyMarkdown.Equals(input.BodyMarkdown))
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.Published == input.Published ||
                    this.Published.Equals(input.Published)
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    this.OrganizationId.Equals(input.OrganizationId)
                ) && 
                (
                    this.DisplayTo == input.DisplayTo ||
                    this.DisplayTo.Equals(input.DisplayTo)
                ) && 
                (
                    this.PlacementArea == input.PlacementArea ||
                    this.PlacementArea.Equals(input.PlacementArea)
                ) && 
                (
                    this.TagList == input.TagList ||
                    (this.TagList != null &&
                    this.TagList.Equals(input.TagList))
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
                if (this.BodyMarkdown != null)
                {
                    hashCode = (hashCode * 59) + this.BodyMarkdown.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Approved.GetHashCode();
                hashCode = (hashCode * 59) + this.Published.GetHashCode();
                hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
                hashCode = (hashCode * 59) + this.DisplayTo.GetHashCode();
                hashCode = (hashCode * 59) + this.PlacementArea.GetHashCode();
                if (this.TagList != null)
                {
                    hashCode = (hashCode * 59) + this.TagList.GetHashCode();
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
