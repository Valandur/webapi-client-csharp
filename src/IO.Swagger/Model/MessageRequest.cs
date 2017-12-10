/* 
 * WebAPI
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/...  As a quick test try reaching the route http:/localhost:8080/api/info (remember that you can only access \"localhost\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md) 
 *
 * OpenAPI spec version: <version>
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// MessageRequest
    /// </summary>
    [DataContract]
    public partial class MessageRequest :  IEquatable<MessageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRequest" /> class.
        /// </summary>
        /// <param name="Id">The id of the message. This will be sent back in the reply, so you can identify the request..</param>
        /// <param name="Target">The UUID of the player this message is sent to..</param>
        /// <param name="Message">The message sent to the player. Text formatting can be applied with ampersand formatting..</param>
        /// <param name="Once">True if the target can only select one response for this message (further responses are not sent to the webhook endpoint) .</param>
        /// <param name="Options">These are the options the player can choose from. The key is sent back to the server, the value is displayed to the player. .</param>
        public MessageRequest(string Id = default(string), string Target = default(string), string Message = default(string), bool? Once = default(bool?), List<MessageOption> Options = default(List<MessageOption>))
        {
            this.Id = Id;
            this.Target = Target;
            this.Message = Message;
            this.Once = Once;
            this.Options = Options;
        }
        
        /// <summary>
        /// The id of the message. This will be sent back in the reply, so you can identify the request.
        /// </summary>
        /// <value>The id of the message. This will be sent back in the reply, so you can identify the request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The UUID of the player this message is sent to.
        /// </summary>
        /// <value>The UUID of the player this message is sent to.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }

        /// <summary>
        /// The message sent to the player. Text formatting can be applied with ampersand formatting.
        /// </summary>
        /// <value>The message sent to the player. Text formatting can be applied with ampersand formatting.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// True if the target can only select one response for this message (further responses are not sent to the webhook endpoint) 
        /// </summary>
        /// <value>True if the target can only select one response for this message (further responses are not sent to the webhook endpoint) </value>
        [DataMember(Name="once", EmitDefaultValue=false)]
        public bool? Once { get; set; }

        /// <summary>
        /// These are the options the player can choose from. The key is sent back to the server, the value is displayed to the player. 
        /// </summary>
        /// <value>These are the options the player can choose from. The key is sent back to the server, the value is displayed to the player. </value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<MessageOption> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Once: ").Append(Once).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MessageRequest);
        }

        /// <summary>
        /// Returns true if MessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Once == other.Once ||
                    this.Once != null &&
                    this.Once.Equals(other.Once)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Once != null)
                    hash = hash * 59 + this.Once.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                return hash;
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
