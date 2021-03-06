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
    /// Chunk
    /// </summary>
    [DataContract]
    public partial class Chunk :  IEquatable<Chunk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Chunk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        /// <param name="loaded">True if this chunk is currently loaded, false otherwise (required).</param>
        /// <param name="position">The position of this chunk (in chunk coordinates) (required).</param>
        /// <param name="uuid">The unique id of this chunk (required).</param>
        /// <param name="blockMax">The bock with the largest coordinates that is still part of this chunk.</param>
        /// <param name="blockMin">The bock with the smallest coordinates that is still part of this chunk.</param>
        /// <param name="inhabitedTime">The total amount of time (in server ticks) this chunk has been inhabited by players..</param>
        /// <param name="regionalDifficultyFactor">The increase in difficulty due to the presence of players in the chunk.</param>
        /// <param name="regionalDifficultyPercentage">The increase in difficulty due to the presence of players in the chunk as a percentage.</param>
        /// <param name="world">The world the chunk is in.</param>
        public Chunk(bool? loaded = default(bool?), Vector3i position = default(Vector3i), Guid? uuid = default(Guid?), Vector3i blockMax = default(Vector3i), Vector3i blockMin = default(Vector3i), int? inhabitedTime = default(int?), double? regionalDifficultyFactor = default(double?), double? regionalDifficultyPercentage = default(double?), World world = default(World))
        {
            // to ensure "loaded" is required (not null)
            if (loaded == null)
            {
                throw new InvalidDataException("loaded is a required property for Chunk and cannot be null");
            }
            else
            {
                this.Loaded = loaded;
            }
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new InvalidDataException("position is a required property for Chunk and cannot be null");
            }
            else
            {
                this.Position = position;
            }
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new InvalidDataException("uuid is a required property for Chunk and cannot be null");
            }
            else
            {
                this.Uuid = uuid;
            }
            this.BlockMax = blockMax;
            this.BlockMin = blockMin;
            this.InhabitedTime = inhabitedTime;
            this.RegionalDifficultyFactor = regionalDifficultyFactor;
            this.RegionalDifficultyPercentage = regionalDifficultyPercentage;
            this.World = world;
        }
        
        /// <summary>
        /// The API link that can be used to obtain more information about this object
        /// </summary>
        /// <value>The API link that can be used to obtain more information about this object</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; private set; }

        /// <summary>
        /// True if this chunk is currently loaded, false otherwise
        /// </summary>
        /// <value>True if this chunk is currently loaded, false otherwise</value>
        [DataMember(Name="loaded", EmitDefaultValue=false)]
        public bool? Loaded { get; set; }

        /// <summary>
        /// The position of this chunk (in chunk coordinates)
        /// </summary>
        /// <value>The position of this chunk (in chunk coordinates)</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public Vector3i Position { get; set; }

        /// <summary>
        /// The unique id of this chunk
        /// </summary>
        /// <value>The unique id of this chunk</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// The bock with the largest coordinates that is still part of this chunk
        /// </summary>
        /// <value>The bock with the largest coordinates that is still part of this chunk</value>
        [DataMember(Name="blockMax", EmitDefaultValue=false)]
        public Vector3i BlockMax { get; set; }

        /// <summary>
        /// The bock with the smallest coordinates that is still part of this chunk
        /// </summary>
        /// <value>The bock with the smallest coordinates that is still part of this chunk</value>
        [DataMember(Name="blockMin", EmitDefaultValue=false)]
        public Vector3i BlockMin { get; set; }

        /// <summary>
        /// The total amount of time (in server ticks) this chunk has been inhabited by players.
        /// </summary>
        /// <value>The total amount of time (in server ticks) this chunk has been inhabited by players.</value>
        [DataMember(Name="inhabitedTime", EmitDefaultValue=false)]
        public int? InhabitedTime { get; set; }

        /// <summary>
        /// The increase in difficulty due to the presence of players in the chunk
        /// </summary>
        /// <value>The increase in difficulty due to the presence of players in the chunk</value>
        [DataMember(Name="regionalDifficultyFactor", EmitDefaultValue=false)]
        public double? RegionalDifficultyFactor { get; set; }

        /// <summary>
        /// The increase in difficulty due to the presence of players in the chunk as a percentage
        /// </summary>
        /// <value>The increase in difficulty due to the presence of players in the chunk as a percentage</value>
        [DataMember(Name="regionalDifficultyPercentage", EmitDefaultValue=false)]
        public double? RegionalDifficultyPercentage { get; set; }

        /// <summary>
        /// The world the chunk is in
        /// </summary>
        /// <value>The world the chunk is in</value>
        [DataMember(Name="world", EmitDefaultValue=false)]
        public World World { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Chunk {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Loaded: ").Append(Loaded).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  BlockMax: ").Append(BlockMax).Append("\n");
            sb.Append("  BlockMin: ").Append(BlockMin).Append("\n");
            sb.Append("  InhabitedTime: ").Append(InhabitedTime).Append("\n");
            sb.Append("  RegionalDifficultyFactor: ").Append(RegionalDifficultyFactor).Append("\n");
            sb.Append("  RegionalDifficultyPercentage: ").Append(RegionalDifficultyPercentage).Append("\n");
            sb.Append("  World: ").Append(World).Append("\n");
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
            return this.Equals(input as Chunk);
        }

        /// <summary>
        /// Returns true if Chunk instances are equal
        /// </summary>
        /// <param name="input">Instance of Chunk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Chunk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Loaded == input.Loaded ||
                    (this.Loaded != null &&
                    this.Loaded.Equals(input.Loaded))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.BlockMax == input.BlockMax ||
                    (this.BlockMax != null &&
                    this.BlockMax.Equals(input.BlockMax))
                ) && 
                (
                    this.BlockMin == input.BlockMin ||
                    (this.BlockMin != null &&
                    this.BlockMin.Equals(input.BlockMin))
                ) && 
                (
                    this.InhabitedTime == input.InhabitedTime ||
                    (this.InhabitedTime != null &&
                    this.InhabitedTime.Equals(input.InhabitedTime))
                ) && 
                (
                    this.RegionalDifficultyFactor == input.RegionalDifficultyFactor ||
                    (this.RegionalDifficultyFactor != null &&
                    this.RegionalDifficultyFactor.Equals(input.RegionalDifficultyFactor))
                ) && 
                (
                    this.RegionalDifficultyPercentage == input.RegionalDifficultyPercentage ||
                    (this.RegionalDifficultyPercentage != null &&
                    this.RegionalDifficultyPercentage.Equals(input.RegionalDifficultyPercentage))
                ) && 
                (
                    this.World == input.World ||
                    (this.World != null &&
                    this.World.Equals(input.World))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Loaded != null)
                    hashCode = hashCode * 59 + this.Loaded.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.BlockMax != null)
                    hashCode = hashCode * 59 + this.BlockMax.GetHashCode();
                if (this.BlockMin != null)
                    hashCode = hashCode * 59 + this.BlockMin.GetHashCode();
                if (this.InhabitedTime != null)
                    hashCode = hashCode * 59 + this.InhabitedTime.GetHashCode();
                if (this.RegionalDifficultyFactor != null)
                    hashCode = hashCode * 59 + this.RegionalDifficultyFactor.GetHashCode();
                if (this.RegionalDifficultyPercentage != null)
                    hashCode = hashCode * 59 + this.RegionalDifficultyPercentage.GetHashCode();
                if (this.World != null)
                    hashCode = hashCode * 59 + this.World.GetHashCode();
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
