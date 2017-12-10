/* 
 * WebAPI
 *
 * Access Sponge powered Minecraft servers through a WebAPI  # Introduction This is the documentation of the various API routes offered by the WebAPI plugin.  This documentation assumes that you are familiar with the basic concepts of Web API's, such as `GET`, `PUT`, `POST` and `DELETE` methods, request `HEADERS` and `RESPONSE CODES` and `JSON` data.  By default this documentation can be found at http:/localhost:8080 (while your minecraft server is running) and the various routes start with http:/localhost:8080/api/...  As a quick test try reaching the route http:/localhost:8080/api/info (remember that you can only access \"localhost\" routes on the server on which you are running minecraft). This route should show you basic information about your server, like the motd and player count.  # Additional data Certain endpoints (such as `/player`, `/entity` and `/tile-entity` have additional properties which are not documented here, because the data depends on the concrete object type (eg. `Sheep` have a wool color, others do not) and on the other plugins/mods that are running on your server which might add additional data.  You can also find more information in the github docs (https:/github.com/Valandur/Web-API/tree/master/docs/DATA.md) 
 *
 * OpenAPI spec version: <version>
 * 
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
        /// <param name="Name">The name of the world..</param>
        /// <param name="Seed">The seed number. A random seed is generated if not provided..</param>
        /// <param name="Generator">The id of the generator type to use. Check &#x60;/registry/org.spongepowered.api.world.GeneratorType&#x60;..</param>
        /// <param name="GameMode">The id of the game mode to use. Check &#x60;/registry/org.spongepowered.api.entity.living.player.gamemode.GameMode&#x60;..</param>
        /// <param name="Difficulty">The id of the difficutly to use. Check &#x60;/registry/org.spongepowered.api.world.difficulty.Difficulty&#x60;..</param>
        /// <param name="LoadOnStartup">True if the world is loaded when the server starts, false otherwise..</param>
        /// <param name="KeepSpawnLoaded">True to keep the spawn area of the world loaded, even if it is empty..</param>
        /// <param name="AllowCommands">True if executing commands is allowed in the world..</param>
        /// <param name="UsesMapFeatures">True to use map features of the generator (such as villages)..</param>
        /// <param name="Loaded">True to load the world, false to unload it..</param>
        /// <param name="GameRules">A map of keys to values for the game rules of the world..</param>
        public UpdateWorldRequest(string Name = default(string), decimal? Seed = default(decimal?), string Generator = default(string), string GameMode = default(string), string Difficulty = default(string), bool? LoadOnStartup = default(bool?), bool? KeepSpawnLoaded = default(bool?), bool? AllowCommands = default(bool?), bool? UsesMapFeatures = default(bool?), bool? Loaded = default(bool?), Object GameRules = default(Object))
        {
            this.Name = Name;
            this.Seed = Seed;
            this.Generator = Generator;
            this.GameMode = GameMode;
            this.Difficulty = Difficulty;
            this.LoadOnStartup = LoadOnStartup;
            this.KeepSpawnLoaded = KeepSpawnLoaded;
            this.AllowCommands = AllowCommands;
            this.UsesMapFeatures = UsesMapFeatures;
            this.Loaded = Loaded;
            this.GameRules = GameRules;
        }
        
        /// <summary>
        /// The name of the world.
        /// </summary>
        /// <value>The name of the world.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The seed number. A random seed is generated if not provided.
        /// </summary>
        /// <value>The seed number. A random seed is generated if not provided.</value>
        [DataMember(Name="seed", EmitDefaultValue=false)]
        public decimal? Seed { get; set; }

        /// <summary>
        /// The id of the generator type to use. Check &#x60;/registry/org.spongepowered.api.world.GeneratorType&#x60;.
        /// </summary>
        /// <value>The id of the generator type to use. Check &#x60;/registry/org.spongepowered.api.world.GeneratorType&#x60;.</value>
        [DataMember(Name="generator", EmitDefaultValue=false)]
        public string Generator { get; set; }

        /// <summary>
        /// The id of the game mode to use. Check &#x60;/registry/org.spongepowered.api.entity.living.player.gamemode.GameMode&#x60;.
        /// </summary>
        /// <value>The id of the game mode to use. Check &#x60;/registry/org.spongepowered.api.entity.living.player.gamemode.GameMode&#x60;.</value>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public string GameMode { get; set; }

        /// <summary>
        /// The id of the difficutly to use. Check &#x60;/registry/org.spongepowered.api.world.difficulty.Difficulty&#x60;.
        /// </summary>
        /// <value>The id of the difficutly to use. Check &#x60;/registry/org.spongepowered.api.world.difficulty.Difficulty&#x60;.</value>
        [DataMember(Name="difficulty", EmitDefaultValue=false)]
        public string Difficulty { get; set; }

        /// <summary>
        /// True if the world is loaded when the server starts, false otherwise.
        /// </summary>
        /// <value>True if the world is loaded when the server starts, false otherwise.</value>
        [DataMember(Name="loadOnStartup", EmitDefaultValue=false)]
        public bool? LoadOnStartup { get; set; }

        /// <summary>
        /// True to keep the spawn area of the world loaded, even if it is empty.
        /// </summary>
        /// <value>True to keep the spawn area of the world loaded, even if it is empty.</value>
        [DataMember(Name="keepSpawnLoaded", EmitDefaultValue=false)]
        public bool? KeepSpawnLoaded { get; set; }

        /// <summary>
        /// True if executing commands is allowed in the world.
        /// </summary>
        /// <value>True if executing commands is allowed in the world.</value>
        [DataMember(Name="allowCommands", EmitDefaultValue=false)]
        public bool? AllowCommands { get; set; }

        /// <summary>
        /// True to use map features of the generator (such as villages).
        /// </summary>
        /// <value>True to use map features of the generator (such as villages).</value>
        [DataMember(Name="usesMapFeatures", EmitDefaultValue=false)]
        public bool? UsesMapFeatures { get; set; }

        /// <summary>
        /// True to load the world, false to unload it.
        /// </summary>
        /// <value>True to load the world, false to unload it.</value>
        [DataMember(Name="loaded", EmitDefaultValue=false)]
        public bool? Loaded { get; set; }

        /// <summary>
        /// A map of keys to values for the game rules of the world.
        /// </summary>
        /// <value>A map of keys to values for the game rules of the world.</value>
        [DataMember(Name="gameRules", EmitDefaultValue=false)]
        public Object GameRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWorldRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
            sb.Append("  Generator: ").Append(Generator).Append("\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  LoadOnStartup: ").Append(LoadOnStartup).Append("\n");
            sb.Append("  KeepSpawnLoaded: ").Append(KeepSpawnLoaded).Append("\n");
            sb.Append("  AllowCommands: ").Append(AllowCommands).Append("\n");
            sb.Append("  UsesMapFeatures: ").Append(UsesMapFeatures).Append("\n");
            sb.Append("  Loaded: ").Append(Loaded).Append("\n");
            sb.Append("  GameRules: ").Append(GameRules).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UpdateWorldRequest);
        }

        /// <summary>
        /// Returns true if UpdateWorldRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateWorldRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateWorldRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Seed == other.Seed ||
                    this.Seed != null &&
                    this.Seed.Equals(other.Seed)
                ) && 
                (
                    this.Generator == other.Generator ||
                    this.Generator != null &&
                    this.Generator.Equals(other.Generator)
                ) && 
                (
                    this.GameMode == other.GameMode ||
                    this.GameMode != null &&
                    this.GameMode.Equals(other.GameMode)
                ) && 
                (
                    this.Difficulty == other.Difficulty ||
                    this.Difficulty != null &&
                    this.Difficulty.Equals(other.Difficulty)
                ) && 
                (
                    this.LoadOnStartup == other.LoadOnStartup ||
                    this.LoadOnStartup != null &&
                    this.LoadOnStartup.Equals(other.LoadOnStartup)
                ) && 
                (
                    this.KeepSpawnLoaded == other.KeepSpawnLoaded ||
                    this.KeepSpawnLoaded != null &&
                    this.KeepSpawnLoaded.Equals(other.KeepSpawnLoaded)
                ) && 
                (
                    this.AllowCommands == other.AllowCommands ||
                    this.AllowCommands != null &&
                    this.AllowCommands.Equals(other.AllowCommands)
                ) && 
                (
                    this.UsesMapFeatures == other.UsesMapFeatures ||
                    this.UsesMapFeatures != null &&
                    this.UsesMapFeatures.Equals(other.UsesMapFeatures)
                ) && 
                (
                    this.Loaded == other.Loaded ||
                    this.Loaded != null &&
                    this.Loaded.Equals(other.Loaded)
                ) && 
                (
                    this.GameRules == other.GameRules ||
                    this.GameRules != null &&
                    this.GameRules.Equals(other.GameRules)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Seed != null)
                    hash = hash * 59 + this.Seed.GetHashCode();
                if (this.Generator != null)
                    hash = hash * 59 + this.Generator.GetHashCode();
                if (this.GameMode != null)
                    hash = hash * 59 + this.GameMode.GetHashCode();
                if (this.Difficulty != null)
                    hash = hash * 59 + this.Difficulty.GetHashCode();
                if (this.LoadOnStartup != null)
                    hash = hash * 59 + this.LoadOnStartup.GetHashCode();
                if (this.KeepSpawnLoaded != null)
                    hash = hash * 59 + this.KeepSpawnLoaded.GetHashCode();
                if (this.AllowCommands != null)
                    hash = hash * 59 + this.AllowCommands.GetHashCode();
                if (this.UsesMapFeatures != null)
                    hash = hash * 59 + this.UsesMapFeatures.GetHashCode();
                if (this.Loaded != null)
                    hash = hash * 59 + this.Loaded.GetHashCode();
                if (this.GameRules != null)
                    hash = hash * 59 + this.GameRules.GetHashCode();
                return hash;
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
