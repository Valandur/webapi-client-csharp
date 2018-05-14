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
    /// FallingBlockData
    /// </summary>
    [DataContract]
    public partial class FallingBlockData :  IEquatable<FallingBlockData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FallingBlockData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FallingBlockData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FallingBlockData" /> class.
        /// </summary>
        /// <param name="State">The state of the falling block (required).</param>
        /// <param name="CanDropAsItem">True if the block can drop as an item, false otherwise (required).</param>
        /// <param name="CanHurtEntities">True if the block can hurt entities, false otherwise (required).</param>
        /// <param name="CanPlaceAsBlock">True if this falling block can be placed as a normal block, false otherwise (required).</param>
        /// <param name="FallDamagePerBlock">The amount of damage per block this falling block deals (required).</param>
        /// <param name="FallTime">The amount of time (in ticks) this block has been falling for (required).</param>
        /// <param name="MaxFallDamage">The maximum amount of damage this block can deal (required).</param>
        public FallingBlockData(BlockState State = default(BlockState), bool? CanDropAsItem = default(bool?), bool? CanHurtEntities = default(bool?), bool? CanPlaceAsBlock = default(bool?), double? FallDamagePerBlock = default(double?), int? FallTime = default(int?), double? MaxFallDamage = default(double?))
        {
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for FallingBlockData and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "CanDropAsItem" is required (not null)
            if (CanDropAsItem == null)
            {
                throw new InvalidDataException("CanDropAsItem is a required property for FallingBlockData and cannot be null");
            }
            else
            {
                this.CanDropAsItem = CanDropAsItem;
            }
            // to ensure "CanHurtEntities" is required (not null)
            if (CanHurtEntities == null)
            {
                throw new InvalidDataException("CanHurtEntities is a required property for FallingBlockData and cannot be null");
            }
            else
            {
                this.CanHurtEntities = CanHurtEntities;
            }
            // to ensure "CanPlaceAsBlock" is required (not null)
            if (CanPlaceAsBlock == null)
            {
                throw new InvalidDataException("CanPlaceAsBlock is a required property for FallingBlockData and cannot be null");
            }
            else
            {
                this.CanPlaceAsBlock = CanPlaceAsBlock;
            }
            // to ensure "FallDamagePerBlock" is required (not null)
            if (FallDamagePerBlock == null)
            {
                throw new InvalidDataException("FallDamagePerBlock is a required property for FallingBlockData and cannot be null");
            }
            else
            {
                this.FallDamagePerBlock = FallDamagePerBlock;
            }
            // to ensure "FallTime" is required (not null)
            if (FallTime == null)
            {
                throw new InvalidDataException("FallTime is a required property for FallingBlockData and cannot be null");
            }
            else
            {
                this.FallTime = FallTime;
            }
            // to ensure "MaxFallDamage" is required (not null)
            if (MaxFallDamage == null)
            {
                throw new InvalidDataException("MaxFallDamage is a required property for FallingBlockData and cannot be null");
            }
            else
            {
                this.MaxFallDamage = MaxFallDamage;
            }
        }
        
        /// <summary>
        /// The state of the falling block
        /// </summary>
        /// <value>The state of the falling block</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public BlockState State { get; set; }

        /// <summary>
        /// True if the block can drop as an item, false otherwise
        /// </summary>
        /// <value>True if the block can drop as an item, false otherwise</value>
        [DataMember(Name="canDropAsItem", EmitDefaultValue=false)]
        public bool? CanDropAsItem { get; set; }

        /// <summary>
        /// True if the block can hurt entities, false otherwise
        /// </summary>
        /// <value>True if the block can hurt entities, false otherwise</value>
        [DataMember(Name="canHurtEntities", EmitDefaultValue=false)]
        public bool? CanHurtEntities { get; set; }

        /// <summary>
        /// True if this falling block can be placed as a normal block, false otherwise
        /// </summary>
        /// <value>True if this falling block can be placed as a normal block, false otherwise</value>
        [DataMember(Name="canPlaceAsBlock", EmitDefaultValue=false)]
        public bool? CanPlaceAsBlock { get; set; }

        /// <summary>
        /// The amount of damage per block this falling block deals
        /// </summary>
        /// <value>The amount of damage per block this falling block deals</value>
        [DataMember(Name="fallDamagePerBlock", EmitDefaultValue=false)]
        public double? FallDamagePerBlock { get; set; }

        /// <summary>
        /// The amount of time (in ticks) this block has been falling for
        /// </summary>
        /// <value>The amount of time (in ticks) this block has been falling for</value>
        [DataMember(Name="fallTime", EmitDefaultValue=false)]
        public int? FallTime { get; set; }

        /// <summary>
        /// The maximum amount of damage this block can deal
        /// </summary>
        /// <value>The maximum amount of damage this block can deal</value>
        [DataMember(Name="maxFallDamage", EmitDefaultValue=false)]
        public double? MaxFallDamage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FallingBlockData {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CanDropAsItem: ").Append(CanDropAsItem).Append("\n");
            sb.Append("  CanHurtEntities: ").Append(CanHurtEntities).Append("\n");
            sb.Append("  CanPlaceAsBlock: ").Append(CanPlaceAsBlock).Append("\n");
            sb.Append("  FallDamagePerBlock: ").Append(FallDamagePerBlock).Append("\n");
            sb.Append("  FallTime: ").Append(FallTime).Append("\n");
            sb.Append("  MaxFallDamage: ").Append(MaxFallDamage).Append("\n");
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
            return this.Equals(input as FallingBlockData);
        }

        /// <summary>
        /// Returns true if FallingBlockData instances are equal
        /// </summary>
        /// <param name="input">Instance of FallingBlockData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FallingBlockData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CanDropAsItem == input.CanDropAsItem ||
                    (this.CanDropAsItem != null &&
                    this.CanDropAsItem.Equals(input.CanDropAsItem))
                ) && 
                (
                    this.CanHurtEntities == input.CanHurtEntities ||
                    (this.CanHurtEntities != null &&
                    this.CanHurtEntities.Equals(input.CanHurtEntities))
                ) && 
                (
                    this.CanPlaceAsBlock == input.CanPlaceAsBlock ||
                    (this.CanPlaceAsBlock != null &&
                    this.CanPlaceAsBlock.Equals(input.CanPlaceAsBlock))
                ) && 
                (
                    this.FallDamagePerBlock == input.FallDamagePerBlock ||
                    (this.FallDamagePerBlock != null &&
                    this.FallDamagePerBlock.Equals(input.FallDamagePerBlock))
                ) && 
                (
                    this.FallTime == input.FallTime ||
                    (this.FallTime != null &&
                    this.FallTime.Equals(input.FallTime))
                ) && 
                (
                    this.MaxFallDamage == input.MaxFallDamage ||
                    (this.MaxFallDamage != null &&
                    this.MaxFallDamage.Equals(input.MaxFallDamage))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CanDropAsItem != null)
                    hashCode = hashCode * 59 + this.CanDropAsItem.GetHashCode();
                if (this.CanHurtEntities != null)
                    hashCode = hashCode * 59 + this.CanHurtEntities.GetHashCode();
                if (this.CanPlaceAsBlock != null)
                    hashCode = hashCode * 59 + this.CanPlaceAsBlock.GetHashCode();
                if (this.FallDamagePerBlock != null)
                    hashCode = hashCode * 59 + this.FallDamagePerBlock.GetHashCode();
                if (this.FallTime != null)
                    hashCode = hashCode * 59 + this.FallTime.GetHashCode();
                if (this.MaxFallDamage != null)
                    hashCode = hashCode * 59 + this.MaxFallDamage.GetHashCode();
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