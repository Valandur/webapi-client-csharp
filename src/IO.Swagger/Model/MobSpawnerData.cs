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
    /// MobSpawnerData
    /// </summary>
    [DataContract]
    public partial class MobSpawnerData :  IEquatable<MobSpawnerData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobSpawnerData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MobSpawnerData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobSpawnerData" /> class.
        /// </summary>
        /// <param name="MaximumNearbyEntities">The maximum number of nearby entities for another mob to spawn (required).</param>
        /// <param name="MaximumSpawnDelay">The maximum delay between two consecutive spawns (required).</param>
        /// <param name="MinimumSpawnDelay">The minimum delay between two consecutive spawns (required).</param>
        /// <param name="NextEntityToSpawn">The next entity type that will be spawned by this spawner (required).</param>
        /// <param name="PossibleEntitiesToSpawn">A weighted table of probability for each entity type to spawn (required).</param>
        /// <param name="RemainingDelay">The remaining time until the next spawn attempt (required).</param>
        /// <param name="RequiredPlayerRange">The block range within there must be a player to trigger the spawn (required).</param>
        /// <param name="SpawnCount">The amount of entities that will spawn in one attempt (required).</param>
        /// <param name="SpawnRange">The range from the spawner within which the entities will spawn (required).</param>
        public MobSpawnerData(int? MaximumNearbyEntities = default(int?), int? MaximumSpawnDelay = default(int?), int? MinimumSpawnDelay = default(int?), EntityArchtype NextEntityToSpawn = default(EntityArchtype), List<TableEntryEntityArchetype> PossibleEntitiesToSpawn = default(List<TableEntryEntityArchetype>), int? RemainingDelay = default(int?), int? RequiredPlayerRange = default(int?), int? SpawnCount = default(int?), int? SpawnRange = default(int?))
        {
            // to ensure "MaximumNearbyEntities" is required (not null)
            if (MaximumNearbyEntities == null)
            {
                throw new InvalidDataException("MaximumNearbyEntities is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.MaximumNearbyEntities = MaximumNearbyEntities;
            }
            // to ensure "MaximumSpawnDelay" is required (not null)
            if (MaximumSpawnDelay == null)
            {
                throw new InvalidDataException("MaximumSpawnDelay is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.MaximumSpawnDelay = MaximumSpawnDelay;
            }
            // to ensure "MinimumSpawnDelay" is required (not null)
            if (MinimumSpawnDelay == null)
            {
                throw new InvalidDataException("MinimumSpawnDelay is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.MinimumSpawnDelay = MinimumSpawnDelay;
            }
            // to ensure "NextEntityToSpawn" is required (not null)
            if (NextEntityToSpawn == null)
            {
                throw new InvalidDataException("NextEntityToSpawn is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.NextEntityToSpawn = NextEntityToSpawn;
            }
            // to ensure "PossibleEntitiesToSpawn" is required (not null)
            if (PossibleEntitiesToSpawn == null)
            {
                throw new InvalidDataException("PossibleEntitiesToSpawn is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.PossibleEntitiesToSpawn = PossibleEntitiesToSpawn;
            }
            // to ensure "RemainingDelay" is required (not null)
            if (RemainingDelay == null)
            {
                throw new InvalidDataException("RemainingDelay is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.RemainingDelay = RemainingDelay;
            }
            // to ensure "RequiredPlayerRange" is required (not null)
            if (RequiredPlayerRange == null)
            {
                throw new InvalidDataException("RequiredPlayerRange is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.RequiredPlayerRange = RequiredPlayerRange;
            }
            // to ensure "SpawnCount" is required (not null)
            if (SpawnCount == null)
            {
                throw new InvalidDataException("SpawnCount is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.SpawnCount = SpawnCount;
            }
            // to ensure "SpawnRange" is required (not null)
            if (SpawnRange == null)
            {
                throw new InvalidDataException("SpawnRange is a required property for MobSpawnerData and cannot be null");
            }
            else
            {
                this.SpawnRange = SpawnRange;
            }
        }
        
        /// <summary>
        /// The maximum number of nearby entities for another mob to spawn
        /// </summary>
        /// <value>The maximum number of nearby entities for another mob to spawn</value>
        [DataMember(Name="maximumNearbyEntities", EmitDefaultValue=false)]
        public int? MaximumNearbyEntities { get; set; }

        /// <summary>
        /// The maximum delay between two consecutive spawns
        /// </summary>
        /// <value>The maximum delay between two consecutive spawns</value>
        [DataMember(Name="maximumSpawnDelay", EmitDefaultValue=false)]
        public int? MaximumSpawnDelay { get; set; }

        /// <summary>
        /// The minimum delay between two consecutive spawns
        /// </summary>
        /// <value>The minimum delay between two consecutive spawns</value>
        [DataMember(Name="minimumSpawnDelay", EmitDefaultValue=false)]
        public int? MinimumSpawnDelay { get; set; }

        /// <summary>
        /// The next entity type that will be spawned by this spawner
        /// </summary>
        /// <value>The next entity type that will be spawned by this spawner</value>
        [DataMember(Name="nextEntityToSpawn", EmitDefaultValue=false)]
        public EntityArchtype NextEntityToSpawn { get; set; }

        /// <summary>
        /// A weighted table of probability for each entity type to spawn
        /// </summary>
        /// <value>A weighted table of probability for each entity type to spawn</value>
        [DataMember(Name="possibleEntitiesToSpawn", EmitDefaultValue=false)]
        public List<TableEntryEntityArchetype> PossibleEntitiesToSpawn { get; set; }

        /// <summary>
        /// The remaining time until the next spawn attempt
        /// </summary>
        /// <value>The remaining time until the next spawn attempt</value>
        [DataMember(Name="remainingDelay", EmitDefaultValue=false)]
        public int? RemainingDelay { get; set; }

        /// <summary>
        /// The block range within there must be a player to trigger the spawn
        /// </summary>
        /// <value>The block range within there must be a player to trigger the spawn</value>
        [DataMember(Name="requiredPlayerRange", EmitDefaultValue=false)]
        public int? RequiredPlayerRange { get; set; }

        /// <summary>
        /// The amount of entities that will spawn in one attempt
        /// </summary>
        /// <value>The amount of entities that will spawn in one attempt</value>
        [DataMember(Name="spawnCount", EmitDefaultValue=false)]
        public int? SpawnCount { get; set; }

        /// <summary>
        /// The range from the spawner within which the entities will spawn
        /// </summary>
        /// <value>The range from the spawner within which the entities will spawn</value>
        [DataMember(Name="spawnRange", EmitDefaultValue=false)]
        public int? SpawnRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobSpawnerData {\n");
            sb.Append("  MaximumNearbyEntities: ").Append(MaximumNearbyEntities).Append("\n");
            sb.Append("  MaximumSpawnDelay: ").Append(MaximumSpawnDelay).Append("\n");
            sb.Append("  MinimumSpawnDelay: ").Append(MinimumSpawnDelay).Append("\n");
            sb.Append("  NextEntityToSpawn: ").Append(NextEntityToSpawn).Append("\n");
            sb.Append("  PossibleEntitiesToSpawn: ").Append(PossibleEntitiesToSpawn).Append("\n");
            sb.Append("  RemainingDelay: ").Append(RemainingDelay).Append("\n");
            sb.Append("  RequiredPlayerRange: ").Append(RequiredPlayerRange).Append("\n");
            sb.Append("  SpawnCount: ").Append(SpawnCount).Append("\n");
            sb.Append("  SpawnRange: ").Append(SpawnRange).Append("\n");
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
            return this.Equals(input as MobSpawnerData);
        }

        /// <summary>
        /// Returns true if MobSpawnerData instances are equal
        /// </summary>
        /// <param name="input">Instance of MobSpawnerData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobSpawnerData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaximumNearbyEntities == input.MaximumNearbyEntities ||
                    (this.MaximumNearbyEntities != null &&
                    this.MaximumNearbyEntities.Equals(input.MaximumNearbyEntities))
                ) && 
                (
                    this.MaximumSpawnDelay == input.MaximumSpawnDelay ||
                    (this.MaximumSpawnDelay != null &&
                    this.MaximumSpawnDelay.Equals(input.MaximumSpawnDelay))
                ) && 
                (
                    this.MinimumSpawnDelay == input.MinimumSpawnDelay ||
                    (this.MinimumSpawnDelay != null &&
                    this.MinimumSpawnDelay.Equals(input.MinimumSpawnDelay))
                ) && 
                (
                    this.NextEntityToSpawn == input.NextEntityToSpawn ||
                    (this.NextEntityToSpawn != null &&
                    this.NextEntityToSpawn.Equals(input.NextEntityToSpawn))
                ) && 
                (
                    this.PossibleEntitiesToSpawn == input.PossibleEntitiesToSpawn ||
                    this.PossibleEntitiesToSpawn != null &&
                    this.PossibleEntitiesToSpawn.SequenceEqual(input.PossibleEntitiesToSpawn)
                ) && 
                (
                    this.RemainingDelay == input.RemainingDelay ||
                    (this.RemainingDelay != null &&
                    this.RemainingDelay.Equals(input.RemainingDelay))
                ) && 
                (
                    this.RequiredPlayerRange == input.RequiredPlayerRange ||
                    (this.RequiredPlayerRange != null &&
                    this.RequiredPlayerRange.Equals(input.RequiredPlayerRange))
                ) && 
                (
                    this.SpawnCount == input.SpawnCount ||
                    (this.SpawnCount != null &&
                    this.SpawnCount.Equals(input.SpawnCount))
                ) && 
                (
                    this.SpawnRange == input.SpawnRange ||
                    (this.SpawnRange != null &&
                    this.SpawnRange.Equals(input.SpawnRange))
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
                if (this.MaximumNearbyEntities != null)
                    hashCode = hashCode * 59 + this.MaximumNearbyEntities.GetHashCode();
                if (this.MaximumSpawnDelay != null)
                    hashCode = hashCode * 59 + this.MaximumSpawnDelay.GetHashCode();
                if (this.MinimumSpawnDelay != null)
                    hashCode = hashCode * 59 + this.MinimumSpawnDelay.GetHashCode();
                if (this.NextEntityToSpawn != null)
                    hashCode = hashCode * 59 + this.NextEntityToSpawn.GetHashCode();
                if (this.PossibleEntitiesToSpawn != null)
                    hashCode = hashCode * 59 + this.PossibleEntitiesToSpawn.GetHashCode();
                if (this.RemainingDelay != null)
                    hashCode = hashCode * 59 + this.RemainingDelay.GetHashCode();
                if (this.RequiredPlayerRange != null)
                    hashCode = hashCode * 59 + this.RequiredPlayerRange.GetHashCode();
                if (this.SpawnCount != null)
                    hashCode = hashCode * 59 + this.SpawnCount.GetHashCode();
                if (this.SpawnRange != null)
                    hashCode = hashCode * 59 + this.SpawnRange.GetHashCode();
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