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
    /// RedProtectRegion
    /// </summary>
    [DataContract]
    public partial class RedProtectRegion :  IEquatable<RedProtectRegion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedProtectRegion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RedProtectRegion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedProtectRegion" /> class.
        /// </summary>
        /// <param name="id">The unique id of this region (required).</param>
        /// <param name="max">The maximum coordinates that define the region (required).</param>
        /// <param name="min">The minimum coordinates that define the region (required).</param>
        /// <param name="name">The name of this region (required).</param>
        /// <param name="world">The world this region is located in (required).</param>
        /// <param name="admins">A list of players that are admins of this region.</param>
        /// <param name="canDelete">True if this region can be deleted, false otherwise.</param>
        /// <param name="date">The date this region was created?.</param>
        /// <param name="flags">A map of flags applicable to this region.</param>
        /// <param name="leaders">A list of players that are leaders of this region.</param>
        /// <param name="members">A list of players that are members of this region.</param>
        /// <param name="priority">The priority of this region compared to other regions.</param>
        /// <param name="tpPoint">The teleport point for this region.</param>
        /// <param name="welcomeMessage">The welcome message displayed to a player when they enter this region.</param>
        public RedProtectRegion(string id = default(string), Vector3d max = default(Vector3d), Vector3d min = default(Vector3d), string name = default(string), World world = default(World), List<Player> admins = default(List<Player>), bool? canDelete = default(bool?), string date = default(string), Dictionary<string, Object> flags = default(Dictionary<string, Object>), List<Player> leaders = default(List<Player>), List<Player> members = default(List<Player>), int? priority = default(int?), Location tpPoint = default(Location), string welcomeMessage = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for RedProtectRegion and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "max" is required (not null)
            if (max == null)
            {
                throw new InvalidDataException("max is a required property for RedProtectRegion and cannot be null");
            }
            else
            {
                this.Max = max;
            }
            // to ensure "min" is required (not null)
            if (min == null)
            {
                throw new InvalidDataException("min is a required property for RedProtectRegion and cannot be null");
            }
            else
            {
                this.Min = min;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RedProtectRegion and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "world" is required (not null)
            if (world == null)
            {
                throw new InvalidDataException("world is a required property for RedProtectRegion and cannot be null");
            }
            else
            {
                this.World = world;
            }
            this.Admins = admins;
            this.CanDelete = canDelete;
            this.Date = date;
            this.Flags = flags;
            this.Leaders = leaders;
            this.Members = members;
            this.Priority = priority;
            this.TpPoint = tpPoint;
            this.WelcomeMessage = welcomeMessage;
        }
        
        /// <summary>
        /// The unique id of this region
        /// </summary>
        /// <value>The unique id of this region</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The API link that can be used to obtain more information about this object
        /// </summary>
        /// <value>The API link that can be used to obtain more information about this object</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; private set; }

        /// <summary>
        /// The maximum coordinates that define the region
        /// </summary>
        /// <value>The maximum coordinates that define the region</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public Vector3d Max { get; set; }

        /// <summary>
        /// The minimum coordinates that define the region
        /// </summary>
        /// <value>The minimum coordinates that define the region</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public Vector3d Min { get; set; }

        /// <summary>
        /// The name of this region
        /// </summary>
        /// <value>The name of this region</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The world this region is located in
        /// </summary>
        /// <value>The world this region is located in</value>
        [DataMember(Name="world", EmitDefaultValue=false)]
        public World World { get; set; }

        /// <summary>
        /// A list of players that are admins of this region
        /// </summary>
        /// <value>A list of players that are admins of this region</value>
        [DataMember(Name="admins", EmitDefaultValue=false)]
        public List<Player> Admins { get; set; }

        /// <summary>
        /// True if this region can be deleted, false otherwise
        /// </summary>
        /// <value>True if this region can be deleted, false otherwise</value>
        [DataMember(Name="canDelete", EmitDefaultValue=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// The date this region was created?
        /// </summary>
        /// <value>The date this region was created?</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// A map of flags applicable to this region
        /// </summary>
        /// <value>A map of flags applicable to this region</value>
        [DataMember(Name="flags", EmitDefaultValue=false)]
        public Dictionary<string, Object> Flags { get; set; }

        /// <summary>
        /// A list of players that are leaders of this region
        /// </summary>
        /// <value>A list of players that are leaders of this region</value>
        [DataMember(Name="leaders", EmitDefaultValue=false)]
        public List<Player> Leaders { get; set; }

        /// <summary>
        /// A list of players that are members of this region
        /// </summary>
        /// <value>A list of players that are members of this region</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<Player> Members { get; set; }

        /// <summary>
        /// The priority of this region compared to other regions
        /// </summary>
        /// <value>The priority of this region compared to other regions</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The teleport point for this region
        /// </summary>
        /// <value>The teleport point for this region</value>
        [DataMember(Name="tpPoint", EmitDefaultValue=false)]
        public Location TpPoint { get; set; }

        /// <summary>
        /// The welcome message displayed to a player when they enter this region
        /// </summary>
        /// <value>The welcome message displayed to a player when they enter this region</value>
        [DataMember(Name="welcomeMessage", EmitDefaultValue=false)]
        public string WelcomeMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedProtectRegion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  World: ").Append(World).Append("\n");
            sb.Append("  Admins: ").Append(Admins).Append("\n");
            sb.Append("  CanDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Leaders: ").Append(Leaders).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  TpPoint: ").Append(TpPoint).Append("\n");
            sb.Append("  WelcomeMessage: ").Append(WelcomeMessage).Append("\n");
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
            return this.Equals(input as RedProtectRegion);
        }

        /// <summary>
        /// Returns true if RedProtectRegion instances are equal
        /// </summary>
        /// <param name="input">Instance of RedProtectRegion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedProtectRegion input)
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
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.World == input.World ||
                    (this.World != null &&
                    this.World.Equals(input.World))
                ) && 
                (
                    this.Admins == input.Admins ||
                    this.Admins != null &&
                    this.Admins.SequenceEqual(input.Admins)
                ) && 
                (
                    this.CanDelete == input.CanDelete ||
                    (this.CanDelete != null &&
                    this.CanDelete.Equals(input.CanDelete))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Flags == input.Flags ||
                    this.Flags != null &&
                    this.Flags.SequenceEqual(input.Flags)
                ) && 
                (
                    this.Leaders == input.Leaders ||
                    this.Leaders != null &&
                    this.Leaders.SequenceEqual(input.Leaders)
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.TpPoint == input.TpPoint ||
                    (this.TpPoint != null &&
                    this.TpPoint.Equals(input.TpPoint))
                ) && 
                (
                    this.WelcomeMessage == input.WelcomeMessage ||
                    (this.WelcomeMessage != null &&
                    this.WelcomeMessage.Equals(input.WelcomeMessage))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.World != null)
                    hashCode = hashCode * 59 + this.World.GetHashCode();
                if (this.Admins != null)
                    hashCode = hashCode * 59 + this.Admins.GetHashCode();
                if (this.CanDelete != null)
                    hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Leaders != null)
                    hashCode = hashCode * 59 + this.Leaders.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.TpPoint != null)
                    hashCode = hashCode * 59 + this.TpPoint.GetHashCode();
                if (this.WelcomeMessage != null)
                    hashCode = hashCode * 59 + this.WelcomeMessage.GetHashCode();
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
