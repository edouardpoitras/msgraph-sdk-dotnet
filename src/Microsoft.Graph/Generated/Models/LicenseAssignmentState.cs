using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class LicenseAssignmentState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The assignedByGroup property</summary>
        public string AssignedByGroup {
            get { return BackingStore?.Get<string>("assignedByGroup"); }
            set { BackingStore?.Set("assignedByGroup", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The disabledPlans property</summary>
        public List<Guid?> DisabledPlans {
            get { return BackingStore?.Get<List<Guid?>>("disabledPlans"); }
            set { BackingStore?.Set("disabledPlans", value); }
        }
        /// <summary>The error property</summary>
        public string Error {
            get { return BackingStore?.Get<string>("error"); }
            set { BackingStore?.Set("error", value); }
        }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The skuId property</summary>
        public Guid? SkuId {
            get { return BackingStore?.Get<Guid?>("skuId"); }
            set { BackingStore?.Set("skuId", value); }
        }
        /// <summary>The state property</summary>
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new licenseAssignmentState and sets the default values.
        /// </summary>
        public LicenseAssignmentState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LicenseAssignmentState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LicenseAssignmentState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedByGroup", n => { AssignedByGroup = n.GetStringValue(); } },
                {"disabledPlans", n => { DisabledPlans = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"error", n => { Error = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"skuId", n => { SkuId = n.GetGuidValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignedByGroup", AssignedByGroup);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("disabledPlans", DisabledPlans);
            writer.WriteStringValue("error", Error);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteGuidValue("skuId", SkuId);
            writer.WriteStringValue("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}