using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Root.Invite {
    /// <summary>
    /// Provides operations to call the invite method.
    /// </summary>
    public class InviteResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
        public List<Microsoft.Graph.Models.Permission> Value {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Permission>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InviteResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InviteResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Permission>(Microsoft.Graph.Models.Permission.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Permission>("value", Value);
        }
    }
}