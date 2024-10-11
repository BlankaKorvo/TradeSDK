/*
 * Trade API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: current
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Result of new Stop Order request.  Результат выставления стоп заявки.
    /// </summary>
    [DataContract(Name = "NewStopResult")]
    public partial class NewStopResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewStopResult" /> class.
        /// </summary>
        /// <param name="clientId">Trade Account Id.  Идентификатор торгового счёта..</param>
        /// <param name="stopId">Stop Order Id.  Идентификатор стоп заявки..</param>
        /// <param name="securityCode">Security Code.  Тикер инструмента..</param>
        /// <param name="securityBoard">Trading Board.  Режим торгов..</param>
        public NewStopResult(string clientId = default(string), int stopId = default(int), string securityCode = default(string), string securityBoard = default(string))
        {
            this.ClientId = clientId;
            this.StopId = stopId;
            this.SecurityCode = securityCode;
            this.SecurityBoard = securityBoard;
        }

        /// <summary>
        /// Trade Account Id.  Идентификатор торгового счёта.
        /// </summary>
        /// <value>Trade Account Id.  Идентификатор торгового счёта.</value>
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Stop Order Id.  Идентификатор стоп заявки.
        /// </summary>
        /// <value>Stop Order Id.  Идентификатор стоп заявки.</value>
        [DataMember(Name = "stopId", EmitDefaultValue = false)]
        public int StopId { get; set; }

        /// <summary>
        /// Security Code.  Тикер инструмента.
        /// </summary>
        /// <value>Security Code.  Тикер инструмента.</value>
        [DataMember(Name = "securityCode", EmitDefaultValue = true)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Trading Board.  Режим торгов.
        /// </summary>
        /// <value>Trading Board.  Режим торгов.</value>
        [DataMember(Name = "securityBoard", EmitDefaultValue = true)]
        public string SecurityBoard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewStopResult {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  StopId: ").Append(StopId).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  SecurityBoard: ").Append(SecurityBoard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}