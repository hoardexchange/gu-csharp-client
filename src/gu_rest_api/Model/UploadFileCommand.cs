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
    /// UploadFileCommand
    /// </summary>
    [DataContract]
    public partial class UploadFileCommand :  IEquatable<UploadFileCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileCommand" /> class.
        /// </summary>
        /// <param name="uri">uri.</param>
        /// <param name="filePath">filePath.</param>
        public UploadFileCommand(string uri = default(string), string filePath = default(string))
        {
            this.Uri = uri;
            this.FilePath = filePath;
        }
        
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets FilePath
        /// </summary>
        [DataMember(Name="filePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadFileCommand {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
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
            return this.Equals(input as UploadFileCommand);
        }

        /// <summary>
        /// Returns true if UploadFileCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadFileCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadFileCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
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
