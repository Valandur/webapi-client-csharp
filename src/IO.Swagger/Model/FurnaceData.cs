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
    /// FurnaceData
    /// </summary>
    [DataContract]
    public partial class FurnaceData :  IEquatable<FurnaceData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FurnaceData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FurnaceData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FurnaceData" /> class.
        /// </summary>
        /// <param name="maxBurnTime">The maximum amount of time (in ticks) the current fuel item lasts (required).</param>
        /// <param name="maxCookTime">The total amount of time (in ticks) the stack has to cook for to be done (required).</param>
        /// <param name="passedBurnTime">The amount of time (in ticks) that has passed since this fuel item started burning (required).</param>
        /// <param name="passedCookTime">The amount of time (in ticks) that has passed since the item stack started cooking (required).</param>
        public FurnaceData(int? maxBurnTime = default(int?), int? maxCookTime = default(int?), int? passedBurnTime = default(int?), int? passedCookTime = default(int?))
        {
            // to ensure "maxBurnTime" is required (not null)
            if (maxBurnTime == null)
            {
                throw new InvalidDataException("maxBurnTime is a required property for FurnaceData and cannot be null");
            }
            else
            {
                this.MaxBurnTime = maxBurnTime;
            }
            // to ensure "maxCookTime" is required (not null)
            if (maxCookTime == null)
            {
                throw new InvalidDataException("maxCookTime is a required property for FurnaceData and cannot be null");
            }
            else
            {
                this.MaxCookTime = maxCookTime;
            }
            // to ensure "passedBurnTime" is required (not null)
            if (passedBurnTime == null)
            {
                throw new InvalidDataException("passedBurnTime is a required property for FurnaceData and cannot be null");
            }
            else
            {
                this.PassedBurnTime = passedBurnTime;
            }
            // to ensure "passedCookTime" is required (not null)
            if (passedCookTime == null)
            {
                throw new InvalidDataException("passedCookTime is a required property for FurnaceData and cannot be null");
            }
            else
            {
                this.PassedCookTime = passedCookTime;
            }
        }
        
        /// <summary>
        /// The maximum amount of time (in ticks) the current fuel item lasts
        /// </summary>
        /// <value>The maximum amount of time (in ticks) the current fuel item lasts</value>
        [DataMember(Name="maxBurnTime", EmitDefaultValue=false)]
        public int? MaxBurnTime { get; set; }

        /// <summary>
        /// The total amount of time (in ticks) the stack has to cook for to be done
        /// </summary>
        /// <value>The total amount of time (in ticks) the stack has to cook for to be done</value>
        [DataMember(Name="maxCookTime", EmitDefaultValue=false)]
        public int? MaxCookTime { get; set; }

        /// <summary>
        /// The amount of time (in ticks) that has passed since this fuel item started burning
        /// </summary>
        /// <value>The amount of time (in ticks) that has passed since this fuel item started burning</value>
        [DataMember(Name="passedBurnTime", EmitDefaultValue=false)]
        public int? PassedBurnTime { get; set; }

        /// <summary>
        /// The amount of time (in ticks) that has passed since the item stack started cooking
        /// </summary>
        /// <value>The amount of time (in ticks) that has passed since the item stack started cooking</value>
        [DataMember(Name="passedCookTime", EmitDefaultValue=false)]
        public int? PassedCookTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FurnaceData {\n");
            sb.Append("  MaxBurnTime: ").Append(MaxBurnTime).Append("\n");
            sb.Append("  MaxCookTime: ").Append(MaxCookTime).Append("\n");
            sb.Append("  PassedBurnTime: ").Append(PassedBurnTime).Append("\n");
            sb.Append("  PassedCookTime: ").Append(PassedCookTime).Append("\n");
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
            return this.Equals(input as FurnaceData);
        }

        /// <summary>
        /// Returns true if FurnaceData instances are equal
        /// </summary>
        /// <param name="input">Instance of FurnaceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FurnaceData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxBurnTime == input.MaxBurnTime ||
                    (this.MaxBurnTime != null &&
                    this.MaxBurnTime.Equals(input.MaxBurnTime))
                ) && 
                (
                    this.MaxCookTime == input.MaxCookTime ||
                    (this.MaxCookTime != null &&
                    this.MaxCookTime.Equals(input.MaxCookTime))
                ) && 
                (
                    this.PassedBurnTime == input.PassedBurnTime ||
                    (this.PassedBurnTime != null &&
                    this.PassedBurnTime.Equals(input.PassedBurnTime))
                ) && 
                (
                    this.PassedCookTime == input.PassedCookTime ||
                    (this.PassedCookTime != null &&
                    this.PassedCookTime.Equals(input.PassedCookTime))
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
                if (this.MaxBurnTime != null)
                    hashCode = hashCode * 59 + this.MaxBurnTime.GetHashCode();
                if (this.MaxCookTime != null)
                    hashCode = hashCode * 59 + this.MaxCookTime.GetHashCode();
                if (this.PassedBurnTime != null)
                    hashCode = hashCode * 59 + this.PassedBurnTime.GetHashCode();
                if (this.PassedCookTime != null)
                    hashCode = hashCode * 59 + this.PassedCookTime.GetHashCode();
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
