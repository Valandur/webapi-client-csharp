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
    /// UpdateWorldRequest
    /// </summary>
    [DataContract]
    public partial class UpdateWorldRequest :  IEquatable<UpdateWorldRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorldRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateWorldRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorldRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the world (required).</param>
        /// <param name="AllowCommands">AllowCommands.</param>
        /// <param name="Difficulty">Which difficulty the world is set to.</param>
        /// <param name="GameMode">Which game mode the world defaults to.</param>
        /// <param name="GameRules">The game rule settings of this world.</param>
        /// <param name="Generator">Which generator to use for the world.</param>
        /// <param name="KeepSpawnLoaded">KeepSpawnLoaded.</param>
        /// <param name="LoadOnStartup">LoadOnStartup.</param>
        /// <param name="Loaded">True if the world should be loaded, false otherwise.</param>
        /// <param name="Seed">The seed of the world.</param>
        /// <param name="UsesMapFeatures">UsesMapFeatures.</param>
        public UpdateWorldRequest(string Name = default(string), bool? AllowCommands = default(bool?), CatalogType Difficulty = default(CatalogType), GameMode GameMode = default(GameMode), Dictionary<string, string> GameRules = default(Dictionary<string, string>), CatalogType Generator = default(CatalogType), bool? KeepSpawnLoaded = default(bool?), bool? LoadOnStartup = default(bool?), bool? Loaded = default(bool?), long? Seed = default(long?), bool? UsesMapFeatures = default(bool?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for UpdateWorldRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.AllowCommands = AllowCommands;
            this.Difficulty = Difficulty;
            this.GameMode = GameMode;
            this.GameRules = GameRules;
            this.Generator = Generator;
            this.KeepSpawnLoaded = KeepSpawnLoaded;
            this.LoadOnStartup = LoadOnStartup;
            this.Loaded = Loaded;
            this.Seed = Seed;
            this.UsesMapFeatures = UsesMapFeatures;
        }
        
        /// <summary>
        /// The name of the world
        /// </summary>
        /// <value>The name of the world</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AllowCommands
        /// </summary>
        [DataMember(Name="allowCommands", EmitDefaultValue=false)]
        public bool? AllowCommands { get; set; }

        /// <summary>
        /// Which difficulty the world is set to
        /// </summary>
        /// <value>Which difficulty the world is set to</value>
        [DataMember(Name="difficulty", EmitDefaultValue=false)]
        public CatalogType Difficulty { get; set; }

        /// <summary>
        /// Which game mode the world defaults to
        /// </summary>
        /// <value>Which game mode the world defaults to</value>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public GameMode GameMode { get; set; }

        /// <summary>
        /// The game rule settings of this world
        /// </summary>
        /// <value>The game rule settings of this world</value>
        [DataMember(Name="gameRules", EmitDefaultValue=false)]
        public Dictionary<string, string> GameRules { get; set; }

        /// <summary>
        /// Which generator to use for the world
        /// </summary>
        /// <value>Which generator to use for the world</value>
        [DataMember(Name="generator", EmitDefaultValue=false)]
        public CatalogType Generator { get; set; }

        /// <summary>
        /// Gets or Sets KeepSpawnLoaded
        /// </summary>
        [DataMember(Name="keepSpawnLoaded", EmitDefaultValue=false)]
        public bool? KeepSpawnLoaded { get; set; }

        /// <summary>
        /// Gets or Sets LoadOnStartup
        /// </summary>
        [DataMember(Name="loadOnStartup", EmitDefaultValue=false)]
        public bool? LoadOnStartup { get; set; }

        /// <summary>
        /// True if the world should be loaded, false otherwise
        /// </summary>
        /// <value>True if the world should be loaded, false otherwise</value>
        [DataMember(Name="loaded", EmitDefaultValue=false)]
        public bool? Loaded { get; set; }

        /// <summary>
        /// The seed of the world
        /// </summary>
        /// <value>The seed of the world</value>
        [DataMember(Name="seed", EmitDefaultValue=false)]
        public long? Seed { get; set; }

        /// <summary>
        /// Gets or Sets UsesMapFeatures
        /// </summary>
        [DataMember(Name="usesMapFeatures", EmitDefaultValue=false)]
        public bool? UsesMapFeatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWorldRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AllowCommands: ").Append(AllowCommands).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  GameRules: ").Append(GameRules).Append("\n");
            sb.Append("  Generator: ").Append(Generator).Append("\n");
            sb.Append("  KeepSpawnLoaded: ").Append(KeepSpawnLoaded).Append("\n");
            sb.Append("  LoadOnStartup: ").Append(LoadOnStartup).Append("\n");
            sb.Append("  Loaded: ").Append(Loaded).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  UsesMapFeatures: ").Append(UsesMapFeatures).Append("\n");
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
            return this.Equals(input as UpdateWorldRequest);
        }

        /// <summary>
        /// Returns true if UpdateWorldRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateWorldRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateWorldRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AllowCommands == input.AllowCommands ||
                    (this.AllowCommands != null &&
                    this.AllowCommands.Equals(input.AllowCommands))
                ) && 
                (
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.GameMode == input.GameMode ||
                    (this.GameMode != null &&
                    this.GameMode.Equals(input.GameMode))
                ) && 
                (
                    this.GameRules == input.GameRules ||
                    this.GameRules != null &&
                    this.GameRules.SequenceEqual(input.GameRules)
                ) && 
                (
                    this.Generator == input.Generator ||
                    (this.Generator != null &&
                    this.Generator.Equals(input.Generator))
                ) && 
                (
                    this.KeepSpawnLoaded == input.KeepSpawnLoaded ||
                    (this.KeepSpawnLoaded != null &&
                    this.KeepSpawnLoaded.Equals(input.KeepSpawnLoaded))
                ) && 
                (
                    this.LoadOnStartup == input.LoadOnStartup ||
                    (this.LoadOnStartup != null &&
                    this.LoadOnStartup.Equals(input.LoadOnStartup))
                ) && 
                (
                    this.Loaded == input.Loaded ||
                    (this.Loaded != null &&
                    this.Loaded.Equals(input.Loaded))
                ) && 
                (
                    this.Seed == input.Seed ||
                    (this.Seed != null &&
                    this.Seed.Equals(input.Seed))
                ) && 
                (
                    this.UsesMapFeatures == input.UsesMapFeatures ||
                    (this.UsesMapFeatures != null &&
                    this.UsesMapFeatures.Equals(input.UsesMapFeatures))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AllowCommands != null)
                    hashCode = hashCode * 59 + this.AllowCommands.GetHashCode();
                if (this.Difficulty != null)
                    hashCode = hashCode * 59 + this.Difficulty.GetHashCode();
                if (this.GameMode != null)
                    hashCode = hashCode * 59 + this.GameMode.GetHashCode();
                if (this.GameRules != null)
                    hashCode = hashCode * 59 + this.GameRules.GetHashCode();
                if (this.Generator != null)
                    hashCode = hashCode * 59 + this.Generator.GetHashCode();
                if (this.KeepSpawnLoaded != null)
                    hashCode = hashCode * 59 + this.KeepSpawnLoaded.GetHashCode();
                if (this.LoadOnStartup != null)
                    hashCode = hashCode * 59 + this.LoadOnStartup.GetHashCode();
                if (this.Loaded != null)
                    hashCode = hashCode * 59 + this.Loaded.GetHashCode();
                if (this.Seed != null)
                    hashCode = hashCode * 59 + this.Seed.GetHashCode();
                if (this.UsesMapFeatures != null)
                    hashCode = hashCode * 59 + this.UsesMapFeatures.GetHashCode();
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
