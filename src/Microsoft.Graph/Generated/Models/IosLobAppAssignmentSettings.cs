using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class IosLobAppAssignmentSettings : MobileAppAssignmentSettings, IParsable {
        /// <summary>When TRUE, indicates that the app can be uninstalled by the user. When FALSE, indicates that the app cannot be uninstalled by the user. By default, this property is set to null which internally is treated as TRUE.</summary>
        public bool? IsRemovable {
            get { return BackingStore?.Get<bool?>("isRemovable"); }
            set { BackingStore?.Set("isRemovable", value); }
        }
        /// <summary>When TRUE, indicates that the app should be uninstalled when the device is removed from Intune. When FALSE, indicates that the app will not be uninstalled when the device is removed from Intune. By default, property is set to null which internally is treated as TRUE.</summary>
        public bool? UninstallOnDeviceRemoval {
            get { return BackingStore?.Get<bool?>("uninstallOnDeviceRemoval"); }
            set { BackingStore?.Set("uninstallOnDeviceRemoval", value); }
        }
        /// <summary>This is the unique identifier (Id) of the VPN Configuration to apply to the app.</summary>
        public string VpnConfigurationId {
            get { return BackingStore?.Get<string>("vpnConfigurationId"); }
            set { BackingStore?.Set("vpnConfigurationId", value); }
        }
        /// <summary>
        /// Instantiates a new IosLobAppAssignmentSettings and sets the default values.
        /// </summary>
        public IosLobAppAssignmentSettings() : base() {
            OdataType = "#microsoft.graph.iosLobAppAssignmentSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosLobAppAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosLobAppAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                {"uninstallOnDeviceRemoval", n => { UninstallOnDeviceRemoval = n.GetBoolValue(); } },
                {"vpnConfigurationId", n => { VpnConfigurationId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteBoolValue("uninstallOnDeviceRemoval", UninstallOnDeviceRemoval);
            writer.WriteStringValue("vpnConfigurationId", VpnConfigurationId);
        }
    }
}