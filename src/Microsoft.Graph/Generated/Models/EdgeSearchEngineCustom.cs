using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class EdgeSearchEngineCustom : EdgeSearchEngineBase, IParsable {
        /// <summary>Points to a https link containing the OpenSearch xml file that contains, at minimum, the short name and the URL to the search Engine.</summary>
        public string EdgeSearchEngineOpenSearchXmlUrl {
            get { return BackingStore?.Get<string>("edgeSearchEngineOpenSearchXmlUrl"); }
            set { BackingStore?.Set("edgeSearchEngineOpenSearchXmlUrl", value); }
        }
        /// <summary>
        /// Instantiates a new EdgeSearchEngineCustom and sets the default values.
        /// </summary>
        public EdgeSearchEngineCustom() : base() {
            OdataType = "#microsoft.graph.edgeSearchEngineCustom";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdgeSearchEngineCustom CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdgeSearchEngineCustom();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"edgeSearchEngineOpenSearchXmlUrl", n => { EdgeSearchEngineOpenSearchXmlUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("edgeSearchEngineOpenSearchXmlUrl", EdgeSearchEngineOpenSearchXmlUrl);
        }
    }
}