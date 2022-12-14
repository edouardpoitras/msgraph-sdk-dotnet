using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class CallOptions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether to hide the app after the call is escalated.</summary>
        public bool? HideBotAfterEscalation {
            get { return BackingStore?.Get<bool?>("hideBotAfterEscalation"); }
            set { BackingStore?.Set("hideBotAfterEscalation", value); }
        }
        /// <summary>Indicates whether content sharing notifications should be enabled for the call.</summary>
        public bool? IsContentSharingNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isContentSharingNotificationEnabled"); }
            set { BackingStore?.Set("isContentSharingNotificationEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new callOptions and sets the default values.
        /// </summary>
        public CallOptions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CallOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.incomingCallOptions" => new IncomingCallOptions(),
                "#microsoft.graph.outgoingCallOptions" => new OutgoingCallOptions(),
                _ => new CallOptions(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hideBotAfterEscalation", n => { HideBotAfterEscalation = n.GetBoolValue(); } },
                {"isContentSharingNotificationEnabled", n => { IsContentSharingNotificationEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hideBotAfterEscalation", HideBotAfterEscalation);
            writer.WriteBoolValue("isContentSharingNotificationEnabled", IsContentSharingNotificationEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}