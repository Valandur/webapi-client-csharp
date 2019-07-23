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
    /// GuiIdProperty
    /// </summary>
    [DataContract]
    public partial class GuiIdProperty :  IEquatable<GuiIdProperty>, IValidatableObject
    {
        /// <summary>
        /// Defines _Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            
            /// <summary>
            /// Enum DELEGATE for value: DELEGATE
            /// </summary>
            [EnumMember(Value = "DELEGATE")]
            DELEGATE = 1,
            
            /// <summary>
            /// Enum EQUAL for value: EQUAL
            /// </summary>
            [EnumMember(Value = "EQUAL")]
            EQUAL = 2,
            
            /// <summary>
            /// Enum NOTEQUAL for value: NOTEQUAL
            /// </summary>
            [EnumMember(Value = "NOTEQUAL")]
            NOTEQUAL = 3,
            
            /// <summary>
            /// Enum GREATER for value: GREATER
            /// </summary>
            [EnumMember(Value = "GREATER")]
            GREATER = 4,
            
            /// <summary>
            /// Enum GEQUAL for value: GEQUAL
            /// </summary>
            [EnumMember(Value = "GEQUAL")]
            GEQUAL = 5,
            
            /// <summary>
            /// Enum LESS for value: LESS
            /// </summary>
            [EnumMember(Value = "LESS")]
            LESS = 6,
            
            /// <summary>
            /// Enum LEQUAL for value: LEQUAL
            /// </summary>
            [EnumMember(Value = "LEQUAL")]
            LEQUAL = 7
        }

        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuiIdProperty" /> class.
        /// </summary>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        public GuiIdProperty(OperatorEnum? _Operator = default(OperatorEnum?), string Key = default(string), CatalogType Value = default(CatalogType))
        {
            this._Operator = _Operator;
            this.Key = Key;
            this.Value = Value;
        }
        

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public CatalogType Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuiIdProperty {\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as GuiIdProperty);
        }

        /// <summary>
        /// Returns true if GuiIdProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of GuiIdProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuiIdProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
