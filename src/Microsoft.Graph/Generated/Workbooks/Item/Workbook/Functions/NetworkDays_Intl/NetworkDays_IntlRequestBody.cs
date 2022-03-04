using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.NetworkDays_Intl {
    public class NetworkDays_IntlRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json EndDate { get; set; }
        public Json Holidays { get; set; }
        public Json StartDate { get; set; }
        public Json Weekend { get; set; }
        /// <summary>
        /// Instantiates a new networkDays_IntlRequestBody and sets the default values.
        /// </summary>
        public NetworkDays_IntlRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDate", (o,n) => { (o as NetworkDays_IntlRequestBody).EndDate = n.GetObjectValue<Json>(); } },
                {"holidays", (o,n) => { (o as NetworkDays_IntlRequestBody).Holidays = n.GetObjectValue<Json>(); } },
                {"startDate", (o,n) => { (o as NetworkDays_IntlRequestBody).StartDate = n.GetObjectValue<Json>(); } },
                {"weekend", (o,n) => { (o as NetworkDays_IntlRequestBody).Weekend = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("endDate", EndDate);
            writer.WriteObjectValue<Json>("holidays", Holidays);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteObjectValue<Json>("weekend", Weekend);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}