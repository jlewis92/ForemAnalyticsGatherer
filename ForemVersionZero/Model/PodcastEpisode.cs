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
    /// PodcastEpisode
    /// </summary>
    [DataContract(Name = "PodcastEpisode")]
    public partial class PodcastEpisode : IEquatable<PodcastEpisode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PodcastEpisode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisode" /> class.
        /// </summary>
        /// <param name="typeOf">typeOf (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="path">path (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="podcast">podcast (required).</param>
        public PodcastEpisode(string typeOf = default(string), int id = default(int), string path = default(string), string imageUrl = default(string), string title = default(string), PodcastEpisodePodcast podcast = default(PodcastEpisodePodcast))
        {
            // to ensure "typeOf" is required (not null)
            if (typeOf == null)
            {
                throw new ArgumentNullException("typeOf is a required property for PodcastEpisode and cannot be null");
            }
            this.TypeOf = typeOf;
            this.Id = id;
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for PodcastEpisode and cannot be null");
            }
            this.Path = path;
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new ArgumentNullException("imageUrl is a required property for PodcastEpisode and cannot be null");
            }
            this.ImageUrl = imageUrl;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for PodcastEpisode and cannot be null");
            }
            this.Title = title;
            // to ensure "podcast" is required (not null)
            if (podcast == null)
            {
                throw new ArgumentNullException("podcast is a required property for PodcastEpisode and cannot be null");
            }
            this.Podcast = podcast;
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
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "image_url", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Podcast
        /// </summary>
        [DataMember(Name = "podcast", IsRequired = true, EmitDefaultValue = true)]
        public PodcastEpisodePodcast Podcast { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PodcastEpisode {\n");
            sb.Append("  TypeOf: ").Append(TypeOf).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Podcast: ").Append(Podcast).Append("\n");
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
            return this.Equals(input as PodcastEpisode);
        }

        /// <summary>
        /// Returns true if PodcastEpisode instances are equal
        /// </summary>
        /// <param name="input">Instance of PodcastEpisode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PodcastEpisode input)
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
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Podcast == input.Podcast ||
                    (this.Podcast != null &&
                    this.Podcast.Equals(input.Podcast))
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
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Podcast != null)
                {
                    hashCode = (hashCode * 59) + this.Podcast.GetHashCode();
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
