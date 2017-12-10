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
    /// ServerInfo
    /// </summary>
    [DataContract]
    public partial class ServerInfo :  IEquatable<ServerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInfo" /> class.
        /// </summary>
        /// <param name="Motd">The message of the day set on the server..</param>
        /// <param name="Players">The amount of players currently playing on the server.</param>
        /// <param name="MaxPlayers">The maximum amount of players allowed on the server.</param>
        /// <param name="UptimeTicks">The number of ticks the server has been running.</param>
        /// <param name="Tps">The average ticks per second the server is running with. 20 is ideal..</param>
        /// <param name="HasWhitelist">True if the server has a whitelist, false otherwise..</param>
        /// <param name="MinecraftVersion">The minecraft version running on the server..</param>
        /// <param name="Game">Game.</param>
        /// <param name="Api">Api.</param>
        /// <param name="Implementation">Implementation.</param>
        public ServerInfo(string Motd = default(string), decimal? Players = default(decimal?), decimal? MaxPlayers = default(decimal?), decimal? UptimeTicks = default(decimal?), decimal? Tps = default(decimal?), bool? HasWhitelist = default(bool?), string MinecraftVersion = default(string), ServerInfoDetail Game = default(ServerInfoDetail), ServerInfoDetail Api = default(ServerInfoDetail), ServerInfoDetail Implementation = default(ServerInfoDetail))
        {
            this.Motd = Motd;
            this.Players = Players;
            this.MaxPlayers = MaxPlayers;
            this.UptimeTicks = UptimeTicks;
            this.Tps = Tps;
            this.HasWhitelist = HasWhitelist;
            this.MinecraftVersion = MinecraftVersion;
            this.Game = Game;
            this.Api = Api;
            this.Implementation = Implementation;
        }
        
        /// <summary>
        /// The message of the day set on the server.
        /// </summary>
        /// <value>The message of the day set on the server.</value>
        [DataMember(Name="motd", EmitDefaultValue=false)]
        public string Motd { get; set; }

        /// <summary>
        /// The amount of players currently playing on the server
        /// </summary>
        /// <value>The amount of players currently playing on the server</value>
        [DataMember(Name="players", EmitDefaultValue=false)]
        public decimal? Players { get; set; }

        /// <summary>
        /// The maximum amount of players allowed on the server
        /// </summary>
        /// <value>The maximum amount of players allowed on the server</value>
        [DataMember(Name="maxPlayers", EmitDefaultValue=false)]
        public decimal? MaxPlayers { get; set; }

        /// <summary>
        /// The number of ticks the server has been running
        /// </summary>
        /// <value>The number of ticks the server has been running</value>
        [DataMember(Name="uptimeTicks", EmitDefaultValue=false)]
        public decimal? UptimeTicks { get; set; }

        /// <summary>
        /// The average ticks per second the server is running with. 20 is ideal.
        /// </summary>
        /// <value>The average ticks per second the server is running with. 20 is ideal.</value>
        [DataMember(Name="tps", EmitDefaultValue=false)]
        public decimal? Tps { get; set; }

        /// <summary>
        /// True if the server has a whitelist, false otherwise.
        /// </summary>
        /// <value>True if the server has a whitelist, false otherwise.</value>
        [DataMember(Name="hasWhitelist", EmitDefaultValue=false)]
        public bool? HasWhitelist { get; set; }

        /// <summary>
        /// The minecraft version running on the server.
        /// </summary>
        /// <value>The minecraft version running on the server.</value>
        [DataMember(Name="minecraftVersion", EmitDefaultValue=false)]
        public string MinecraftVersion { get; set; }

        /// <summary>
        /// Gets or Sets Game
        /// </summary>
        [DataMember(Name="game", EmitDefaultValue=false)]
        public ServerInfoDetail Game { get; set; }

        /// <summary>
        /// Gets or Sets Api
        /// </summary>
        [DataMember(Name="api", EmitDefaultValue=false)]
        public ServerInfoDetail Api { get; set; }

        /// <summary>
        /// Gets or Sets Implementation
        /// </summary>
        [DataMember(Name="implementation", EmitDefaultValue=false)]
        public ServerInfoDetail Implementation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerInfo {\n");
            sb.Append("  Motd: ").Append(Motd).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
            sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
            sb.Append("  UptimeTicks: ").Append(UptimeTicks).Append("\n");
            sb.Append("  Tps: ").Append(Tps).Append("\n");
            sb.Append("  HasWhitelist: ").Append(HasWhitelist).Append("\n");
            sb.Append("  MinecraftVersion: ").Append(MinecraftVersion).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  Implementation: ").Append(Implementation).Append("\n");
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
            return this.Equals(obj as ServerInfo);
        }

        /// <summary>
        /// Returns true if ServerInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Motd == other.Motd ||
                    this.Motd != null &&
                    this.Motd.Equals(other.Motd)
                ) && 
                (
                    this.Players == other.Players ||
                    this.Players != null &&
                    this.Players.Equals(other.Players)
                ) && 
                (
                    this.MaxPlayers == other.MaxPlayers ||
                    this.MaxPlayers != null &&
                    this.MaxPlayers.Equals(other.MaxPlayers)
                ) && 
                (
                    this.UptimeTicks == other.UptimeTicks ||
                    this.UptimeTicks != null &&
                    this.UptimeTicks.Equals(other.UptimeTicks)
                ) && 
                (
                    this.Tps == other.Tps ||
                    this.Tps != null &&
                    this.Tps.Equals(other.Tps)
                ) && 
                (
                    this.HasWhitelist == other.HasWhitelist ||
                    this.HasWhitelist != null &&
                    this.HasWhitelist.Equals(other.HasWhitelist)
                ) && 
                (
                    this.MinecraftVersion == other.MinecraftVersion ||
                    this.MinecraftVersion != null &&
                    this.MinecraftVersion.Equals(other.MinecraftVersion)
                ) && 
                (
                    this.Game == other.Game ||
                    this.Game != null &&
                    this.Game.Equals(other.Game)
                ) && 
                (
                    this.Api == other.Api ||
                    this.Api != null &&
                    this.Api.Equals(other.Api)
                ) && 
                (
                    this.Implementation == other.Implementation ||
                    this.Implementation != null &&
                    this.Implementation.Equals(other.Implementation)
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
                if (this.Motd != null)
                    hash = hash * 59 + this.Motd.GetHashCode();
                if (this.Players != null)
                    hash = hash * 59 + this.Players.GetHashCode();
                if (this.MaxPlayers != null)
                    hash = hash * 59 + this.MaxPlayers.GetHashCode();
                if (this.UptimeTicks != null)
                    hash = hash * 59 + this.UptimeTicks.GetHashCode();
                if (this.Tps != null)
                    hash = hash * 59 + this.Tps.GetHashCode();
                if (this.HasWhitelist != null)
                    hash = hash * 59 + this.HasWhitelist.GetHashCode();
                if (this.MinecraftVersion != null)
                    hash = hash * 59 + this.MinecraftVersion.GetHashCode();
                if (this.Game != null)
                    hash = hash * 59 + this.Game.GetHashCode();
                if (this.Api != null)
                    hash = hash * 59 + this.Api.GetHashCode();
                if (this.Implementation != null)
                    hash = hash * 59 + this.Implementation.GetHashCode();
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
