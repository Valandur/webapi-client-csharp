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
    /// Color
    /// </summary>
    [DataContract]
    public partial class Color :  IEquatable<Color>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Color() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        /// <param name="R">The red value of the color (required).</param>
        /// <param name="G">The green value of the color (required).</param>
        /// <param name="B">The blue value of the color (required).</param>
        public Color(int? R = default(int?), int? G = default(int?), int? B = default(int?))
        {
            // to ensure "R" is required (not null)
            if (R == null)
            {
                throw new InvalidDataException("R is a required property for Color and cannot be null");
            }
            else
            {
                this.R = R;
            }
            // to ensure "G" is required (not null)
            if (G == null)
            {
                throw new InvalidDataException("G is a required property for Color and cannot be null");
            }
            else
            {
                this.G = G;
            }
            // to ensure "B" is required (not null)
            if (B == null)
            {
                throw new InvalidDataException("B is a required property for Color and cannot be null");
            }
            else
            {
                this.B = B;
            }
        }
        
        /// <summary>
        /// The red value of the color
        /// </summary>
        /// <value>The red value of the color</value>
        [DataMember(Name="r", EmitDefaultValue=false)]
        public int? R { get; set; }

        /// <summary>
        /// The green value of the color
        /// </summary>
        /// <value>The green value of the color</value>
        [DataMember(Name="g", EmitDefaultValue=false)]
        public int? G { get; set; }

        /// <summary>
        /// The blue value of the color
        /// </summary>
        /// <value>The blue value of the color</value>
        [DataMember(Name="b", EmitDefaultValue=false)]
        public int? B { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Color {\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  G: ").Append(G).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
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
            return this.Equals(input as Color);
        }

        /// <summary>
        /// Returns true if Color instances are equal
        /// </summary>
        /// <param name="input">Instance of Color to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Color input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.G == input.G ||
                    (this.G != null &&
                    this.G.Equals(input.G))
                ) && 
                (
                    this.B == input.B ||
                    (this.B != null &&
                    this.B.Equals(input.B))
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
                if (this.R != null)
                    hashCode = hashCode * 59 + this.R.GetHashCode();
                if (this.G != null)
                    hashCode = hashCode * 59 + this.G.GetHashCode();
                if (this.B != null)
                    hashCode = hashCode * 59 + this.B.GetHashCode();
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