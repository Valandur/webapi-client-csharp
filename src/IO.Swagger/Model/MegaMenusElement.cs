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
    /// MegaMenusElement
    /// </summary>
    [DataContract]
    public partial class MegaMenusElement :  IEquatable<MegaMenusElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MegaMenusElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MegaMenusElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MegaMenusElement" /> class.
        /// </summary>
        /// <param name="Access">Access properties applicable to MSlot type elements.</param>
        /// <param name="Icon">Icon for this element.</param>
        /// <param name="Lore">The lore or values of this element, displayed in the item tooltip as lore.</param>
        /// <param name="Name">The name of this element, displayed as item name.</param>
        /// <param name="Type">The type of this element.</param>
        public MegaMenusElement(int? Access = default(int?), ItemStack Icon = default(ItemStack), List<string> Lore = default(List<string>), string Name = default(string), string Type = default(string))
        {
            this.Access = Access;
            this.Icon = Icon;
            this.Lore = Lore;
            this.Name = Name;
            this.Type = Type;
        }
        
        /// <summary>
        /// The API link that can be used to obtain more information about this object
        /// </summary>
        /// <value>The API link that can be used to obtain more information about this object</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; private set; }

        /// <summary>
        /// Access properties applicable to MSlot type elements
        /// </summary>
        /// <value>Access properties applicable to MSlot type elements</value>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public int? Access { get; set; }

        /// <summary>
        /// Icon for this element
        /// </summary>
        /// <value>Icon for this element</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public ItemStack Icon { get; set; }

        /// <summary>
        /// The lore or values of this element, displayed in the item tooltip as lore
        /// </summary>
        /// <value>The lore or values of this element, displayed in the item tooltip as lore</value>
        [DataMember(Name="lore", EmitDefaultValue=false)]
        public List<string> Lore { get; set; }

        /// <summary>
        /// The name of this element, displayed as item name
        /// </summary>
        /// <value>The name of this element, displayed as item name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of this element
        /// </summary>
        /// <value>The type of this element</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MegaMenusElement {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Lore: ").Append(Lore).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as MegaMenusElement);
        }

        /// <summary>
        /// Returns true if MegaMenusElement instances are equal
        /// </summary>
        /// <param name="input">Instance of MegaMenusElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MegaMenusElement input)
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
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Lore == input.Lore ||
                    this.Lore != null &&
                    this.Lore.SequenceEqual(input.Lore)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Lore != null)
                    hashCode = hashCode * 59 + this.Lore.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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