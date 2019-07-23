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
    /// PluginDependency
    /// </summary>
    [DataContract]
    public partial class PluginDependency :  IEquatable<PluginDependency>, IValidatableObject
    {
        /// <summary>
        /// The load order of the original plugin in relation to the dependency
        /// </summary>
        /// <value>The load order of the original plugin in relation to the dependency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LoadOrderEnum
        {
            
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,
            
            /// <summary>
            /// Enum BEFORE for value: BEFORE
            /// </summary>
            [EnumMember(Value = "BEFORE")]
            BEFORE = 2,
            
            /// <summary>
            /// Enum AFTER for value: AFTER
            /// </summary>
            [EnumMember(Value = "AFTER")]
            AFTER = 3
        }

        /// <summary>
        /// The load order of the original plugin in relation to the dependency
        /// </summary>
        /// <value>The load order of the original plugin in relation to the dependency</value>
        [DataMember(Name="loadOrder", EmitDefaultValue=false)]
        public LoadOrderEnum LoadOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PluginDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginDependency" /> class.
        /// </summary>
        /// <param name="Id">The id of the plugin that the original plugin depends on (required).</param>
        /// <param name="LoadOrder">The load order of the original plugin in relation to the dependency (required).</param>
        /// <param name="Optional">True if this is an optional dependency, false otherwise (required).</param>
        /// <param name="Version">The version of the plugin that the original plugin depends on (required).</param>
        public PluginDependency(string Id = default(string), LoadOrderEnum LoadOrder = default(LoadOrderEnum), bool? Optional = default(bool?), string Version = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for PluginDependency and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "LoadOrder" is required (not null)
            if (LoadOrder == null)
            {
                throw new InvalidDataException("LoadOrder is a required property for PluginDependency and cannot be null");
            }
            else
            {
                this.LoadOrder = LoadOrder;
            }
            // to ensure "Optional" is required (not null)
            if (Optional == null)
            {
                throw new InvalidDataException("Optional is a required property for PluginDependency and cannot be null");
            }
            else
            {
                this.Optional = Optional;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for PluginDependency and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
        }
        
        /// <summary>
        /// The id of the plugin that the original plugin depends on
        /// </summary>
        /// <value>The id of the plugin that the original plugin depends on</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// True if this is an optional dependency, false otherwise
        /// </summary>
        /// <value>True if this is an optional dependency, false otherwise</value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public bool? Optional { get; set; }

        /// <summary>
        /// The version of the plugin that the original plugin depends on
        /// </summary>
        /// <value>The version of the plugin that the original plugin depends on</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginDependency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoadOrder: ").Append(LoadOrder).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PluginDependency);
        }

        /// <summary>
        /// Returns true if PluginDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginDependency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LoadOrder == input.LoadOrder ||
                    (this.LoadOrder != null &&
                    this.LoadOrder.Equals(input.LoadOrder))
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LoadOrder != null)
                    hashCode = hashCode * 59 + this.LoadOrder.GetHashCode();
                if (this.Optional != null)
                    hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
