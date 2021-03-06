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
    /// ExecuteCommandRequest
    /// </summary>
    [DataContract]
    public partial class ExecuteCommandRequest :  IEquatable<ExecuteCommandRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteCommandRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecuteCommandRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteCommandRequest" /> class.
        /// </summary>
        /// <param name="command">The command to execute (required).</param>
        /// <param name="hiddenInConsole">True to hide the execution of the command in the console, false otherwise.</param>
        /// <param name="name">The name of the source that executes the command.</param>
        /// <param name="waitLines">The amount of text lines to wait for in the response.</param>
        /// <param name="waitTime">The amount of time to wait for a response.</param>
        public ExecuteCommandRequest(string command = default(string), bool? hiddenInConsole = default(bool?), string name = default(string), int? waitLines = default(int?), int? waitTime = default(int?))
        {
            // to ensure "command" is required (not null)
            if (command == null)
            {
                throw new InvalidDataException("command is a required property for ExecuteCommandRequest and cannot be null");
            }
            else
            {
                this.Command = command;
            }
            this.HiddenInConsole = hiddenInConsole;
            this.Name = name;
            this.WaitLines = waitLines;
            this.WaitTime = waitTime;
        }
        
        /// <summary>
        /// The command to execute
        /// </summary>
        /// <value>The command to execute</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public string Command { get; set; }

        /// <summary>
        /// True to hide the execution of the command in the console, false otherwise
        /// </summary>
        /// <value>True to hide the execution of the command in the console, false otherwise</value>
        [DataMember(Name="hiddenInConsole", EmitDefaultValue=false)]
        public bool? HiddenInConsole { get; set; }

        /// <summary>
        /// The name of the source that executes the command
        /// </summary>
        /// <value>The name of the source that executes the command</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The amount of text lines to wait for in the response
        /// </summary>
        /// <value>The amount of text lines to wait for in the response</value>
        [DataMember(Name="waitLines", EmitDefaultValue=false)]
        public int? WaitLines { get; set; }

        /// <summary>
        /// The amount of time to wait for a response
        /// </summary>
        /// <value>The amount of time to wait for a response</value>
        [DataMember(Name="waitTime", EmitDefaultValue=false)]
        public int? WaitTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteCommandRequest {\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  HiddenInConsole: ").Append(HiddenInConsole).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WaitLines: ").Append(WaitLines).Append("\n");
            sb.Append("  WaitTime: ").Append(WaitTime).Append("\n");
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
            return this.Equals(input as ExecuteCommandRequest);
        }

        /// <summary>
        /// Returns true if ExecuteCommandRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteCommandRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteCommandRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.HiddenInConsole == input.HiddenInConsole ||
                    (this.HiddenInConsole != null &&
                    this.HiddenInConsole.Equals(input.HiddenInConsole))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.WaitLines == input.WaitLines ||
                    (this.WaitLines != null &&
                    this.WaitLines.Equals(input.WaitLines))
                ) && 
                (
                    this.WaitTime == input.WaitTime ||
                    (this.WaitTime != null &&
                    this.WaitTime.Equals(input.WaitTime))
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
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.HiddenInConsole != null)
                    hashCode = hashCode * 59 + this.HiddenInConsole.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.WaitLines != null)
                    hashCode = hashCode * 59 + this.WaitLines.GetHashCode();
                if (this.WaitTime != null)
                    hashCode = hashCode * 59 + this.WaitTime.GetHashCode();
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
