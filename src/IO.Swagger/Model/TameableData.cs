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
    /// TameableData
    /// </summary>
    [DataContract]
    public partial class TameableData :  IEquatable<TameableData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TameableData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TameableData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TameableData" /> class.
        /// </summary>
        /// <param name="Tamed">True if this entity is tamed, false otherwise (required).</param>
        /// <param name="Owner">The UUID of the entity which tamed this entity.</param>
        public TameableData(bool? Tamed = default(bool?), Guid? Owner = default(Guid?))
        {
            // to ensure "Tamed" is required (not null)
            if (Tamed == null)
            {
                throw new InvalidDataException("Tamed is a required property for TameableData and cannot be null");
            }
            else
            {
                this.Tamed = Tamed;
            }
            this.Owner = Owner;
        }
        
        /// <summary>
        /// True if this entity is tamed, false otherwise
        /// </summary>
        /// <value>True if this entity is tamed, false otherwise</value>
        [DataMember(Name="tamed", EmitDefaultValue=false)]
        public bool? Tamed { get; set; }

        /// <summary>
        /// The UUID of the entity which tamed this entity
        /// </summary>
        /// <value>The UUID of the entity which tamed this entity</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public Guid? Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TameableData {\n");
            sb.Append("  Tamed: ").Append(Tamed).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as TameableData);
        }

        /// <summary>
        /// Returns true if TameableData instances are equal
        /// </summary>
        /// <param name="input">Instance of TameableData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TameableData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tamed == input.Tamed ||
                    (this.Tamed != null &&
                    this.Tamed.Equals(input.Tamed))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.Tamed != null)
                    hashCode = hashCode * 59 + this.Tamed.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
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