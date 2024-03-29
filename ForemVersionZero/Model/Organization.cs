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
    /// Organization
    /// </summary>
    [DataContract(Name = "Organization")]
    public partial class Organization : IEquatable<Organization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="typeOf">typeOf.</param>
        /// <param name="username">username.</param>
        /// <param name="name">name.</param>
        /// <param name="summary">summary.</param>
        /// <param name="twitterUsername">twitterUsername.</param>
        /// <param name="githubUsername">githubUsername.</param>
        /// <param name="url">url.</param>
        /// <param name="location">location.</param>
        /// <param name="techStack">techStack.</param>
        /// <param name="tagLine">tagLine.</param>
        /// <param name="story">story.</param>
        /// <param name="joinedAt">Date of joining.</param>
        /// <param name="profileImage">Profile image (640x640).</param>
        public Organization(string typeOf = default(string), string username = default(string), string name = default(string), string summary = default(string), string twitterUsername = default(string), string githubUsername = default(string), string url = default(string), string location = default(string), string techStack = default(string), string tagLine = default(string), string story = default(string), DateTime joinedAt = default(DateTime), string profileImage = default(string))
        {
            this.TypeOf = typeOf;
            this.Username = username;
            this.Name = name;
            this.Summary = summary;
            this.TwitterUsername = twitterUsername;
            this.GithubUsername = githubUsername;
            this.Url = url;
            this.Location = location;
            this.TechStack = techStack;
            this.TagLine = tagLine;
            this.Story = story;
            this.JoinedAt = joinedAt;
            this.ProfileImage = profileImage;
        }

        /// <summary>
        /// Gets or Sets TypeOf
        /// </summary>
        [DataMember(Name = "type_of", EmitDefaultValue = false)]
        public string TypeOf { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets TwitterUsername
        /// </summary>
        [DataMember(Name = "twitter_username", EmitDefaultValue = true)]
        public string TwitterUsername { get; set; }

        /// <summary>
        /// Gets or Sets GithubUsername
        /// </summary>
        [DataMember(Name = "github_username", EmitDefaultValue = true)]
        public string GithubUsername { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets TechStack
        /// </summary>
        [DataMember(Name = "tech_stack", EmitDefaultValue = true)]
        public string TechStack { get; set; }

        /// <summary>
        /// Gets or Sets TagLine
        /// </summary>
        [DataMember(Name = "tag_line", EmitDefaultValue = true)]
        public string TagLine { get; set; }

        /// <summary>
        /// Gets or Sets Story
        /// </summary>
        [DataMember(Name = "story", EmitDefaultValue = true)]
        public string Story { get; set; }

        /// <summary>
        /// Date of joining
        /// </summary>
        /// <value>Date of joining</value>
        [DataMember(Name = "joined_at", EmitDefaultValue = false)]
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// Profile image (640x640)
        /// </summary>
        /// <value>Profile image (640x640)</value>
        [DataMember(Name = "profile_image", EmitDefaultValue = false)]
        public string ProfileImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Organization {\n");
            sb.Append("  TypeOf: ").Append(TypeOf).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  TwitterUsername: ").Append(TwitterUsername).Append("\n");
            sb.Append("  GithubUsername: ").Append(GithubUsername).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TechStack: ").Append(TechStack).Append("\n");
            sb.Append("  TagLine: ").Append(TagLine).Append("\n");
            sb.Append("  Story: ").Append(Story).Append("\n");
            sb.Append("  JoinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  ProfileImage: ").Append(ProfileImage).Append("\n");
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
            return this.Equals(input as Organization);
        }

        /// <summary>
        /// Returns true if Organization instances are equal
        /// </summary>
        /// <param name="input">Instance of Organization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organization input)
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.TwitterUsername == input.TwitterUsername ||
                    (this.TwitterUsername != null &&
                    this.TwitterUsername.Equals(input.TwitterUsername))
                ) && 
                (
                    this.GithubUsername == input.GithubUsername ||
                    (this.GithubUsername != null &&
                    this.GithubUsername.Equals(input.GithubUsername))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.TechStack == input.TechStack ||
                    (this.TechStack != null &&
                    this.TechStack.Equals(input.TechStack))
                ) && 
                (
                    this.TagLine == input.TagLine ||
                    (this.TagLine != null &&
                    this.TagLine.Equals(input.TagLine))
                ) && 
                (
                    this.Story == input.Story ||
                    (this.Story != null &&
                    this.Story.Equals(input.Story))
                ) && 
                (
                    this.JoinedAt == input.JoinedAt ||
                    (this.JoinedAt != null &&
                    this.JoinedAt.Equals(input.JoinedAt))
                ) && 
                (
                    this.ProfileImage == input.ProfileImage ||
                    (this.ProfileImage != null &&
                    this.ProfileImage.Equals(input.ProfileImage))
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
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.TwitterUsername != null)
                {
                    hashCode = (hashCode * 59) + this.TwitterUsername.GetHashCode();
                }
                if (this.GithubUsername != null)
                {
                    hashCode = (hashCode * 59) + this.GithubUsername.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.TechStack != null)
                {
                    hashCode = (hashCode * 59) + this.TechStack.GetHashCode();
                }
                if (this.TagLine != null)
                {
                    hashCode = (hashCode * 59) + this.TagLine.GetHashCode();
                }
                if (this.Story != null)
                {
                    hashCode = (hashCode * 59) + this.Story.GetHashCode();
                }
                if (this.JoinedAt != null)
                {
                    hashCode = (hashCode * 59) + this.JoinedAt.GetHashCode();
                }
                if (this.ProfileImage != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileImage.GetHashCode();
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
