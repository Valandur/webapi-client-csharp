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
    /// ExecuteCommandResponse
    /// </summary>
    [DataContract]
    public partial class ExecuteCommandResponse :  IEquatable<ExecuteCommandResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteCommandResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecuteCommandResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteCommandResponse" /> class.
        /// </summary>
        /// <param name="cmd">The command that was executed (required).</param>
        /// <param name="ok">True if this command executed successfully, false otherwise (required).</param>
        /// <param name="error">Any potential error that occured during execution.</param>
        /// <param name="response">The response chat lines that were sent when executing the command.</param>
        public ExecuteCommandResponse(string cmd = default(string), bool? ok = default(bool?), string error = default(string), List<string> response = default(List<string>))
        {
            // to ensure "cmd" is required (not null)
            if (cmd == null)
            {
                throw new InvalidDataException("cmd is a required property for ExecuteCommandResponse and cannot be null");
            }
            else
            {
                this.Cmd = cmd;
            }
            // to ensure "ok" is required (not null)
            if (ok == null)
            {
                throw new InvalidDataException("ok is a required property for ExecuteCommandResponse and cannot be null");
            }
            else
            {
                this.Ok = ok;
            }
            this.Error = error;
            this.Response = response;
        }
        
        /// <summary>
        /// The command that was executed
        /// </summary>
        /// <value>The command that was executed</value>
        [DataMember(Name="cmd", EmitDefaultValue=false)]
        public string Cmd { get; set; }

        /// <summary>
        /// True if this command executed successfully, false otherwise
        /// </summary>
        /// <value>True if this command executed successfully, false otherwise</value>
        [DataMember(Name="ok", EmitDefaultValue=false)]
        public bool? Ok { get; set; }

        /// <summary>
        /// Any potential error that occured during execution
        /// </summary>
        /// <value>Any potential error that occured during execution</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// The response chat lines that were sent when executing the command
        /// </summary>
        /// <value>The response chat lines that were sent when executing the command</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public List<string> Response { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteCommandResponse {\n");
            sb.Append("  Cmd: ").Append(Cmd).Append("\n");
            sb.Append("  Ok: ").Append(Ok).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
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
            return this.Equals(input as ExecuteCommandResponse);
        }

        /// <summary>
        /// Returns true if ExecuteCommandResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteCommandResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteCommandResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cmd == input.Cmd ||
                    (this.Cmd != null &&
                    this.Cmd.Equals(input.Cmd))
                ) && 
                (
                    this.Ok == input.Ok ||
                    (this.Ok != null &&
                    this.Ok.Equals(input.Ok))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Response == input.Response ||
                    this.Response != null &&
                    this.Response.SequenceEqual(input.Response)
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
                if (this.Cmd != null)
                    hashCode = hashCode * 59 + this.Cmd.GetHashCode();
                if (this.Ok != null)
                    hashCode = hashCode * 59 + this.Ok.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
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
