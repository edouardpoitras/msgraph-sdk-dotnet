using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.CallRecords {
    public class PstnCallLogRow : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The source of the call duration data. If the call uses a third-party telecommunications operator via the Operator Connect Program, the operator may provide their own call duration data. In this case, the property value is operator. Otherwise, the value is microsoft.</summary>
        public PstnCallDurationSource? CallDurationSource {
            get { return BackingStore?.Get<PstnCallDurationSource?>(nameof(CallDurationSource)); }
            set { BackingStore?.Set(nameof(CallDurationSource), value); }
        }
        /// <summary>Number dialed in E.164 format.</summary>
        public string CalleeNumber {
            get { return BackingStore?.Get<string>(nameof(CalleeNumber)); }
            set { BackingStore?.Set(nameof(CalleeNumber), value); }
        }
        /// <summary>Number that received the call for inbound calls or the number dialed for outbound calls. E.164 format.</summary>
        public string CallerNumber {
            get { return BackingStore?.Get<string>(nameof(CallerNumber)); }
            set { BackingStore?.Set(nameof(CallerNumber), value); }
        }
        /// <summary>Call identifier. Not guaranteed to be unique.</summary>
        public string CallId {
            get { return BackingStore?.Get<string>(nameof(CallId)); }
            set { BackingStore?.Set(nameof(CallId), value); }
        }
        /// <summary>Whether the call was a PSTN outbound or inbound call and the type of call such as a call placed by a user or an audio conference.</summary>
        public string CallType {
            get { return BackingStore?.Get<string>(nameof(CallType)); }
            set { BackingStore?.Set(nameof(CallType), value); }
        }
        /// <summary>Amount of money or cost of the call that is charged to your account.</summary>
        public decimal? Charge {
            get { return BackingStore?.Get<decimal?>(nameof(Charge)); }
            set { BackingStore?.Set(nameof(Charge), value); }
        }
        /// <summary>ID of the audio conference.</summary>
        public string ConferenceId {
            get { return BackingStore?.Get<string>(nameof(ConferenceId)); }
            set { BackingStore?.Set(nameof(ConferenceId), value); }
        }
        /// <summary>Connection fee price.</summary>
        public decimal? ConnectionCharge {
            get { return BackingStore?.Get<decimal?>(nameof(ConnectionCharge)); }
            set { BackingStore?.Set(nameof(ConnectionCharge), value); }
        }
        /// <summary>Type of currency used to calculate the cost of the call (ISO 4217).</summary>
        public string Currency {
            get { return BackingStore?.Get<string>(nameof(Currency)); }
            set { BackingStore?.Set(nameof(Currency), value); }
        }
        /// <summary>Whether the call was domestic (within a country or region) or international (outside a country or region) based on the user&apos;s location.</summary>
        public string DestinationContext {
            get { return BackingStore?.Get<string>(nameof(DestinationContext)); }
            set { BackingStore?.Set(nameof(DestinationContext), value); }
        }
        /// <summary>Country or region dialed.</summary>
        public string DestinationName {
            get { return BackingStore?.Get<string>(nameof(DestinationName)); }
            set { BackingStore?.Set(nameof(DestinationName), value); }
        }
        /// <summary>How long the call was connected, in seconds.</summary>
        public int? Duration {
            get { return BackingStore?.Get<int?>(nameof(Duration)); }
            set { BackingStore?.Set(nameof(Duration), value); }
        }
        /// <summary>Call end time.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EndDateTime)); }
            set { BackingStore?.Set(nameof(EndDateTime), value); }
        }
        /// <summary>Unique call identifier. GUID.</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>User&apos;s phone number type, such as a service of toll-free number.</summary>
        public string InventoryType {
            get { return BackingStore?.Get<string>(nameof(InventoryType)); }
            set { BackingStore?.Set(nameof(InventoryType), value); }
        }
        /// <summary>The license used for the call.</summary>
        public string LicenseCapability {
            get { return BackingStore?.Get<string>(nameof(LicenseCapability)); }
            set { BackingStore?.Set(nameof(LicenseCapability), value); }
        }
        /// <summary>The telecommunications operator which provided PSTN services for this call. This may be Microsoft, or it may be a third-party operator via the Operator Connect Program.</summary>
        public string Operator {
            get { return BackingStore?.Get<string>(nameof(Operator)); }
            set { BackingStore?.Set(nameof(Operator), value); }
        }
        /// <summary>Call start time.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartDateTime)); }
            set { BackingStore?.Set(nameof(StartDateTime), value); }
        }
        /// <summary>Country code of the tenant, ISO 3166-1 alpha-2.</summary>
        public string TenantCountryCode {
            get { return BackingStore?.Get<string>(nameof(TenantCountryCode)); }
            set { BackingStore?.Set(nameof(TenantCountryCode), value); }
        }
        /// <summary>Country code of the user, ISO 3166-1 alpha-2.</summary>
        public string UsageCountryCode {
            get { return BackingStore?.Get<string>(nameof(UsageCountryCode)); }
            set { BackingStore?.Set(nameof(UsageCountryCode), value); }
        }
        /// <summary>Display name of the user.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>Calling user&apos;s ID in Graph. GUID. This and other user info will be null/empty for bot call types (ucap_in, ucap_out).</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>UserPrincipalName (sign-in name) in Azure Active Directory. This is usually the same as user&apos;s SIP Address, and can be same as user&apos;s e-mail address.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Instantiates a new pstnCallLogRow and sets the default values.
        /// </summary>
        public PstnCallLogRow() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PstnCallLogRow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PstnCallLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callDurationSource", n => { CallDurationSource = n.GetEnumValue<PstnCallDurationSource>(); } },
                {"calleeNumber", n => { CalleeNumber = n.GetStringValue(); } },
                {"callerNumber", n => { CallerNumber = n.GetStringValue(); } },
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"callType", n => { CallType = n.GetStringValue(); } },
                {"charge", n => { Charge = n.GetDecimalValue(); } },
                {"conferenceId", n => { ConferenceId = n.GetStringValue(); } },
                {"connectionCharge", n => { ConnectionCharge = n.GetDecimalValue(); } },
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"destinationContext", n => { DestinationContext = n.GetStringValue(); } },
                {"destinationName", n => { DestinationName = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetIntValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"inventoryType", n => { InventoryType = n.GetStringValue(); } },
                {"licenseCapability", n => { LicenseCapability = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantCountryCode", n => { TenantCountryCode = n.GetStringValue(); } },
                {"usageCountryCode", n => { UsageCountryCode = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PstnCallDurationSource>("callDurationSource", CallDurationSource);
            writer.WriteStringValue("calleeNumber", CalleeNumber);
            writer.WriteStringValue("callerNumber", CallerNumber);
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callType", CallType);
            writer.WriteDecimalValue("charge", Charge);
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteDecimalValue("connectionCharge", ConnectionCharge);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("destinationContext", DestinationContext);
            writer.WriteStringValue("destinationName", DestinationName);
            writer.WriteIntValue("duration", Duration);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("inventoryType", InventoryType);
            writer.WriteStringValue("licenseCapability", LicenseCapability);
            writer.WriteStringValue("operator", Operator);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("tenantCountryCode", TenantCountryCode);
            writer.WriteStringValue("usageCountryCode", UsageCountryCode);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
