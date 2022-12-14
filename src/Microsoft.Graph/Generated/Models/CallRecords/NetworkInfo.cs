using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.CallRecords {
    public class NetworkInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Fraction of the call that the media endpoint detected the available bandwidth or bandwidth policy was low enough to cause poor quality of the audio sent.</summary>
        public float? BandwidthLowEventRatio {
            get { return BackingStore?.Get<float?>("bandwidthLowEventRatio"); }
            set { BackingStore?.Set("bandwidthLowEventRatio", value); }
        }
        /// <summary>The wireless LAN basic service set identifier of the media endpoint used to connect to the network.</summary>
        public string BasicServiceSetIdentifier {
            get { return BackingStore?.Get<string>("basicServiceSetIdentifier"); }
            set { BackingStore?.Set("basicServiceSetIdentifier", value); }
        }
        /// <summary>The connectionType property</summary>
        public NetworkConnectionType? ConnectionType {
            get { return BackingStore?.Get<NetworkConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the network delay was significant enough to impact the ability to have real-time two-way communication.</summary>
        public float? DelayEventRatio {
            get { return BackingStore?.Get<float?>("delayEventRatio"); }
            set { BackingStore?.Set("delayEventRatio", value); }
        }
        /// <summary>DNS suffix associated with the network adapter of the media endpoint.</summary>
        public string DnsSuffix {
            get { return BackingStore?.Get<string>("dnsSuffix"); }
            set { BackingStore?.Set("dnsSuffix", value); }
        }
        /// <summary>IP address of the media endpoint.</summary>
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
        /// <summary>Link speed in bits per second reported by the network adapter used by the media endpoint.</summary>
        public long? LinkSpeed {
            get { return BackingStore?.Get<long?>("linkSpeed"); }
            set { BackingStore?.Set("linkSpeed", value); }
        }
        /// <summary>The media access control (MAC) address of the media endpoint&apos;s network device.</summary>
        public string MacAddress {
            get { return BackingStore?.Get<string>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
        /// <summary>The networkTransportProtocol property</summary>
        public Microsoft.Graph.Models.CallRecords.NetworkTransportProtocol? NetworkTransportProtocol {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallRecords.NetworkTransportProtocol?>("networkTransportProtocol"); }
            set { BackingStore?.Set("networkTransportProtocol", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Network port number used by media endpoint.</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the network was causing poor quality of the audio received.</summary>
        public float? ReceivedQualityEventRatio {
            get { return BackingStore?.Get<float?>("receivedQualityEventRatio"); }
            set { BackingStore?.Set("receivedQualityEventRatio", value); }
        }
        /// <summary>IP address of the media endpoint as seen by the media relay server. This is typically the public internet IP address associated to the endpoint.</summary>
        public string ReflexiveIPAddress {
            get { return BackingStore?.Get<string>("reflexiveIPAddress"); }
            set { BackingStore?.Set("reflexiveIPAddress", value); }
        }
        /// <summary>IP address of the media relay server allocated by the media endpoint.</summary>
        public string RelayIPAddress {
            get { return BackingStore?.Get<string>("relayIPAddress"); }
            set { BackingStore?.Set("relayIPAddress", value); }
        }
        /// <summary>Network port number allocated on the media relay server by the media endpoint.</summary>
        public int? RelayPort {
            get { return BackingStore?.Get<int?>("relayPort"); }
            set { BackingStore?.Set("relayPort", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the network was causing poor quality of the audio sent.</summary>
        public float? SentQualityEventRatio {
            get { return BackingStore?.Get<float?>("sentQualityEventRatio"); }
            set { BackingStore?.Set("sentQualityEventRatio", value); }
        }
        /// <summary>Subnet used for media stream by the media endpoint.</summary>
        public string Subnet {
            get { return BackingStore?.Get<string>("subnet"); }
            set { BackingStore?.Set("subnet", value); }
        }
        /// <summary>List of network trace route hops collected for this media stream.*</summary>
        public List<TraceRouteHop> TraceRouteHops {
            get { return BackingStore?.Get<List<TraceRouteHop>>("traceRouteHops"); }
            set { BackingStore?.Set("traceRouteHops", value); }
        }
        /// <summary>The wifiBand property</summary>
        public Microsoft.Graph.Models.CallRecords.WifiBand? WifiBand {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallRecords.WifiBand?>("wifiBand"); }
            set { BackingStore?.Set("wifiBand", value); }
        }
        /// <summary>Estimated remaining battery charge in percentage reported by the media endpoint.</summary>
        public int? WifiBatteryCharge {
            get { return BackingStore?.Get<int?>("wifiBatteryCharge"); }
            set { BackingStore?.Set("wifiBatteryCharge", value); }
        }
        /// <summary>WiFi channel used by the media endpoint.</summary>
        public int? WifiChannel {
            get { return BackingStore?.Get<int?>("wifiChannel"); }
            set { BackingStore?.Set("wifiChannel", value); }
        }
        /// <summary>Name of the Microsoft WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.</summary>
        public string WifiMicrosoftDriver {
            get { return BackingStore?.Get<string>("wifiMicrosoftDriver"); }
            set { BackingStore?.Set("wifiMicrosoftDriver", value); }
        }
        /// <summary>Version of the Microsoft WiFi driver used by the media endpoint.</summary>
        public string WifiMicrosoftDriverVersion {
            get { return BackingStore?.Get<string>("wifiMicrosoftDriverVersion"); }
            set { BackingStore?.Set("wifiMicrosoftDriverVersion", value); }
        }
        /// <summary>The wifiRadioType property</summary>
        public Microsoft.Graph.Models.CallRecords.WifiRadioType? WifiRadioType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallRecords.WifiRadioType?>("wifiRadioType"); }
            set { BackingStore?.Set("wifiRadioType", value); }
        }
        /// <summary>WiFi signal strength in percentage reported by the media endpoint.</summary>
        public int? WifiSignalStrength {
            get { return BackingStore?.Get<int?>("wifiSignalStrength"); }
            set { BackingStore?.Set("wifiSignalStrength", value); }
        }
        /// <summary>Name of the WiFi driver used by the media endpoint. Value may be localized based on the language used by endpoint.</summary>
        public string WifiVendorDriver {
            get { return BackingStore?.Get<string>("wifiVendorDriver"); }
            set { BackingStore?.Set("wifiVendorDriver", value); }
        }
        /// <summary>Version of the WiFi driver used by the media endpoint.</summary>
        public string WifiVendorDriverVersion {
            get { return BackingStore?.Get<string>("wifiVendorDriverVersion"); }
            set { BackingStore?.Set("wifiVendorDriverVersion", value); }
        }
        /// <summary>
        /// Instantiates a new networkInfo and sets the default values.
        /// </summary>
        public NetworkInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NetworkInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bandwidthLowEventRatio", n => { BandwidthLowEventRatio = n.GetFloatValue(); } },
                {"basicServiceSetIdentifier", n => { BasicServiceSetIdentifier = n.GetStringValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<NetworkConnectionType>(); } },
                {"delayEventRatio", n => { DelayEventRatio = n.GetFloatValue(); } },
                {"dnsSuffix", n => { DnsSuffix = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"linkSpeed", n => { LinkSpeed = n.GetLongValue(); } },
                {"macAddress", n => { MacAddress = n.GetStringValue(); } },
                {"networkTransportProtocol", n => { NetworkTransportProtocol = n.GetEnumValue<NetworkTransportProtocol>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
                {"receivedQualityEventRatio", n => { ReceivedQualityEventRatio = n.GetFloatValue(); } },
                {"reflexiveIPAddress", n => { ReflexiveIPAddress = n.GetStringValue(); } },
                {"relayIPAddress", n => { RelayIPAddress = n.GetStringValue(); } },
                {"relayPort", n => { RelayPort = n.GetIntValue(); } },
                {"sentQualityEventRatio", n => { SentQualityEventRatio = n.GetFloatValue(); } },
                {"subnet", n => { Subnet = n.GetStringValue(); } },
                {"traceRouteHops", n => { TraceRouteHops = n.GetCollectionOfObjectValues<TraceRouteHop>(TraceRouteHop.CreateFromDiscriminatorValue)?.ToList(); } },
                {"wifiBand", n => { WifiBand = n.GetEnumValue<WifiBand>(); } },
                {"wifiBatteryCharge", n => { WifiBatteryCharge = n.GetIntValue(); } },
                {"wifiChannel", n => { WifiChannel = n.GetIntValue(); } },
                {"wifiMicrosoftDriver", n => { WifiMicrosoftDriver = n.GetStringValue(); } },
                {"wifiMicrosoftDriverVersion", n => { WifiMicrosoftDriverVersion = n.GetStringValue(); } },
                {"wifiRadioType", n => { WifiRadioType = n.GetEnumValue<WifiRadioType>(); } },
                {"wifiSignalStrength", n => { WifiSignalStrength = n.GetIntValue(); } },
                {"wifiVendorDriver", n => { WifiVendorDriver = n.GetStringValue(); } },
                {"wifiVendorDriverVersion", n => { WifiVendorDriverVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("bandwidthLowEventRatio", BandwidthLowEventRatio);
            writer.WriteStringValue("basicServiceSetIdentifier", BasicServiceSetIdentifier);
            writer.WriteEnumValue<NetworkConnectionType>("connectionType", ConnectionType);
            writer.WriteFloatValue("delayEventRatio", DelayEventRatio);
            writer.WriteStringValue("dnsSuffix", DnsSuffix);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteLongValue("linkSpeed", LinkSpeed);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteEnumValue<NetworkTransportProtocol>("networkTransportProtocol", NetworkTransportProtocol);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("port", Port);
            writer.WriteFloatValue("receivedQualityEventRatio", ReceivedQualityEventRatio);
            writer.WriteStringValue("reflexiveIPAddress", ReflexiveIPAddress);
            writer.WriteStringValue("relayIPAddress", RelayIPAddress);
            writer.WriteIntValue("relayPort", RelayPort);
            writer.WriteFloatValue("sentQualityEventRatio", SentQualityEventRatio);
            writer.WriteStringValue("subnet", Subnet);
            writer.WriteCollectionOfObjectValues<TraceRouteHop>("traceRouteHops", TraceRouteHops);
            writer.WriteEnumValue<WifiBand>("wifiBand", WifiBand);
            writer.WriteIntValue("wifiBatteryCharge", WifiBatteryCharge);
            writer.WriteIntValue("wifiChannel", WifiChannel);
            writer.WriteStringValue("wifiMicrosoftDriver", WifiMicrosoftDriver);
            writer.WriteStringValue("wifiMicrosoftDriverVersion", WifiMicrosoftDriverVersion);
            writer.WriteEnumValue<WifiRadioType>("wifiRadioType", WifiRadioType);
            writer.WriteIntValue("wifiSignalStrength", WifiSignalStrength);
            writer.WriteStringValue("wifiVendorDriver", WifiVendorDriver);
            writer.WriteStringValue("wifiVendorDriverVersion", WifiVendorDriverVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}