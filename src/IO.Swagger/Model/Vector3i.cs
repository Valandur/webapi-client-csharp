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
    /// Vector3i
    /// </summary>
    [DataContract]
    public partial class Vector3i :  IEquatable<Vector3i>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3i" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Vector3i() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3i" /> class.
        /// </summary>
        /// <param name="x">The x-coordinate (required).</param>
        /// <param name="y">The y-coordinate (required).</param>
        /// <param name="z">The z-coordinate (required).</param>
        public Vector3i(int? x = default(int?), int? y = default(int?), int? z = default(int?))
        {
            // to ensure "x" is required (not null)
            if (x == null)
            {
                throw new InvalidDataException("x is a required property for Vector3i and cannot be null");
            }
            else
            {
                this.X = x;
            }
            // to ensure "y" is required (not null)
            if (y == null)
            {
                throw new InvalidDataException("y is a required property for Vector3i and cannot be null");
            }
            else
            {
                this.Y = y;
            }
            // to ensure "z" is required (not null)
            if (z == null)
            {
                throw new InvalidDataException("z is a required property for Vector3i and cannot be null");
            }
            else
            {
                this.Z = z;
            }
        }
        
        /// <summary>
        /// The x-coordinate
        /// </summary>
        /// <value>The x-coordinate</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// The y-coordinate
        /// </summary>
        /// <value>The y-coordinate</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// The z-coordinate
        /// </summary>
        /// <value>The z-coordinate</value>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public int? Z { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vector3i {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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
            return this.Equals(input as Vector3i);
        }

        /// <summary>
        /// Returns true if Vector3i instances are equal
        /// </summary>
        /// <param name="input">Instance of Vector3i to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vector3i input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.Z == input.Z ||
                    (this.Z != null &&
                    this.Z.Equals(input.Z))
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
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Z != null)
                    hashCode = hashCode * 59 + this.Z.GetHashCode();
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
