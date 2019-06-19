/* 
 * Golem unlimited low level hub API
 *
 * API description in Markdown.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = gu_rest_api.Client.OpenAPIDateConverter;

namespace gu_rest_api.Model
{
    /// <summary>
    /// DeploymentSpec
    /// </summary>
    [DataContract]
    public partial class DeploymentSpec :  IEquatable<DeploymentSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentSpec" /> class.
        /// </summary>
        /// <param name="envType">envType.</param>
        /// <param name="image">image.</param>
        /// <param name="name">human readable name.</param>
        /// <param name="tags">deployment tags.</param>
        /// <param name="options">options.</param>
        public DeploymentSpec(EnvType envType = default(EnvType), DeploymentSpecImage image = default(DeploymentSpecImage), string name = default(string), List<string> tags = default(List<string>), Object options = default(Object))
        {
            this.EnvType = envType;
            this.Image = image;
            this.Name = name;
            this.Tags = tags;
            this.Options = options;
        }
        
        /// <summary>
        /// Gets or Sets EnvType
        /// </summary>
        [DataMember(Name="envType", EmitDefaultValue=false)]
        public EnvType EnvType { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public DeploymentSpecImage Image { get; set; }

        /// <summary>
        /// human readable name
        /// </summary>
        /// <value>human readable name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// deployment tags
        /// </summary>
        /// <value>deployment tags</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Object Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentSpec {\n");
            sb.Append("  EnvType: ").Append(EnvType).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentSpec);
        }

        /// <summary>
        /// Returns true if DeploymentSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of DeploymentSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnvType == input.EnvType ||
                    (this.EnvType != null &&
                    this.EnvType.Equals(input.EnvType))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.EnvType != null)
                    hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
