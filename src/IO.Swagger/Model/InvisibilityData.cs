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
    /// InvisibilityData
    /// </summary>
    [DataContract]
    public partial class InvisibilityData :  IEquatable<InvisibilityData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvisibilityData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvisibilityData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvisibilityData" /> class.
        /// </summary>
        /// <param name="ignoreCollision">True if this entity ignores collisions, false otherwise (required).</param>
        /// <param name="invisible">True if this entity is invisible, false otherwise (required).</param>
        /// <param name="untargetable">True if this entity is not targetable, false otherwise (required).</param>
        /// <param name="vanish">True if this entity is vanished, false otherwise (required).</param>
        public InvisibilityData(bool? ignoreCollision = default(bool?), bool? invisible = default(bool?), bool? untargetable = default(bool?), bool? vanish = default(bool?))
        {
            // to ensure "ignoreCollision" is required (not null)
            if (ignoreCollision == null)
            {
                throw new InvalidDataException("ignoreCollision is a required property for InvisibilityData and cannot be null");
            }
            else
            {
                this.IgnoreCollision = ignoreCollision;
            }
            // to ensure "invisible" is required (not null)
            if (invisible == null)
            {
                throw new InvalidDataException("invisible is a required property for InvisibilityData and cannot be null");
            }
            else
            {
                this.Invisible = invisible;
            }
            // to ensure "untargetable" is required (not null)
            if (untargetable == null)
            {
                throw new InvalidDataException("untargetable is a required property for InvisibilityData and cannot be null");
            }
            else
            {
                this.Untargetable = untargetable;
            }
            // to ensure "vanish" is required (not null)
            if (vanish == null)
            {
                throw new InvalidDataException("vanish is a required property for InvisibilityData and cannot be null");
            }
            else
            {
                this.Vanish = vanish;
            }
        }
        
        /// <summary>
        /// True if this entity ignores collisions, false otherwise
        /// </summary>
        /// <value>True if this entity ignores collisions, false otherwise</value>
        [DataMember(Name="ignoreCollision", EmitDefaultValue=false)]
        public bool? IgnoreCollision { get; set; }

        /// <summary>
        /// True if this entity is invisible, false otherwise
        /// </summary>
        /// <value>True if this entity is invisible, false otherwise</value>
        [DataMember(Name="invisible", EmitDefaultValue=false)]
        public bool? Invisible { get; set; }

        /// <summary>
        /// True if this entity is not targetable, false otherwise
        /// </summary>
        /// <value>True if this entity is not targetable, false otherwise</value>
        [DataMember(Name="untargetable", EmitDefaultValue=false)]
        public bool? Untargetable { get; set; }

        /// <summary>
        /// True if this entity is vanished, false otherwise
        /// </summary>
        /// <value>True if this entity is vanished, false otherwise</value>
        [DataMember(Name="vanish", EmitDefaultValue=false)]
        public bool? Vanish { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvisibilityData {\n");
            sb.Append("  IgnoreCollision: ").Append(IgnoreCollision).Append("\n");
            sb.Append("  Invisible: ").Append(Invisible).Append("\n");
            sb.Append("  Untargetable: ").Append(Untargetable).Append("\n");
            sb.Append("  Vanish: ").Append(Vanish).Append("\n");
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
            return this.Equals(input as InvisibilityData);
        }

        /// <summary>
        /// Returns true if InvisibilityData instances are equal
        /// </summary>
        /// <param name="input">Instance of InvisibilityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvisibilityData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IgnoreCollision == input.IgnoreCollision ||
                    (this.IgnoreCollision != null &&
                    this.IgnoreCollision.Equals(input.IgnoreCollision))
                ) && 
                (
                    this.Invisible == input.Invisible ||
                    (this.Invisible != null &&
                    this.Invisible.Equals(input.Invisible))
                ) && 
                (
                    this.Untargetable == input.Untargetable ||
                    (this.Untargetable != null &&
                    this.Untargetable.Equals(input.Untargetable))
                ) && 
                (
                    this.Vanish == input.Vanish ||
                    (this.Vanish != null &&
                    this.Vanish.Equals(input.Vanish))
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
                if (this.IgnoreCollision != null)
                    hashCode = hashCode * 59 + this.IgnoreCollision.GetHashCode();
                if (this.Invisible != null)
                    hashCode = hashCode * 59 + this.Invisible.GetHashCode();
                if (this.Untargetable != null)
                    hashCode = hashCode * 59 + this.Untargetable.GetHashCode();
                if (this.Vanish != null)
                    hashCode = hashCode * 59 + this.Vanish.GetHashCode();
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
