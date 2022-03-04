using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Names.Add {
    public class AddRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public Json Reference { get; set; }
        /// <summary>
        /// Instantiates a new addRequestBody and sets the default values.
        /// </summary>
        public AddRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as AddRequestBody).Comment = n.GetStringValue(); } },
                {"name", (o,n) => { (o as AddRequestBody).Name = n.GetStringValue(); } },
                {"reference", (o,n) => { (o as AddRequestBody).Reference = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Json>("reference", Reference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}