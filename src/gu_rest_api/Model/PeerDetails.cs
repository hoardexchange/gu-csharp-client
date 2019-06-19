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
    /// PeerDetails
    /// </summary>
    [DataContract]
    public partial class PeerDetails :  IEquatable<PeerDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeerDetails" /> class.
        /// </summary>
        /// <param name="nodeName">Node name or hostname from reverse dns if node name is not set.</param>
        /// <param name="peerAddr">node address from current connection formated as &lt;ip-addr&gt;:&lt;port&gt;.</param>
        /// <param name="tags">tags.</param>
        /// <param name="sessions">sessions.</param>
        public PeerDetails(string nodeName = default(string), string peerAddr = default(string), List<string> tags = default(List<string>), List<DeploymentInfo> sessions = default(List<DeploymentInfo>))
        {
            this.NodeName = nodeName;
            this.PeerAddr = peerAddr;
            this.Tags = tags;
            this.Sessions = sessions;
        }
        
        /// <summary>
        /// Node name or hostname from reverse dns if node name is not set
        /// </summary>
        /// <value>Node name or hostname from reverse dns if node name is not set</value>
        [DataMember(Name="nodeName", EmitDefaultValue=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// node address from current connection formated as &lt;ip-addr&gt;:&lt;port&gt;
        /// </summary>
        /// <value>node address from current connection formated as &lt;ip-addr&gt;:&lt;port&gt;</value>
        [DataMember(Name="peerAddr", EmitDefaultValue=false)]
        public string PeerAddr { get; set; }

        /// <summary>
        /// node public key hash in etherium format
        /// </summary>
        /// <value>node public key hash in etherium format</value>
        [DataMember(Name="nodeId", EmitDefaultValue=false)]
        public string NodeId { get; private set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Sessions
        /// </summary>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<DeploymentInfo> Sessions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeerDetails {\n");
            sb.Append("  NodeName: ").Append(NodeName).Append("\n");
            sb.Append("  PeerAddr: ").Append(PeerAddr).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
            return this.Equals(input as PeerDetails);
        }

        /// <summary>
        /// Returns true if PeerDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PeerDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeerDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.PeerAddr == input.PeerAddr ||
                    (this.PeerAddr != null &&
                    this.PeerAddr.Equals(input.PeerAddr))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Sessions == input.Sessions ||
                    this.Sessions != null &&
                    this.Sessions.SequenceEqual(input.Sessions)
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
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.PeerAddr != null)
                    hashCode = hashCode * 59 + this.PeerAddr.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Sessions != null)
                    hashCode = hashCode * 59 + this.Sessions.GetHashCode();
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
