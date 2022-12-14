using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class OfficeGraphInsights : Entity, IParsable {
        /// <summary>Calculated relationship identifying documents shared with or by the user. This includes URLs, file attachments, and reference attachments to OneDrive for Business and SharePoint files found in Outlook messages and meetings. This also includes URLs and reference attachments to Teams conversations. Ordered by recency of share.</summary>
        public List<SharedInsight> Shared {
            get { return BackingStore?.Get<List<SharedInsight>>("shared"); }
            set { BackingStore?.Set("shared", value); }
        }
        /// <summary>Calculated relationship identifying documents trending around a user. Trending documents are calculated based on activity of the user&apos;s closest network of people and include files stored in OneDrive for Business and SharePoint. Trending insights help the user to discover potentially useful content that the user has access to, but has never viewed before.</summary>
        public List<Microsoft.Graph.Models.Trending> Trending {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Trending>>("trending"); }
            set { BackingStore?.Set("trending", value); }
        }
        /// <summary>Calculated relationship identifying the latest documents viewed or modified by a user, including OneDrive for Business and SharePoint documents, ranked by recency of use.</summary>
        public List<UsedInsight> Used {
            get { return BackingStore?.Get<List<UsedInsight>>("used"); }
            set { BackingStore?.Set("used", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OfficeGraphInsights CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeGraphInsights();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"shared", n => { Shared = n.GetCollectionOfObjectValues<SharedInsight>(SharedInsight.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trending", n => { Trending = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Trending>(Microsoft.Graph.Models.Trending.CreateFromDiscriminatorValue)?.ToList(); } },
                {"used", n => { Used = n.GetCollectionOfObjectValues<UsedInsight>(UsedInsight.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SharedInsight>("shared", Shared);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Trending>("trending", Trending);
            writer.WriteCollectionOfObjectValues<UsedInsight>("used", Used);
        }
    }
}