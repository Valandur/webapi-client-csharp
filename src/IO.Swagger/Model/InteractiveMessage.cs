/* 
 * Web-API
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/v5...  As a quick test try reaching the route http:/localhost:8080/api/v5/info (remember that you can only access \\\"localhost\\\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # List endpoints Lots of objects offer an endpoint to list all objects (e.g. `GET: /world` to get all worlds). These endpoints return only the properties marked 'required' by default, because the list might be quite large. If you want to return ALL data for a list endpoint add the query parameter `details`, (e.g. `GET: /world?details`).  > Remember that in this case the data returned by the endpoint might be quite large.  # Debugging endpoints Apart from the `?details` flag you can also pass some other flags for debugging purposes. Remember that you must include the first query parameter with `?`, and further ones with `&`:  `details`: Includes details for list endpoints  `accept=[json/xml]`: Manually set the accept content type. This is good for browser testing, **BUT DON'T USE THIS IN PRODUCTION, YOU CAN SUPPLY THE `Accepts` HEADER FOR THAT**  `pretty`: Pretty prints the data, also good for debugging in the browser.  An example request might look like this: `http://localhost:8080/api/v5/world?details&accpet=json&pretty&key=MY-API-KEY`  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md)
 *
 * OpenAPI spec version: 5.4.2-S7.1.0
 * Contact: inithilian@gmail.com
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
    /// InteractiveMessage
    /// </summary>
    [DataContract]
    public partial class InteractiveMessage :  IEquatable<InteractiveMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InteractiveMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveMessage" /> class.
        /// </summary>
        /// <param name="id">The id of the message. Used to identify responses. (required).</param>
        /// <param name="target">The target of the message, usually this is a player UUID. Can be set to \&quot;server\&quot; to send to all online players. (required).</param>
        /// <param name="uuid">The unique UUID of this message (required).</param>
        /// <param name="message">The actual content of the message.</param>
        /// <param name="once">True if this message can only be replied to once per target, false otherwise.</param>
        /// <param name="options">Clickable options that the player can select from.</param>
        /// <param name="targets">A list of targets that will receive the message. Usually a list of player UUIDs.</param>
        public InteractiveMessage(string id = default(string), string target = default(string), Guid? uuid = default(Guid?), string message = default(string), bool? once = default(bool?), List<InteractiveMessageOption> options = default(List<InteractiveMessageOption>), List<string> targets = default(List<string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InteractiveMessage and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new InvalidDataException("target is a required property for InteractiveMessage and cannot be null");
            }
            else
            {
                this.Target = target;
            }
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new InvalidDataException("uuid is a required property for InteractiveMessage and cannot be null");
            }
            else
            {
                this.Uuid = uuid;
            }
            this.Message = message;
            this.Once = once;
            this.Options = options;
            this.Targets = targets;
        }
        
        /// <summary>
        /// The id of the message. Used to identify responses.
        /// </summary>
        /// <value>The id of the message. Used to identify responses.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The API link that can be used to obtain more information about this object
        /// </summary>
        /// <value>The API link that can be used to obtain more information about this object</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; private set; }

        /// <summary>
        /// The target of the message, usually this is a player UUID. Can be set to \&quot;server\&quot; to send to all online players.
        /// </summary>
        /// <value>The target of the message, usually this is a player UUID. Can be set to \&quot;server\&quot; to send to all online players.</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }

        /// <summary>
        /// The unique UUID of this message
        /// </summary>
        /// <value>The unique UUID of this message</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// The actual content of the message
        /// </summary>
        /// <value>The actual content of the message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// True if this message can only be replied to once per target, false otherwise
        /// </summary>
        /// <value>True if this message can only be replied to once per target, false otherwise</value>
        [DataMember(Name="once", EmitDefaultValue=false)]
        public bool? Once { get; set; }

        /// <summary>
        /// Clickable options that the player can select from
        /// </summary>
        /// <value>Clickable options that the player can select from</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<InteractiveMessageOption> Options { get; set; }

        /// <summary>
        /// A list of targets that will receive the message. Usually a list of player UUIDs
        /// </summary>
        /// <value>A list of targets that will receive the message. Usually a list of player UUIDs</value>
        [DataMember(Name="targets", EmitDefaultValue=false)]
        public List<string> Targets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InteractiveMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Once: ").Append(Once).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");
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
            return this.Equals(input as InteractiveMessage);
        }

        /// <summary>
        /// Returns true if InteractiveMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of InteractiveMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteractiveMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Once == input.Once ||
                    (this.Once != null &&
                    this.Once.Equals(input.Once))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Targets == input.Targets ||
                    this.Targets != null &&
                    this.Targets.SequenceEqual(input.Targets)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Once != null)
                    hashCode = hashCode * 59 + this.Once.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Targets != null)
                    hashCode = hashCode * 59 + this.Targets.GetHashCode();
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
