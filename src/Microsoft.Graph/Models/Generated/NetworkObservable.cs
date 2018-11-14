// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type NetworkObservable.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class NetworkObservable
    {

        /// <summary>
        /// Gets or sets destinatioIPv6.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinatioIPv6", Required = Newtonsoft.Json.Required.Default)]
        public string DestinatioIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets destinationAsn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationAsn", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DestinationAsn { get; set; }
    
        /// <summary>
        /// Gets or sets destinationCidrBlock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationCidrBlock", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets destinationIPv4.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationIPv4", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets destinationPort.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationPort", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationPort { get; set; }
    
        /// <summary>
        /// Gets or sets dnsDomainName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsDomainName", Required = Newtonsoft.Json.Required.Default)]
        public string DnsDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets dnsDomainLookupDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsDomainLookupDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DnsDomainLookupDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets dnsRegistrantEmail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsRegistrantEmail", Required = Newtonsoft.Json.Required.Default)]
        public string DnsRegistrantEmail { get; set; }
    
        /// <summary>
        /// Gets or sets dnsRegistrantName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsRegistrantName", Required = Newtonsoft.Json.Required.Default)]
        public string DnsRegistrantName { get; set; }
    
        /// <summary>
        /// Gets or sets nameServer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nameServer", Required = Newtonsoft.Json.Required.Default)]
        public string NameServer { get; set; }
    
        /// <summary>
        /// Gets or sets protocol.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protocol", Required = Newtonsoft.Json.Required.Default)]
        public SecurityNetworkProtocol? Protocol { get; set; }
    
        /// <summary>
        /// Gets or sets sourceAsn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceAsn", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SourceAsn { get; set; }
    
        /// <summary>
        /// Gets or sets sourceCidrBlock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceCidrBlock", Required = Newtonsoft.Json.Required.Default)]
        public string SourceCidrBlock { get; set; }
    
        /// <summary>
        /// Gets or sets sourceIPv4.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceIPv4", Required = Newtonsoft.Json.Required.Default)]
        public string SourceIPv4 { get; set; }
    
        /// <summary>
        /// Gets or sets sourceIPv6.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceIPv6", Required = Newtonsoft.Json.Required.Default)]
        public string SourceIPv6 { get; set; }
    
        /// <summary>
        /// Gets or sets sourcePort.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourcePort", Required = Newtonsoft.Json.Required.Default)]
        public string SourcePort { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url", Required = Newtonsoft.Json.Required.Default)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets userAgent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAgent", Required = Newtonsoft.Json.Required.Default)]
        public string UserAgent { get; set; }
    
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
