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
    /// VillagerShopsShop
    /// </summary>
    [DataContract]
    public partial class VillagerShopsShop :  IEquatable<VillagerShopsShop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VillagerShopsShop" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VillagerShopsShop() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VillagerShopsShop" /> class.
        /// </summary>
        /// <param name="entityType">The minecraft entity type string for this shops visual entity (required).</param>
        /// <param name="entityVariant">A very dynamic variant string for vanilla mobs, most variants as in the minecraft wiki should be supported.</param>
        /// <param name="location">Where the shop is currently located.</param>
        /// <param name="name">The escaped shop name.</param>
        /// <param name="owner">If this shop is a player shop this conatins the UUID of this shops owner. Omitting this field or setting it to null will remove the player-shop association..</param>
        /// <param name="rotation">The mobs roations around their up-axis.</param>
        /// <param name="stockContainer">Location where a container should reside for stocking items. Omitting this field or setting it to null will remove the stock container. Having a player-shop without container is undefined behaviour!.</param>
        /// <param name="stockItems">Returns a list of all stock items currently listed. This property is read only..</param>
        /// <param name="uid">The unique shop identifier; this is not the mob uuid.</param>
        public VillagerShopsShop(CatalogTypeEntityType entityType = default(CatalogTypeEntityType), string entityVariant = default(string), Location location = default(Location), string name = default(string), Guid? owner = default(Guid?), double? rotation = default(double?), Location stockContainer = default(Location), List<VillagerShopsStockItem> stockItems = default(List<VillagerShopsStockItem>), Guid? uid = default(Guid?))
        {
            // to ensure "entityType" is required (not null)
            if (entityType == null)
            {
                throw new InvalidDataException("entityType is a required property for VillagerShopsShop and cannot be null");
            }
            else
            {
                this.EntityType = entityType;
            }
            this.EntityVariant = entityVariant;
            this.Location = location;
            this.Name = name;
            this.Owner = owner;
            this.Rotation = rotation;
            this.StockContainer = stockContainer;
            this.StockItems = stockItems;
            this.Uid = uid;
        }
        
        /// <summary>
        /// The minecraft entity type string for this shops visual entity
        /// </summary>
        /// <value>The minecraft entity type string for this shops visual entity</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public CatalogTypeEntityType EntityType { get; set; }

        /// <summary>
        /// The API link that can be used to obtain more information about this object
        /// </summary>
        /// <value>The API link that can be used to obtain more information about this object</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; private set; }

        /// <summary>
        /// A very dynamic variant string for vanilla mobs, most variants as in the minecraft wiki should be supported
        /// </summary>
        /// <value>A very dynamic variant string for vanilla mobs, most variants as in the minecraft wiki should be supported</value>
        [DataMember(Name="entityVariant", EmitDefaultValue=false)]
        public string EntityVariant { get; set; }

        /// <summary>
        /// Where the shop is currently located
        /// </summary>
        /// <value>Where the shop is currently located</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Location Location { get; set; }

        /// <summary>
        /// The escaped shop name
        /// </summary>
        /// <value>The escaped shop name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// If this shop is a player shop this conatins the UUID of this shops owner. Omitting this field or setting it to null will remove the player-shop association.
        /// </summary>
        /// <value>If this shop is a player shop this conatins the UUID of this shops owner. Omitting this field or setting it to null will remove the player-shop association.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public Guid? Owner { get; set; }

        /// <summary>
        /// The mobs roations around their up-axis
        /// </summary>
        /// <value>The mobs roations around their up-axis</value>
        [DataMember(Name="rotation", EmitDefaultValue=false)]
        public double? Rotation { get; set; }

        /// <summary>
        /// Location where a container should reside for stocking items. Omitting this field or setting it to null will remove the stock container. Having a player-shop without container is undefined behaviour!
        /// </summary>
        /// <value>Location where a container should reside for stocking items. Omitting this field or setting it to null will remove the stock container. Having a player-shop without container is undefined behaviour!</value>
        [DataMember(Name="stockContainer", EmitDefaultValue=false)]
        public Location StockContainer { get; set; }

        /// <summary>
        /// Returns a list of all stock items currently listed. This property is read only.
        /// </summary>
        /// <value>Returns a list of all stock items currently listed. This property is read only.</value>
        [DataMember(Name="stockItems", EmitDefaultValue=false)]
        public List<VillagerShopsStockItem> StockItems { get; set; }

        /// <summary>
        /// The unique shop identifier; this is not the mob uuid
        /// </summary>
        /// <value>The unique shop identifier; this is not the mob uuid</value>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public Guid? Uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VillagerShopsShop {\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  EntityVariant: ").Append(EntityVariant).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  StockContainer: ").Append(StockContainer).Append("\n");
            sb.Append("  StockItems: ").Append(StockItems).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
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
            return this.Equals(input as VillagerShopsShop);
        }

        /// <summary>
        /// Returns true if VillagerShopsShop instances are equal
        /// </summary>
        /// <param name="input">Instance of VillagerShopsShop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VillagerShopsShop input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.EntityVariant == input.EntityVariant ||
                    (this.EntityVariant != null &&
                    this.EntityVariant.Equals(input.EntityVariant))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Rotation == input.Rotation ||
                    (this.Rotation != null &&
                    this.Rotation.Equals(input.Rotation))
                ) && 
                (
                    this.StockContainer == input.StockContainer ||
                    (this.StockContainer != null &&
                    this.StockContainer.Equals(input.StockContainer))
                ) && 
                (
                    this.StockItems == input.StockItems ||
                    this.StockItems != null &&
                    this.StockItems.SequenceEqual(input.StockItems)
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
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
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.EntityVariant != null)
                    hashCode = hashCode * 59 + this.EntityVariant.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Rotation != null)
                    hashCode = hashCode * 59 + this.Rotation.GetHashCode();
                if (this.StockContainer != null)
                    hashCode = hashCode * 59 + this.StockContainer.GetHashCode();
                if (this.StockItems != null)
                    hashCode = hashCode * 59 + this.StockItems.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
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
