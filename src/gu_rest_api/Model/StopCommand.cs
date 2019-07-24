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
using OpenAPIDateConverter = GURestApi.Client.OpenAPIDateConverter;

namespace GURestApi.Model
{
    /// <summary>
    /// StopCommand
    /// </summary>
    [DataContract]
    public partial class StopCommand :  Command, IEquatable<StopCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopCommand" /> class.
        /// </summary>
        /// <param name="childId">id of asynchronous process, started with StartCommand.</param>
        public StopCommand(string childId = default(string))
            :base(CommandType.StopCommand)
        {
            this.ChildId = childId;
        }
        
        /// <summary>
        /// id of asynchronous process, started with StartCommand
        /// </summary>
        /// <value>id of asynchronous process, started with StartCommand</value>
        [DataMember(Name="childId", EmitDefaultValue=false)]
        public string ChildId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopCommand {\n");
            sb.Append("  ChildId: ").Append(ChildId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as StopCommand);
        }

        /// <summary>
        /// Returns true if StopCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of StopCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChildId == input.ChildId ||
                    (this.ChildId != null &&
                    this.ChildId.Equals(input.ChildId))
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
                if (this.ChildId != null)
                    hashCode = hashCode * 59 + this.ChildId.GetHashCode();
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