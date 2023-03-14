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
    /// ArticleUpdateArticle
    /// </summary>
    [DataContract(Name = "ArticleUpdate_article")]
    public partial class ArticleUpdateArticle : IEquatable<ArticleUpdateArticle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleUpdateArticle" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="bodyMarkdown">The body of the article.  It can contain an optional front matter. For example  &#x60;&#x60;&#x60;markdown - -- title: Hello, World! published: true tags: discuss, help date: 20190701T10:00Z series: Hello series canonical_url: https://example.com/blog/hello cover_image: article_published_cover_image - -- &#x60;&#x60;&#x60;  &#x60;date&#x60;, &#x60;series&#x60; and &#x60;canonical_url&#x60; are optional. &#x60;date&#x60; is the publication date-time &#x60;series&#x60; is the name of the series the article belongs to &#x60;canonical_url&#x60; is the canonical URL of the article &#x60;cover_image&#x60; is the main image of the article  *If the markdown contains a front matter, it will take precedence on the equivalent params given in the payload.* .</param>
        /// <param name="published">True to create a published article, false otherwise. Defaults to false .</param>
        /// <param name="series">Article series name.  All articles belonging to the same series need to have the same name in this parameter.  To remove an article from a series, the &#x60;null&#x60; value can be used. .</param>
        /// <param name="mainImage">mainImage.</param>
        /// <param name="canonicalUrl">canonicalUrl.</param>
        /// <param name="description">description.</param>
        /// <param name="tags">tags.</param>
        /// <param name="organizationId">Only users belonging to an organization can assign the article to it .</param>
        public ArticleUpdateArticle(string title = default(string), string bodyMarkdown = default(string), bool published = default(bool), string series = default(string), string mainImage = default(string), string canonicalUrl = default(string), string description = default(string), List<string> tags = default(List<string>), int organizationId = default(int))
        {
            this.Title = title;
            this.BodyMarkdown = bodyMarkdown;
            this.Published = published;
            this.Series = series;
            this.MainImage = mainImage;
            this.CanonicalUrl = canonicalUrl;
            this.Description = description;
            this.Tags = tags;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The body of the article.  It can contain an optional front matter. For example  &#x60;&#x60;&#x60;markdown - -- title: Hello, World! published: true tags: discuss, help date: 20190701T10:00Z series: Hello series canonical_url: https://example.com/blog/hello cover_image: article_published_cover_image - -- &#x60;&#x60;&#x60;  &#x60;date&#x60;, &#x60;series&#x60; and &#x60;canonical_url&#x60; are optional. &#x60;date&#x60; is the publication date-time &#x60;series&#x60; is the name of the series the article belongs to &#x60;canonical_url&#x60; is the canonical URL of the article &#x60;cover_image&#x60; is the main image of the article  *If the markdown contains a front matter, it will take precedence on the equivalent params given in the payload.* 
        /// </summary>
        /// <value>The body of the article.  It can contain an optional front matter. For example  &#x60;&#x60;&#x60;markdown - -- title: Hello, World! published: true tags: discuss, help date: 20190701T10:00Z series: Hello series canonical_url: https://example.com/blog/hello cover_image: article_published_cover_image - -- &#x60;&#x60;&#x60;  &#x60;date&#x60;, &#x60;series&#x60; and &#x60;canonical_url&#x60; are optional. &#x60;date&#x60; is the publication date-time &#x60;series&#x60; is the name of the series the article belongs to &#x60;canonical_url&#x60; is the canonical URL of the article &#x60;cover_image&#x60; is the main image of the article  *If the markdown contains a front matter, it will take precedence on the equivalent params given in the payload.* </value>
        [DataMember(Name = "body_markdown", EmitDefaultValue = false)]
        public string BodyMarkdown { get; set; }

        /// <summary>
        /// True to create a published article, false otherwise. Defaults to false 
        /// </summary>
        /// <value>True to create a published article, false otherwise. Defaults to false </value>
        [DataMember(Name = "published", EmitDefaultValue = true)]
        public bool Published { get; set; }

        /// <summary>
        /// Article series name.  All articles belonging to the same series need to have the same name in this parameter.  To remove an article from a series, the &#x60;null&#x60; value can be used. 
        /// </summary>
        /// <value>Article series name.  All articles belonging to the same series need to have the same name in this parameter.  To remove an article from a series, the &#x60;null&#x60; value can be used. </value>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        public string Series { get; set; }

        /// <summary>
        /// Gets or Sets MainImage
        /// </summary>
        [DataMember(Name = "main_image", EmitDefaultValue = false)]
        public string MainImage { get; set; }

        /// <summary>
        /// Gets or Sets CanonicalUrl
        /// </summary>
        [DataMember(Name = "canonical_url", EmitDefaultValue = false)]
        public string CanonicalUrl { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Only users belonging to an organization can assign the article to it 
        /// </summary>
        /// <value>Only users belonging to an organization can assign the article to it </value>
        [DataMember(Name = "organization_id", EmitDefaultValue = false)]
        public int OrganizationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArticleUpdateArticle {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  BodyMarkdown: ").Append(BodyMarkdown).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  MainImage: ").Append(MainImage).Append("\n");
            sb.Append("  CanonicalUrl: ").Append(CanonicalUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
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
            return this.Equals(input as ArticleUpdateArticle);
        }

        /// <summary>
        /// Returns true if ArticleUpdateArticle instances are equal
        /// </summary>
        /// <param name="input">Instance of ArticleUpdateArticle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleUpdateArticle input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.BodyMarkdown == input.BodyMarkdown ||
                    (this.BodyMarkdown != null &&
                    this.BodyMarkdown.Equals(input.BodyMarkdown))
                ) && 
                (
                    this.Published == input.Published ||
                    this.Published.Equals(input.Published)
                ) && 
                (
                    this.Series == input.Series ||
                    (this.Series != null &&
                    this.Series.Equals(input.Series))
                ) && 
                (
                    this.MainImage == input.MainImage ||
                    (this.MainImage != null &&
                    this.MainImage.Equals(input.MainImage))
                ) && 
                (
                    this.CanonicalUrl == input.CanonicalUrl ||
                    (this.CanonicalUrl != null &&
                    this.CanonicalUrl.Equals(input.CanonicalUrl))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    this.OrganizationId.Equals(input.OrganizationId)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.BodyMarkdown != null)
                {
                    hashCode = (hashCode * 59) + this.BodyMarkdown.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Published.GetHashCode();
                if (this.Series != null)
                {
                    hashCode = (hashCode * 59) + this.Series.GetHashCode();
                }
                if (this.MainImage != null)
                {
                    hashCode = (hashCode * 59) + this.MainImage.GetHashCode();
                }
                if (this.CanonicalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CanonicalUrl.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrganizationId.GetHashCode();
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
