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
    /// Intraday candle.  Внетридневная свеча.
    /// </summary>
    [DataContract(Name = "IntradayCandle")]
    public partial class IntradayCandle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayCandle" /> class.
        /// </summary>
        /// <param name="timestamp">Time of order canceled on the server in UTC.  Время, когда заявка была отменена на сервере. В UTC..</param>
        /// <param name="open">open.</param>
        /// <param name="close">close.</param>
        /// <param name="high">high.</param>
        /// <param name="low">low.</param>
        /// <param name="volume">Volume.  Объем торгов..</param>
        public IntradayCandle(DateOnly? timestamp = default(DateOnly?), Decimal open = default(Decimal), Decimal close = default(Decimal), Decimal high = default(Decimal), Decimal low = default(Decimal), long volume = default(long))
        {
            this.Timestamp = timestamp;
            this.Open = open;
            this.Close = close;
            this.High = high;
            this.Low = low;
            this.Volume = volume;
        }

        /// <summary>
        /// Time of order canceled on the server in UTC.  Время, когда заявка была отменена на сервере. В UTC.
        /// </summary>
        /// <value>Time of order canceled on the server in UTC.  Время, когда заявка была отменена на сервере. В UTC.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = true)]
        public DateOnly? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public Decimal Open { get; set; }

        /// <summary>
        /// Gets or Sets Close
        /// </summary>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        public Decimal Close { get; set; }

        /// <summary>
        /// Gets or Sets High
        /// </summary>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public Decimal High { get; set; }

        /// <summary>
        /// Gets or Sets Low
        /// </summary>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public Decimal Low { get; set; }

        /// <summary>
        /// Volume.  Объем торгов.
        /// </summary>
        /// <value>Volume.  Объем торгов.</value>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public long Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntradayCandle {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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