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
    /// PotionEffect
    /// </summary>
    [DataContract]
    public partial class PotionEffect :  IEquatable<PotionEffect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PotionEffect" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PotionEffect() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PotionEffect" /> class.
        /// </summary>
        /// <param name="Type">The type of effect this potion represents (required).</param>
        /// <param name="Amplifier">The aplifier of this potion (I, II, III, IV, V, ...) (required).</param>
        /// <param name="Duration">The duration this potion lasts for (required).</param>
        public PotionEffect(CatalogType Type = default(CatalogType), int? Amplifier = default(int?), int? Duration = default(int?))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for PotionEffect and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Amplifier" is required (not null)
            if (Amplifier == null)
            {
                throw new InvalidDataException("Amplifier is a required property for PotionEffect and cannot be null");
            }
            else
            {
                this.Amplifier = Amplifier;
            }
            // to ensure "Duration" is required (not null)
            if (Duration == null)
            {
                throw new InvalidDataException("Duration is a required property for PotionEffect and cannot be null");
            }
            else
            {
                this.Duration = Duration;
            }
        }
        
        /// <summary>
        /// The type of effect this potion represents
        /// </summary>
        /// <value>The type of effect this potion represents</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public CatalogType Type { get; set; }

        /// <summary>
        /// The aplifier of this potion (I, II, III, IV, V, ...)
        /// </summary>
        /// <value>The aplifier of this potion (I, II, III, IV, V, ...)</value>
        [DataMember(Name="amplifier", EmitDefaultValue=false)]
        public int? Amplifier { get; set; }

        /// <summary>
        /// The duration this potion lasts for
        /// </summary>
        /// <value>The duration this potion lasts for</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PotionEffect {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amplifier: ").Append(Amplifier).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as PotionEffect);
        }

        /// <summary>
        /// Returns true if PotionEffect instances are equal
        /// </summary>
        /// <param name="input">Instance of PotionEffect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PotionEffect input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Amplifier == input.Amplifier ||
                    (this.Amplifier != null &&
                    this.Amplifier.Equals(input.Amplifier))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Amplifier != null)
                    hashCode = hashCode * 59 + this.Amplifier.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
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
