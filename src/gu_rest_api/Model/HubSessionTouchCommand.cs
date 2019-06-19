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
    /// HubSessionTouchCommand
    /// </summary>
    [DataContract]
    public partial class HubSessionTouchCommand : HubSessionCommand,  IEquatable<HubSessionTouchCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubSessionTouchCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HubSessionTouchCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HubSessionTouchCommand" /> class.
        /// </summary>
        /// <param name="keepUntil">keepUntil.</param>
        public HubSessionTouchCommand(DateTime? keepUntil = default(DateTime?), string commandType = default(string), DateTime? ts = default(DateTime?)) : base(commandType, ts)
        {
            this.KeepUntil = keepUntil;
        }
        
        /// <summary>
        /// Gets or Sets KeepUntil
        /// </summary>
        [DataMember(Name="keepUntil", EmitDefaultValue=false)]
        public DateTime? KeepUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HubSessionTouchCommand {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  KeepUntil: ").Append(KeepUntil).Append("\n");
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
            return this.Equals(input as HubSessionTouchCommand);
        }

        /// <summary>
        /// Returns true if HubSessionTouchCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of HubSessionTouchCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HubSessionTouchCommand input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.KeepUntil == input.KeepUntil ||
                    (this.KeepUntil != null &&
                    this.KeepUntil.Equals(input.KeepUntil))
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
                int hashCode = base.GetHashCode();
                if (this.KeepUntil != null)
                    hashCode = hashCode * 59 + this.KeepUntil.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
