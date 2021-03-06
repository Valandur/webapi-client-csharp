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
    /// Advancement
    /// </summary>
    [DataContract]
    public partial class Advancement :  IEquatable<Advancement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Advancement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Advancement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Advancement" /> class.
        /// </summary>
        /// <param name="id">The unique id of the advancement (required).</param>
        /// <param name="title">The title of the advancement (required).</param>
        /// <param name="announceToChat">True if the achieving of this advancement is announced in chat, false otherwise.</param>
        /// <param name="description">The description of the advancement.</param>
        /// <param name="hidden">True if this is a hidden advancement.</param>
        /// <param name="parent">The parent advancement, which must be unlocked prior to this advancement.</param>
        /// <param name="showToast">True if achieving this advancement shows the player a toast message, false otherwise.</param>
        /// <param name="tree">The advancement tree that this advancement belongs to.</param>
        public Advancement(string id = default(string), string title = default(string), bool? announceToChat = default(bool?), string description = default(string), bool? hidden = default(bool?), Advancement parent = default(Advancement), bool? showToast = default(bool?), CatalogTypeAdvancementTree tree = default(CatalogTypeAdvancementTree))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Advancement and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for Advancement and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.AnnounceToChat = announceToChat;
            this.Description = description;
            this.Hidden = hidden;
            this.Parent = parent;
            this.ShowToast = showToast;
            this.Tree = tree;
        }
        
        /// <summary>
        /// The unique id of the advancement
        /// </summary>
        /// <value>The unique id of the advancement</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the advancement
        /// </summary>
        /// <value>The name of the advancement</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The title of the advancement
        /// </summary>
        /// <value>The title of the advancement</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// True if the achieving of this advancement is announced in chat, false otherwise
        /// </summary>
        /// <value>True if the achieving of this advancement is announced in chat, false otherwise</value>
        [DataMember(Name="announceToChat", EmitDefaultValue=false)]
        public bool? AnnounceToChat { get; set; }

        /// <summary>
        /// The description of the advancement
        /// </summary>
        /// <value>The description of the advancement</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// True if this is a hidden advancement
        /// </summary>
        /// <value>True if this is a hidden advancement</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// The parent advancement, which must be unlocked prior to this advancement
        /// </summary>
        /// <value>The parent advancement, which must be unlocked prior to this advancement</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public Advancement Parent { get; set; }

        /// <summary>
        /// True if achieving this advancement shows the player a toast message, false otherwise
        /// </summary>
        /// <value>True if achieving this advancement shows the player a toast message, false otherwise</value>
        [DataMember(Name="showToast", EmitDefaultValue=false)]
        public bool? ShowToast { get; set; }

        /// <summary>
        /// The advancement tree that this advancement belongs to
        /// </summary>
        /// <value>The advancement tree that this advancement belongs to</value>
        [DataMember(Name="tree", EmitDefaultValue=false)]
        public CatalogTypeAdvancementTree Tree { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Advancement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AnnounceToChat: ").Append(AnnounceToChat).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  ShowToast: ").Append(ShowToast).Append("\n");
            sb.Append("  Tree: ").Append(Tree).Append("\n");
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
            return this.Equals(input as Advancement);
        }

        /// <summary>
        /// Returns true if Advancement instances are equal
        /// </summary>
        /// <param name="input">Instance of Advancement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Advancement input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.AnnounceToChat == input.AnnounceToChat ||
                    (this.AnnounceToChat != null &&
                    this.AnnounceToChat.Equals(input.AnnounceToChat))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.ShowToast == input.ShowToast ||
                    (this.ShowToast != null &&
                    this.ShowToast.Equals(input.ShowToast))
                ) && 
                (
                    this.Tree == input.Tree ||
                    (this.Tree != null &&
                    this.Tree.Equals(input.Tree))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.AnnounceToChat != null)
                    hashCode = hashCode * 59 + this.AnnounceToChat.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.ShowToast != null)
                    hashCode = hashCode * 59 + this.ShowToast.GetHashCode();
                if (this.Tree != null)
                    hashCode = hashCode * 59 + this.Tree.GetHashCode();
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
