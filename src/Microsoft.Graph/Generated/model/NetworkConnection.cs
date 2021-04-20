// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type NetworkConnection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class NetworkConnection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConnection"/> class.
        /// </summary>
        public NetworkConnection()
        {
            this.ODataType = "microsoft.graph.networkConnection";
        }

        /// <summary>
        /// Gets or sets applicationName.
        /// Name of the application managing the network connection (for example, Facebook, SMTP, etc.).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationName", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationName { get; set; }
    
        /// <summary>
        /// Gets or sets destinationAddress.
        /// Destination IP address (of the network connection).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationAddress", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationAddress { get; set; }
    
        /// <summary>
        /// Gets or sets destinationDomain.
        /// Destination domain portion of the destination URL. (for example 'www.contoso.com').
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationDomain", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationDomain { get; set; }
    
        /// <summary>
        /// Gets or sets destinationLocation.
        /// Location (by IP address mapping) associated with the destination of a network connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationLocation", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationLocation { get; set; }
    
        /// <summary>
        /// Gets or sets destinationPort.
        /// Destination port (of the network connection).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationPort", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationPort { get; set; }
    
        /// <summary>
        /// Gets or sets destinationUrl.
        /// Network connection URL/URI string - excluding parameters. (for example 'www.contoso.com/products/default.html')
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets direction.
        /// Network connection direction. Possible values are: unknown, inbound, outbound.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "direction", Required = Newtonsoft.Json.Required.Default)]
        public ConnectionDirection? Direction { get; set; }
    
        /// <summary>
        /// Gets or sets domainRegisteredDateTime.
        /// Date when the destination domain was registered. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainRegisteredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DomainRegisteredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets localDnsName.
        /// The local DNS name resolution as it appears in the host's local DNS cache (for example, in case the 'hosts' file was tampered with).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localDnsName", Required = Newtonsoft.Json.Required.Default)]
        public string LocalDnsName { get; set; }
    
        /// <summary>
        /// Gets or sets natDestinationAddress.
        /// Network Address Translation destination IP address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natDestinationAddress", Required = Newtonsoft.Json.Required.Default)]
        public string NatDestinationAddress { get; set; }
    
        /// <summary>
        /// Gets or sets natDestinationPort.
        /// Network Address Translation destination port.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natDestinationPort", Required = Newtonsoft.Json.Required.Default)]
        public string NatDestinationPort { get; set; }
    
        /// <summary>
        /// Gets or sets natSourceAddress.
        /// Network Address Translation source IP address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natSourceAddress", Required = Newtonsoft.Json.Required.Default)]
        public string NatSourceAddress { get; set; }
    
        /// <summary>
        /// Gets or sets natSourcePort.
        /// Network Address Translation source port.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natSourcePort", Required = Newtonsoft.Json.Required.Default)]
        public string NatSourcePort { get; set; }
    
        /// <summary>
        /// Gets or sets protocol.
        /// Network protocol. Possible values are: unknown, ip, icmp, igmp, ggp, ipv4, tcp, pup, udp, idp, ipv6, ipv6RoutingHeader, ipv6FragmentHeader, ipSecEncapsulatingSecurityPayload, ipSecAuthenticationHeader, icmpV6, ipv6NoNextHeader, ipv6DestinationOptions, nd, raw, ipx, spx, spxII.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protocol", Required = Newtonsoft.Json.Required.Default)]
        public SecurityNetworkProtocol? Protocol { get; set; }
    
        /// <summary>
        /// Gets or sets riskScore.
        /// Provider generated/calculated risk score of the network connection. Recommended value range of 0-1, which equates to a percentage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskScore", Required = Newtonsoft.Json.Required.Default)]
        public string RiskScore { get; set; }
    
        /// <summary>
        /// Gets or sets sourceAddress.
        /// Source (i.e. origin) IP address (of the network connection).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceAddress", Required = Newtonsoft.Json.Required.Default)]
        public string SourceAddress { get; set; }
    
        /// <summary>
        /// Gets or sets sourceLocation.
        /// Location (by IP address mapping) associated with the source of a network connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceLocation", Required = Newtonsoft.Json.Required.Default)]
        public string SourceLocation { get; set; }
    
        /// <summary>
        /// Gets or sets sourcePort.
        /// Source (i.e. origin) IP port (of the network connection).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourcePort", Required = Newtonsoft.Json.Required.Default)]
        public string SourcePort { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Network connection status. Possible values are: unknown, attempted, succeeded, blocked, failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ConnectionStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets urlParameters.
        /// Parameters (suffix) of the destination URL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlParameters", Required = Newtonsoft.Json.Required.Default)]
        public string UrlParameters { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
