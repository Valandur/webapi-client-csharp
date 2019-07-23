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
    /// UserReport
    /// </summary>
    [DataContract]
    public partial class UserReport :  IEquatable<UserReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserReport" /> class.
        /// </summary>
        /// <param name="DailyAverage">DailyAverage.</param>
        /// <param name="From">From.</param>
        /// <param name="MonthlyAverage">MonthlyAverage.</param>
        /// <param name="Name">Name.</param>
        /// <param name="To">To.</param>
        /// <param name="Total">Total.</param>
        /// <param name="Uuid">Uuid.</param>
        /// <param name="WeeklyAverage">WeeklyAverage.</param>
        public UserReport(TimeHolder DailyAverage = default(TimeHolder), LocalDate From = default(LocalDate), TimeHolder MonthlyAverage = default(TimeHolder), string Name = default(string), LocalDate To = default(LocalDate), TimeHolder Total = default(TimeHolder), Guid? Uuid = default(Guid?), TimeHolder WeeklyAverage = default(TimeHolder))
        {
            this.DailyAverage = DailyAverage;
            this.From = From;
            this.MonthlyAverage = MonthlyAverage;
            this.Name = Name;
            this.To = To;
            this.Total = Total;
            this.Uuid = Uuid;
            this.WeeklyAverage = WeeklyAverage;
        }
        
        /// <summary>
        /// Gets or Sets DailyAverage
        /// </summary>
        [DataMember(Name="dailyAverage", EmitDefaultValue=false)]
        public TimeHolder DailyAverage { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public LocalDate From { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyAverage
        /// </summary>
        [DataMember(Name="monthlyAverage", EmitDefaultValue=false)]
        public TimeHolder MonthlyAverage { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public LocalDate To { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public TimeHolder Total { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Gets or Sets WeeklyAverage
        /// </summary>
        [DataMember(Name="weeklyAverage", EmitDefaultValue=false)]
        public TimeHolder WeeklyAverage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserReport {\n");
            sb.Append("  DailyAverage: ").Append(DailyAverage).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  MonthlyAverage: ").Append(MonthlyAverage).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  WeeklyAverage: ").Append(WeeklyAverage).Append("\n");
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
            return this.Equals(input as UserReport);
        }

        /// <summary>
        /// Returns true if UserReport instances are equal
        /// </summary>
        /// <param name="input">Instance of UserReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DailyAverage == input.DailyAverage ||
                    (this.DailyAverage != null &&
                    this.DailyAverage.Equals(input.DailyAverage))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.MonthlyAverage == input.MonthlyAverage ||
                    (this.MonthlyAverage != null &&
                    this.MonthlyAverage.Equals(input.MonthlyAverage))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.WeeklyAverage == input.WeeklyAverage ||
                    (this.WeeklyAverage != null &&
                    this.WeeklyAverage.Equals(input.WeeklyAverage))
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
                if (this.DailyAverage != null)
                    hashCode = hashCode * 59 + this.DailyAverage.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.MonthlyAverage != null)
                    hashCode = hashCode * 59 + this.MonthlyAverage.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.WeeklyAverage != null)
                    hashCode = hashCode * 59 + this.WeeklyAverage.GetHashCode();
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
