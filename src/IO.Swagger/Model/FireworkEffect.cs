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
    /// FireworkEffect
    /// </summary>
    [DataContract]
    public partial class FireworkEffect :  IEquatable<FireworkEffect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireworkEffect" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FireworkEffect() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FireworkEffect" /> class.
        /// </summary>
        /// <param name="Shape">The shape of the firework (required).</param>
        /// <param name="Flickers">True if the firework flickers, false otherwise (required).</param>
        /// <param name="Colors">The colors that make up this firework (required).</param>
        /// <param name="FadeColors">The fade colors that this firework has (required).</param>
        /// <param name="Trail">True if this firework has a trail, false otherwise (required).</param>
        public FireworkEffect(CatalogType Shape = default(CatalogType), bool? Flickers = default(bool?), List<Color> Colors = default(List<Color>), List<Color> FadeColors = default(List<Color>), bool? Trail = default(bool?))
        {
            // to ensure "Shape" is required (not null)
            if (Shape == null)
            {
                throw new InvalidDataException("Shape is a required property for FireworkEffect and cannot be null");
            }
            else
            {
                this.Shape = Shape;
            }
            // to ensure "Flickers" is required (not null)
            if (Flickers == null)
            {
                throw new InvalidDataException("Flickers is a required property for FireworkEffect and cannot be null");
            }
            else
            {
                this.Flickers = Flickers;
            }
            // to ensure "Colors" is required (not null)
            if (Colors == null)
            {
                throw new InvalidDataException("Colors is a required property for FireworkEffect and cannot be null");
            }
            else
            {
                this.Colors = Colors;
            }
            // to ensure "FadeColors" is required (not null)
            if (FadeColors == null)
            {
                throw new InvalidDataException("FadeColors is a required property for FireworkEffect and cannot be null");
            }
            else
            {
                this.FadeColors = FadeColors;
            }
            // to ensure "Trail" is required (not null)
            if (Trail == null)
            {
                throw new InvalidDataException("Trail is a required property for FireworkEffect and cannot be null");
            }
            else
            {
                this.Trail = Trail;
            }
        }
        
        /// <summary>
        /// The shape of the firework
        /// </summary>
        /// <value>The shape of the firework</value>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public CatalogType Shape { get; set; }

        /// <summary>
        /// True if the firework flickers, false otherwise
        /// </summary>
        /// <value>True if the firework flickers, false otherwise</value>
        [DataMember(Name="flickers", EmitDefaultValue=false)]
        public bool? Flickers { get; set; }

        /// <summary>
        /// The colors that make up this firework
        /// </summary>
        /// <value>The colors that make up this firework</value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<Color> Colors { get; set; }

        /// <summary>
        /// The fade colors that this firework has
        /// </summary>
        /// <value>The fade colors that this firework has</value>
        [DataMember(Name="fadeColors", EmitDefaultValue=false)]
        public List<Color> FadeColors { get; set; }

        /// <summary>
        /// True if this firework has a trail, false otherwise
        /// </summary>
        /// <value>True if this firework has a trail, false otherwise</value>
        [DataMember(Name="trail", EmitDefaultValue=false)]
        public bool? Trail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireworkEffect {\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Flickers: ").Append(Flickers).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  FadeColors: ").Append(FadeColors).Append("\n");
            sb.Append("  Trail: ").Append(Trail).Append("\n");
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
            return this.Equals(input as FireworkEffect);
        }

        /// <summary>
        /// Returns true if FireworkEffect instances are equal
        /// </summary>
        /// <param name="input">Instance of FireworkEffect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireworkEffect input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
                ) && 
                (
                    this.Flickers == input.Flickers ||
                    (this.Flickers != null &&
                    this.Flickers.Equals(input.Flickers))
                ) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
                ) && 
                (
                    this.FadeColors == input.FadeColors ||
                    this.FadeColors != null &&
                    this.FadeColors.SequenceEqual(input.FadeColors)
                ) && 
                (
                    this.Trail == input.Trail ||
                    (this.Trail != null &&
                    this.Trail.Equals(input.Trail))
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
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Flickers != null)
                    hashCode = hashCode * 59 + this.Flickers.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                if (this.FadeColors != null)
                    hashCode = hashCode * 59 + this.FadeColors.GetHashCode();
                if (this.Trail != null)
                    hashCode = hashCode * 59 + this.Trail.GetHashCode();
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
