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
    /// ChunksResponse
    /// </summary>
    [DataContract]
    public partial class ChunksResponse :  IEquatable<ChunksResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunksResponse" /> class.
        /// </summary>
        /// <param name="Ok">Ok.</param>
        /// <param name="Chunks">An array of loaded chunks..</param>
        public ChunksResponse(Ok Ok = default(Ok), List<Chunk> Chunks = default(List<Chunk>))
        {
            this.Ok = Ok;
            this.Chunks = Chunks;
        }
        
        /// <summary>
        /// Gets or Sets Ok
        /// </summary>
        [DataMember(Name="ok", EmitDefaultValue=false)]
        public Ok Ok { get; set; }

        /// <summary>
        /// An array of loaded chunks.
        /// </summary>
        /// <value>An array of loaded chunks.</value>
        [DataMember(Name="chunks", EmitDefaultValue=false)]
        public List<Chunk> Chunks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChunksResponse {\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
            sb.Append("  Chunks: ").Append(Chunks).Append("\n");
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
            return this.Equals(obj as ChunksResponse);
        }

        /// <summary>
        /// Returns true if ChunksResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChunksResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChunksResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ok == other.Ok ||
                    this.Ok != null &&
                    this.Ok.Equals(other.Ok)
                ) && 
                (
                    this.Chunks == other.Chunks ||
                    this.Chunks != null &&
                    this.Chunks.SequenceEqual(other.Chunks)
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
                if (this.Ok != null)
                    hash = hash * 59 + this.Ok.GetHashCode();
                if (this.Chunks != null)
                    hash = hash * 59 + this.Chunks.GetHashCode();
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
