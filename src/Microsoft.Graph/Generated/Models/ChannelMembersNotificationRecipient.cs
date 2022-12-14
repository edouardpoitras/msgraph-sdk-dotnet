using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ChannelMembersNotificationRecipient : TeamworkNotificationRecipient, IParsable {
        /// <summary>The unique identifier for the channel whose members should receive the notification.</summary>
        public string ChannelId {
            get { return BackingStore?.Get<string>("channelId"); }
            set { BackingStore?.Set("channelId", value); }
        }
        /// <summary>The unique identifier for the team under which the channel resides.</summary>
        public string TeamId {
            get { return BackingStore?.Get<string>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
        /// <summary>
        /// Instantiates a new ChannelMembersNotificationRecipient and sets the default values.
        /// </summary>
        public ChannelMembersNotificationRecipient() : base() {
            OdataType = "#microsoft.graph.channelMembersNotificationRecipient";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChannelMembersNotificationRecipient CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelMembersNotificationRecipient();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channelId", n => { ChannelId = n.GetStringValue(); } },
                {"teamId", n => { TeamId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}