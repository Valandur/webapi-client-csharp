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
    /// ArmorStandData
    /// </summary>
    [DataContract]
    public partial class ArmorStandData :  IEquatable<ArmorStandData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorStandData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArmorStandData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorStandData" /> class.
        /// </summary>
        /// <param name="Arms">True if the armor stand has arms, false otherwise (required).</param>
        /// <param name="BasePlate">True if the armor stand has a base plate, false otherwise (required).</param>
        /// <param name="Marker">True if the armor stand has a marker, false otherwise (required).</param>
        /// <param name="Small">True if the armor stand is small, false otherwise (required).</param>
        public ArmorStandData(bool? Arms = default(bool?), bool? BasePlate = default(bool?), bool? Marker = default(bool?), bool? Small = default(bool?))
        {
            // to ensure "Arms" is required (not null)
            if (Arms == null)
            {
                throw new InvalidDataException("Arms is a required property for ArmorStandData and cannot be null");
            }
            else
            {
                this.Arms = Arms;
            }
            // to ensure "BasePlate" is required (not null)
            if (BasePlate == null)
            {
                throw new InvalidDataException("BasePlate is a required property for ArmorStandData and cannot be null");
            }
            else
            {
                this.BasePlate = BasePlate;
            }
            // to ensure "Marker" is required (not null)
            if (Marker == null)
            {
                throw new InvalidDataException("Marker is a required property for ArmorStandData and cannot be null");
            }
            else
            {
                this.Marker = Marker;
            }
            // to ensure "Small" is required (not null)
            if (Small == null)
            {
                throw new InvalidDataException("Small is a required property for ArmorStandData and cannot be null");
            }
            else
            {
                this.Small = Small;
            }
        }
        
        /// <summary>
        /// True if the armor stand has arms, false otherwise
        /// </summary>
        /// <value>True if the armor stand has arms, false otherwise</value>
        [DataMember(Name="arms", EmitDefaultValue=false)]
        public bool? Arms { get; set; }

        /// <summary>
        /// True if the armor stand has a base plate, false otherwise
        /// </summary>
        /// <value>True if the armor stand has a base plate, false otherwise</value>
        [DataMember(Name="basePlate", EmitDefaultValue=false)]
        public bool? BasePlate { get; set; }

        /// <summary>
        /// True if the armor stand has a marker, false otherwise
        /// </summary>
        /// <value>True if the armor stand has a marker, false otherwise</value>
        [DataMember(Name="marker", EmitDefaultValue=false)]
        public bool? Marker { get; set; }

        /// <summary>
        /// True if the armor stand is small, false otherwise
        /// </summary>
        /// <value>True if the armor stand is small, false otherwise</value>
        [DataMember(Name="small", EmitDefaultValue=false)]
        public bool? Small { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArmorStandData {\n");
            sb.Append("  Arms: ").Append(Arms).Append("\n");
            sb.Append("  BasePlate: ").Append(BasePlate).Append("\n");
            sb.Append("  Marker: ").Append(Marker).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
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
            return this.Equals(input as ArmorStandData);
        }

        /// <summary>
        /// Returns true if ArmorStandData instances are equal
        /// </summary>
        /// <param name="input">Instance of ArmorStandData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArmorStandData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arms == input.Arms ||
                    (this.Arms != null &&
                    this.Arms.Equals(input.Arms))
                ) && 
                (
                    this.BasePlate == input.BasePlate ||
                    (this.BasePlate != null &&
                    this.BasePlate.Equals(input.BasePlate))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Small == input.Small ||
                    (this.Small != null &&
                    this.Small.Equals(input.Small))
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
                if (this.Arms != null)
                    hashCode = hashCode * 59 + this.Arms.GetHashCode();
                if (this.BasePlate != null)
                    hashCode = hashCode * 59 + this.BasePlate.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Small != null)
                    hashCode = hashCode * 59 + this.Small.GetHashCode();
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
