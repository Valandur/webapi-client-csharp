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
    /// MMCTicketFull
    /// </summary>
    [DataContract]
    public partial class MMCTicketFull :  IEquatable<MMCTicketFull>, IValidatableObject
    {
        /// <summary>
        /// The current state of the ticket.
        /// </summary>
        /// <value>The current state of the ticket.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Claimed for "Claimed"
            /// </summary>
            [EnumMember(Value = "Claimed")]
            Claimed,
            
            /// <summary>
            /// Enum Held for "Held"
            /// </summary>
            [EnumMember(Value = "Held")]
            Held,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed
        }

        /// <summary>
        /// The current state of the ticket.
        /// </summary>
        /// <value>The current state of the ticket.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MMCTicketFull" /> class.
        /// </summary>
        /// <param name="Id">The id of the crate..</param>
        /// <param name="Timestamp">The name of the crate..</param>
        /// <param name="Sender">Sender.</param>
        /// <param name="Message">The message that the player sent in the ticket..</param>
        /// <param name="Comment">The comment added by staff..</param>
        /// <param name="Status">The current state of the ticket..</param>
        /// <param name="Staff">Staff.</param>
        /// <param name="Notified">0 if the assigned member has not been notified yet, 1 otherwise..</param>
        /// <param name="Location">Location.</param>
        public MMCTicketFull(string Id = default(string), decimal? Timestamp = default(decimal?), Player Sender = default(Player), string Message = default(string), string Comment = default(string), StatusEnum? Status = default(StatusEnum?), Player Staff = default(Player), decimal? Notified = default(decimal?), Location Location = default(Location))
        {
            this.Id = Id;
            this.Timestamp = Timestamp;
            this.Sender = Sender;
            this.Message = Message;
            this.Comment = Comment;
            this.Status = Status;
            this.Staff = Staff;
            this.Notified = Notified;
            this.Location = Location;
        }
        
        /// <summary>
        /// The id of the crate.
        /// </summary>
        /// <value>The id of the crate.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the crate.
        /// </summary>
        /// <value>The name of the crate.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public decimal? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public Player Sender { get; set; }

        /// <summary>
        /// The message that the player sent in the ticket.
        /// </summary>
        /// <value>The message that the player sent in the ticket.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The comment added by staff.
        /// </summary>
        /// <value>The comment added by staff.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }


        /// <summary>
        /// Gets or Sets Staff
        /// </summary>
        [DataMember(Name="staff", EmitDefaultValue=false)]
        public Player Staff { get; set; }

        /// <summary>
        /// 0 if the assigned member has not been notified yet, 1 otherwise.
        /// </summary>
        /// <value>0 if the assigned member has not been notified yet, 1 otherwise.</value>
        [DataMember(Name="notified", EmitDefaultValue=false)]
        public decimal? Notified { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MMCTicketFull {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Staff: ").Append(Staff).Append("\n");
            sb.Append("  Notified: ").Append(Notified).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as MMCTicketFull);
        }

        /// <summary>
        /// Returns true if MMCTicketFull instances are equal
        /// </summary>
        /// <param name="other">Instance of MMCTicketFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MMCTicketFull other)
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
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Sender == other.Sender ||
                    this.Sender != null &&
                    this.Sender.Equals(other.Sender)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Staff == other.Staff ||
                    this.Staff != null &&
                    this.Staff.Equals(other.Staff)
                ) && 
                (
                    this.Notified == other.Notified ||
                    this.Notified != null &&
                    this.Notified.Equals(other.Notified)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Sender != null)
                    hash = hash * 59 + this.Sender.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Staff != null)
                    hash = hash * 59 + this.Staff.GetHashCode();
                if (this.Notified != null)
                    hash = hash * 59 + this.Notified.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
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
