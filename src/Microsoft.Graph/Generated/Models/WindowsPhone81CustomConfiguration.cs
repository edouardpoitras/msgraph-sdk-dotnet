using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class WindowsPhone81CustomConfiguration : DeviceConfiguration, IParsable {
        /// <summary>OMA settings. This collection can contain a maximum of 1000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OmaSetting>? OmaSettings {
            get { return BackingStore?.Get<List<OmaSetting>?>("omaSettings"); }
            set { BackingStore?.Set("omaSettings", value); }
        }
#nullable restore
#else
        public List<OmaSetting> OmaSettings {
            get { return BackingStore?.Get<List<OmaSetting>>("omaSettings"); }
            set { BackingStore?.Set("omaSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new WindowsPhone81CustomConfiguration and sets the default values.
        /// </summary>
        public WindowsPhone81CustomConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsPhone81CustomConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsPhone81CustomConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81CustomConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"omaSettings", n => { OmaSettings = n.GetCollectionOfObjectValues<OmaSetting>(OmaSetting.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OmaSetting>("omaSettings", OmaSettings);
        }
    }
}