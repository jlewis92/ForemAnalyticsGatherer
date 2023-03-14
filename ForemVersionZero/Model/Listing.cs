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
    /// Listing
    /// </summary>
    [DataContract(Name = "Listing")]
    public partial class Listing : IEquatable<Listing>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public ListingCategory Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Listing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Listing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Listing" /> class.
        /// </summary>
        /// <param name="typeOf">typeOf (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="slug">slug (required).</param>
        /// <param name="bodyMarkdown">bodyMarkdown (required).</param>
        /// <param name="tagList">tagList (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="processedHtml">processedHtml (required).</param>
        /// <param name="published">published (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="organization">organization.</param>
        public Listing(string typeOf = default(string), long id = default(long), string title = default(string), string slug = default(string), string bodyMarkdown = default(string), string tagList = default(string), List<string> tags = default(List<string>), ListingCategory category = default(ListingCategory), string processedHtml = default(string), bool published = default(bool), SharedUser user = default(SharedUser), SharedOrganization organization = default(SharedOrganization))
        {
            // to ensure "typeOf" is required (not null)
            if (typeOf == null)
            {
                throw new ArgumentNullException("typeOf is a required property for Listing and cannot be null");
            }
            this.TypeOf = typeOf;
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for Listing and cannot be null");
            }
            this.Title = title;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for Listing and cannot be null");
            }
            this.Slug = slug;
            // to ensure "bodyMarkdown" is required (not null)
            if (bodyMarkdown == null)
            {
                throw new ArgumentNullException("bodyMarkdown is a required property for Listing and cannot be null");
            }
            this.BodyMarkdown = bodyMarkdown;
            // to ensure "tagList" is required (not null)
            if (tagList == null)
            {
                throw new ArgumentNullException("tagList is a required property for Listing and cannot be null");
            }
            this.TagList = tagList;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for Listing and cannot be null");
            }
            this.Tags = tags;
            this.Category = category;
            // to ensure "processedHtml" is required (not null)
            if (processedHtml == null)
            {
                throw new ArgumentNullException("processedHtml is a required property for Listing and cannot be null");
            }
            this.ProcessedHtml = processedHtml;
            this.Published = published;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for Listing and cannot be null");
            }
            this.User = user;
            this.Organization = organization;
        }

        /// <summary>
        /// Gets or Sets TypeOf
        /// </summary>
        [DataMember(Name = "type_of", IsRequired = true, EmitDefaultValue = true)]
        public string TypeOf { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets BodyMarkdown
        /// </summary>
        [DataMember(Name = "body_markdown", IsRequired = true, EmitDefaultValue = true)]
        public string BodyMarkdown { get; set; }

        /// <summary>
        /// Gets or Sets TagList
        /// </summary>
        [DataMember(Name = "tag_list", IsRequired = true, EmitDefaultValue = true)]
        public string TagList { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedHtml
        /// </summary>
        [DataMember(Name = "processed_html", IsRequired = true, EmitDefaultValue = true)]
        public string ProcessedHtml { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name = "published", IsRequired = true, EmitDefaultValue = true)]
        public bool Published { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public SharedUser User { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public SharedOrganization Organization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Listing {\n");
            sb.Append("  TypeOf: ").Append(TypeOf).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  BodyMarkdown: ").Append(BodyMarkdown).Append("\n");
            sb.Append("  TagList: ").Append(TagList).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ProcessedHtml: ").Append(ProcessedHtml).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
            return this.Equals(input as Listing);
        }

        /// <summary>
        /// Returns true if Listing instances are equal
        /// </summary>
        /// <param name="input">Instance of Listing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Listing input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.BodyMarkdown == input.BodyMarkdown ||
                    (this.BodyMarkdown != null &&
                    this.BodyMarkdown.Equals(input.BodyMarkdown))
                ) && 
                (
                    this.TagList == input.TagList ||
                    (this.TagList != null &&
                    this.TagList.Equals(input.TagList))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.ProcessedHtml == input.ProcessedHtml ||
                    (this.ProcessedHtml != null &&
                    this.ProcessedHtml.Equals(input.ProcessedHtml))
                ) && 
                (
                    this.Published == input.Published ||
                    this.Published.Equals(input.Published)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.BodyMarkdown != null)
                {
                    hashCode = (hashCode * 59) + this.BodyMarkdown.GetHashCode();
                }
                if (this.TagList != null)
                {
                    hashCode = (hashCode * 59) + this.TagList.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                if (this.ProcessedHtml != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessedHtml.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Published.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.Organization != null)
                {
                    hashCode = (hashCode * 59) + this.Organization.GetHashCode();
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