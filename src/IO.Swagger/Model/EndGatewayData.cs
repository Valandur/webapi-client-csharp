/* 
 * Web-API
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/v5...  As a quick test try reaching the route http:/localhost:8080/api/v5/info (remember that you can only access \\\"localhost\\\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # List endpoints Lots of objects offer an endpoint to list all objects (e.g. `GET: /world` to get all worlds). These endpoints return only the properties marked 'required' by default, because the list might be quite large. If you want to return ALL data for a list endpoint add the query parameter `details`, (e.g. `GET: /world?details`).  > Remember that in this case the data returned by the endpoint might be quite large.  # Debugging endpoints Apart from the `?details` flag you can also pass some other flags for debugging purposes. Remember that you must include the first query parameter with `?`, and further ones with `&`:  `details`: Includes details for list endpoints  `accept=[json/xml]`: Manually set the accept content type. This is good for browser testing, **BUT DON'T USE THIS IN PRODUCTION, YOU CAN SUPPLY THE `Accepts` HEADER FOR THAT**  `pretty`: Pretty prints the data, also good for debugging in the browser.  An example request might look like this: `http://localhost:8080/api/v5/world?details&accpet=json&pretty&key=MY-API-KEY`  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md)
 *
 * OpenAPI spec version: @version@
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
    /// EndGatewayData
    /// </summary>
    [DataContract]
    public partial class EndGatewayData :  IEquatable<EndGatewayData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndGatewayData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EndGatewayData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndGatewayData" /> class.
        /// </summary>
        /// <param name="Age">The age of this gateway (required).</param>
        /// <param name="ExactTeleport">True if this is an exact teleport, false otherwise (required).</param>
        /// <param name="ExitPosition">The exit position in the nether (required).</param>
        /// <param name="TeleportCooldown">The cooldown of the teleport (required).</param>
        public EndGatewayData(long? Age = default(long?), bool? ExactTeleport = default(bool?), Vector3i ExitPosition = default(Vector3i), int? TeleportCooldown = default(int?))
        {
            // to ensure "Age" is required (not null)
            if (Age == null)
            {
                throw new InvalidDataException("Age is a required property for EndGatewayData and cannot be null");
            }
            else
            {
                this.Age = Age;
            }
            // to ensure "ExactTeleport" is required (not null)
            if (ExactTeleport == null)
            {
                throw new InvalidDataException("ExactTeleport is a required property for EndGatewayData and cannot be null");
            }
            else
            {
                this.ExactTeleport = ExactTeleport;
            }
            // to ensure "ExitPosition" is required (not null)
            if (ExitPosition == null)
            {
                throw new InvalidDataException("ExitPosition is a required property for EndGatewayData and cannot be null");
            }
            else
            {
                this.ExitPosition = ExitPosition;
            }
            // to ensure "TeleportCooldown" is required (not null)
            if (TeleportCooldown == null)
            {
                throw new InvalidDataException("TeleportCooldown is a required property for EndGatewayData and cannot be null");
            }
            else
            {
                this.TeleportCooldown = TeleportCooldown;
            }
        }
        
        /// <summary>
        /// The age of this gateway
        /// </summary>
        /// <value>The age of this gateway</value>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public long? Age { get; set; }

        /// <summary>
        /// True if this is an exact teleport, false otherwise
        /// </summary>
        /// <value>True if this is an exact teleport, false otherwise</value>
        [DataMember(Name="exactTeleport", EmitDefaultValue=false)]
        public bool? ExactTeleport { get; set; }

        /// <summary>
        /// The exit position in the nether
        /// </summary>
        /// <value>The exit position in the nether</value>
        [DataMember(Name="exitPosition", EmitDefaultValue=false)]
        public Vector3i ExitPosition { get; set; }

        /// <summary>
        /// The cooldown of the teleport
        /// </summary>
        /// <value>The cooldown of the teleport</value>
        [DataMember(Name="teleportCooldown", EmitDefaultValue=false)]
        public int? TeleportCooldown { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndGatewayData {\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  ExactTeleport: ").Append(ExactTeleport).Append("\n");
            sb.Append("  ExitPosition: ").Append(ExitPosition).Append("\n");
            sb.Append("  TeleportCooldown: ").Append(TeleportCooldown).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndGatewayData);
        }

        /// <summary>
        /// Returns true if EndGatewayData instances are equal
        /// </summary>
        /// <param name="input">Instance of EndGatewayData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndGatewayData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.ExactTeleport == input.ExactTeleport ||
                    (this.ExactTeleport != null &&
                    this.ExactTeleport.Equals(input.ExactTeleport))
                ) && 
                (
                    this.ExitPosition == input.ExitPosition ||
                    (this.ExitPosition != null &&
                    this.ExitPosition.Equals(input.ExitPosition))
                ) && 
                (
                    this.TeleportCooldown == input.TeleportCooldown ||
                    (this.TeleportCooldown != null &&
                    this.TeleportCooldown.Equals(input.TeleportCooldown))
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
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.ExactTeleport != null)
                    hashCode = hashCode * 59 + this.ExactTeleport.GetHashCode();
                if (this.ExitPosition != null)
                    hashCode = hashCode * 59 + this.ExitPosition.GetHashCode();
                if (this.TeleportCooldown != null)
                    hashCode = hashCode * 59 + this.TeleportCooldown.GetHashCode();
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
