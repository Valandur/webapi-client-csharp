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
    /// A collection of item stacks.
    /// </summary>
    [DataContract]
    public partial class Inventory :  IEquatable<Inventory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory" /> class.
        /// </summary>
        /// <param name="Name">The name of the inventory..</param>
        /// <param name="StackCount">The amount of different stacks in the inventory..</param>
        /// <param name="ItemCount">The total amount of items in the inventory..</param>
        /// <param name="Items">The item stacks in the inventory.</param>
        public Inventory(string Name = default(string), decimal? StackCount = default(decimal?), decimal? ItemCount = default(decimal?), List<ItemStack> Items = default(List<ItemStack>))
        {
            this.Name = Name;
            this.StackCount = StackCount;
            this.ItemCount = ItemCount;
            this.Items = Items;
        }
        
        /// <summary>
        /// The name of the inventory.
        /// </summary>
        /// <value>The name of the inventory.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The amount of different stacks in the inventory.
        /// </summary>
        /// <value>The amount of different stacks in the inventory.</value>
        [DataMember(Name="stackCount", EmitDefaultValue=false)]
        public decimal? StackCount { get; set; }

        /// <summary>
        /// The total amount of items in the inventory.
        /// </summary>
        /// <value>The total amount of items in the inventory.</value>
        [DataMember(Name="itemCount", EmitDefaultValue=false)]
        public decimal? ItemCount { get; set; }

        /// <summary>
        /// The item stacks in the inventory
        /// </summary>
        /// <value>The item stacks in the inventory</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ItemStack> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Inventory {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StackCount: ").Append(StackCount).Append("\n");
            sb.Append("  ItemCount: ").Append(ItemCount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(obj as Inventory);
        }

        /// <summary>
        /// Returns true if Inventory instances are equal
        /// </summary>
        /// <param name="other">Instance of Inventory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Inventory other)
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
                    this.StackCount == other.StackCount ||
                    this.StackCount != null &&
                    this.StackCount.Equals(other.StackCount)
                ) && 
                (
                    this.ItemCount == other.ItemCount ||
                    this.ItemCount != null &&
                    this.ItemCount.Equals(other.ItemCount)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                if (this.StackCount != null)
                    hash = hash * 59 + this.StackCount.GetHashCode();
                if (this.ItemCount != null)
                    hash = hash * 59 + this.ItemCount.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
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
