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
    /// WorldBorder
    /// </summary>
    [DataContract]
    public partial class WorldBorder :  IEquatable<WorldBorder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldBorder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorldBorder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldBorder" /> class.
        /// </summary>
        /// <param name="Center">The center of the world border (required).</param>
        /// <param name="DamageAmount">The amount of damage done to players outside the border (required).</param>
        /// <param name="DamageThreshold">The maximum amount of damage done to a player (required).</param>
        /// <param name="Diameter">The diameter of the border (required).</param>
        /// <param name="NewDiameter">The new diameter of the border, in case it is collapsing/expanding (required).</param>
        /// <param name="TimeRemaining">The time remaining until the border reaches it&#39;s new size (required).</param>
        /// <param name="WarningDistance">The amount of distance from the border a player will receive a warning at (required).</param>
        /// <param name="WarningTime">The amount of time near a border before a warning is shown for players (required).</param>
        public WorldBorder(Vector3d Center = default(Vector3d), double? DamageAmount = default(double?), double? DamageThreshold = default(double?), double? Diameter = default(double?), double? NewDiameter = default(double?), long? TimeRemaining = default(long?), int? WarningDistance = default(int?), int? WarningTime = default(int?))
        {
            // to ensure "Center" is required (not null)
            if (Center == null)
            {
                throw new InvalidDataException("Center is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.Center = Center;
            }
            // to ensure "DamageAmount" is required (not null)
            if (DamageAmount == null)
            {
                throw new InvalidDataException("DamageAmount is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.DamageAmount = DamageAmount;
            }
            // to ensure "DamageThreshold" is required (not null)
            if (DamageThreshold == null)
            {
                throw new InvalidDataException("DamageThreshold is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.DamageThreshold = DamageThreshold;
            }
            // to ensure "Diameter" is required (not null)
            if (Diameter == null)
            {
                throw new InvalidDataException("Diameter is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.Diameter = Diameter;
            }
            // to ensure "NewDiameter" is required (not null)
            if (NewDiameter == null)
            {
                throw new InvalidDataException("NewDiameter is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.NewDiameter = NewDiameter;
            }
            // to ensure "TimeRemaining" is required (not null)
            if (TimeRemaining == null)
            {
                throw new InvalidDataException("TimeRemaining is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.TimeRemaining = TimeRemaining;
            }
            // to ensure "WarningDistance" is required (not null)
            if (WarningDistance == null)
            {
                throw new InvalidDataException("WarningDistance is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.WarningDistance = WarningDistance;
            }
            // to ensure "WarningTime" is required (not null)
            if (WarningTime == null)
            {
                throw new InvalidDataException("WarningTime is a required property for WorldBorder and cannot be null");
            }
            else
            {
                this.WarningTime = WarningTime;
            }
        }
        
        /// <summary>
        /// The center of the world border
        /// </summary>
        /// <value>The center of the world border</value>
        [DataMember(Name="center", EmitDefaultValue=false)]
        public Vector3d Center { get; set; }

        /// <summary>
        /// The amount of damage done to players outside the border
        /// </summary>
        /// <value>The amount of damage done to players outside the border</value>
        [DataMember(Name="damageAmount", EmitDefaultValue=false)]
        public double? DamageAmount { get; set; }

        /// <summary>
        /// The maximum amount of damage done to a player
        /// </summary>
        /// <value>The maximum amount of damage done to a player</value>
        [DataMember(Name="damageThreshold", EmitDefaultValue=false)]
        public double? DamageThreshold { get; set; }

        /// <summary>
        /// The diameter of the border
        /// </summary>
        /// <value>The diameter of the border</value>
        [DataMember(Name="diameter", EmitDefaultValue=false)]
        public double? Diameter { get; set; }

        /// <summary>
        /// The new diameter of the border, in case it is collapsing/expanding
        /// </summary>
        /// <value>The new diameter of the border, in case it is collapsing/expanding</value>
        [DataMember(Name="newDiameter", EmitDefaultValue=false)]
        public double? NewDiameter { get; set; }

        /// <summary>
        /// The time remaining until the border reaches it&#39;s new size
        /// </summary>
        /// <value>The time remaining until the border reaches it&#39;s new size</value>
        [DataMember(Name="timeRemaining", EmitDefaultValue=false)]
        public long? TimeRemaining { get; set; }

        /// <summary>
        /// The amount of distance from the border a player will receive a warning at
        /// </summary>
        /// <value>The amount of distance from the border a player will receive a warning at</value>
        [DataMember(Name="warningDistance", EmitDefaultValue=false)]
        public int? WarningDistance { get; set; }

        /// <summary>
        /// The amount of time near a border before a warning is shown for players
        /// </summary>
        /// <value>The amount of time near a border before a warning is shown for players</value>
        [DataMember(Name="warningTime", EmitDefaultValue=false)]
        public int? WarningTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorldBorder {\n");
            sb.Append("  Center: ").Append(Center).Append("\n");
            sb.Append("  DamageAmount: ").Append(DamageAmount).Append("\n");
            sb.Append("  DamageThreshold: ").Append(DamageThreshold).Append("\n");
            sb.Append("  Diameter: ").Append(Diameter).Append("\n");
            sb.Append("  NewDiameter: ").Append(NewDiameter).Append("\n");
            sb.Append("  TimeRemaining: ").Append(TimeRemaining).Append("\n");
            sb.Append("  WarningDistance: ").Append(WarningDistance).Append("\n");
            sb.Append("  WarningTime: ").Append(WarningTime).Append("\n");
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
            return this.Equals(input as WorldBorder);
        }

        /// <summary>
        /// Returns true if WorldBorder instances are equal
        /// </summary>
        /// <param name="input">Instance of WorldBorder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorldBorder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Center == input.Center ||
                    (this.Center != null &&
                    this.Center.Equals(input.Center))
                ) && 
                (
                    this.DamageAmount == input.DamageAmount ||
                    (this.DamageAmount != null &&
                    this.DamageAmount.Equals(input.DamageAmount))
                ) && 
                (
                    this.DamageThreshold == input.DamageThreshold ||
                    (this.DamageThreshold != null &&
                    this.DamageThreshold.Equals(input.DamageThreshold))
                ) && 
                (
                    this.Diameter == input.Diameter ||
                    (this.Diameter != null &&
                    this.Diameter.Equals(input.Diameter))
                ) && 
                (
                    this.NewDiameter == input.NewDiameter ||
                    (this.NewDiameter != null &&
                    this.NewDiameter.Equals(input.NewDiameter))
                ) && 
                (
                    this.TimeRemaining == input.TimeRemaining ||
                    (this.TimeRemaining != null &&
                    this.TimeRemaining.Equals(input.TimeRemaining))
                ) && 
                (
                    this.WarningDistance == input.WarningDistance ||
                    (this.WarningDistance != null &&
                    this.WarningDistance.Equals(input.WarningDistance))
                ) && 
                (
                    this.WarningTime == input.WarningTime ||
                    (this.WarningTime != null &&
                    this.WarningTime.Equals(input.WarningTime))
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
                if (this.Center != null)
                    hashCode = hashCode * 59 + this.Center.GetHashCode();
                if (this.DamageAmount != null)
                    hashCode = hashCode * 59 + this.DamageAmount.GetHashCode();
                if (this.DamageThreshold != null)
                    hashCode = hashCode * 59 + this.DamageThreshold.GetHashCode();
                if (this.Diameter != null)
                    hashCode = hashCode * 59 + this.Diameter.GetHashCode();
                if (this.NewDiameter != null)
                    hashCode = hashCode * 59 + this.NewDiameter.GetHashCode();
                if (this.TimeRemaining != null)
                    hashCode = hashCode * 59 + this.TimeRemaining.GetHashCode();
                if (this.WarningDistance != null)
                    hashCode = hashCode * 59 + this.WarningDistance.GetHashCode();
                if (this.WarningTime != null)
                    hashCode = hashCode * 59 + this.WarningTime.GetHashCode();
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
