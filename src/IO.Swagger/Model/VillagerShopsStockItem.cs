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
    /// VillagerShopsStockItem
    /// </summary>
    [DataContract]
    public partial class VillagerShopsStockItem :  IEquatable<VillagerShopsStockItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VillagerShopsStockItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VillagerShopsStockItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VillagerShopsStockItem" /> class.
        /// </summary>
        /// <param name="shopId">The shop uuid offering this item listing (required).</param>
        /// <param name="id">The index of this item withing the shops inventory.</param>
        /// <param name="link">link.</param>
        public VillagerShopsStockItem(Guid? shopId = default(Guid?), int? id = default(int?), string link = default(string))
        {
            // to ensure "shopId" is required (not null)
            if (shopId == null)
            {
                throw new InvalidDataException("shopId is a required property for VillagerShopsStockItem and cannot be null");
            }
            else
            {
                this.ShopId = shopId;
            }
            this.Id = id;
            this.Link = link;
        }
        
        /// <summary>
        /// The amount of money this stack consts to buy as player
        /// </summary>
        /// <value>The amount of money this stack consts to buy as player</value>
        [DataMember(Name="buyPrice", EmitDefaultValue=false)]
        public double? BuyPrice { get; private set; }

        /// <summary>
        /// The currency for this item listing
        /// </summary>
        /// <value>The currency for this item listing</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CatalogTypeCurrency Currency { get; private set; }

        /// <summary>
        /// Returns wether this shop has a limited stock
        /// </summary>
        /// <value>Returns wether this shop has a limited stock</value>
        [DataMember(Name="hasStock", EmitDefaultValue=false)]
        public bool? HasStock { get; private set; }

        /// <summary>
        /// The raw ItemStack data for this shop listing
        /// </summary>
        /// <value>The raw ItemStack data for this shop listing</value>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public ItemStack Item { get; private set; }

        /// <summary>
        /// If this shop has a limited stock, returns how many of these items can be stocked, 0 is unlimited
        /// </summary>
        /// <value>If this shop has a limited stock, returns how many of these items can be stocked, 0 is unlimited</value>
        [DataMember(Name="maxStock", EmitDefaultValue=false)]
        public int? MaxStock { get; private set; }

        /// <summary>
        /// The amount of money this stack earns the player when selling
        /// </summary>
        /// <value>The amount of money this stack earns the player when selling</value>
        [DataMember(Name="sellPrice", EmitDefaultValue=false)]
        public double? SellPrice { get; private set; }

        /// <summary>
        /// The shop uuid offering this item listing
        /// </summary>
        /// <value>The shop uuid offering this item listing</value>
        [DataMember(Name="shopId", EmitDefaultValue=false)]
        public Guid? ShopId { get; set; }

        /// <summary>
        /// If this shop has a limited stock, returns how many items are stocked, otherwise returns items stack size
        /// </summary>
        /// <value>If this shop has a limited stock, returns how many items are stocked, otherwise returns items stack size</value>
        [DataMember(Name="stock", EmitDefaultValue=false)]
        public int? Stock { get; private set; }

        /// <summary>
        /// The index of this item withing the shops inventory
        /// </summary>
        /// <value>The index of this item withing the shops inventory</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VillagerShopsStockItem {\n");
            sb.Append("  BuyPrice: ").Append(BuyPrice).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  HasStock: ").Append(HasStock).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  MaxStock: ").Append(MaxStock).Append("\n");
            sb.Append("  SellPrice: ").Append(SellPrice).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as VillagerShopsStockItem);
        }

        /// <summary>
        /// Returns true if VillagerShopsStockItem instances are equal
        /// </summary>
        /// <param name="input">Instance of VillagerShopsStockItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VillagerShopsStockItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuyPrice == input.BuyPrice ||
                    (this.BuyPrice != null &&
                    this.BuyPrice.Equals(input.BuyPrice))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.HasStock == input.HasStock ||
                    (this.HasStock != null &&
                    this.HasStock.Equals(input.HasStock))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.MaxStock == input.MaxStock ||
                    (this.MaxStock != null &&
                    this.MaxStock.Equals(input.MaxStock))
                ) && 
                (
                    this.SellPrice == input.SellPrice ||
                    (this.SellPrice != null &&
                    this.SellPrice.Equals(input.SellPrice))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.Stock == input.Stock ||
                    (this.Stock != null &&
                    this.Stock.Equals(input.Stock))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.BuyPrice != null)
                    hashCode = hashCode * 59 + this.BuyPrice.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.HasStock != null)
                    hashCode = hashCode * 59 + this.HasStock.GetHashCode();
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.MaxStock != null)
                    hashCode = hashCode * 59 + this.MaxStock.GetHashCode();
                if (this.SellPrice != null)
                    hashCode = hashCode * 59 + this.SellPrice.GetHashCode();
                if (this.ShopId != null)
                    hashCode = hashCode * 59 + this.ShopId.GetHashCode();
                if (this.Stock != null)
                    hashCode = hashCode * 59 + this.Stock.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
