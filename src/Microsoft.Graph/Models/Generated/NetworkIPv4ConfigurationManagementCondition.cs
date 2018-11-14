// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Network IPv4Configuration Management Condition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class NetworkIPv4ConfigurationManagementCondition : NetworkManagementCondition
    {
    
        /// <summary>
        /// Gets or sets ip v4prefix.
        /// The IPv4 subnet to be connected to. e.g. 10.0.0.0/8
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipV4Prefix", Required = Newtonsoft.Json.Required.Default)]
        public string IpV4Prefix { get; set; }
    
        /// <summary>
        /// Gets or sets ip v4gateway.
        /// The IPv4 gateway address. e.g. 10.0.0.0
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipV4Gateway", Required = Newtonsoft.Json.Required.Default)]
        public string IpV4Gateway { get; set; }
    
        /// <summary>
        /// Gets or sets ip v4dhcpserver.
        /// The IPv4 address of the DHCP server for the adapter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipV4DHCPServer", Required = Newtonsoft.Json.Required.Default)]
        public string IpV4DHCPServer { get; set; }
    
        /// <summary>
        /// Gets or sets ip v4dnsserver list.
        /// The IPv4 DNS servers configured for the adapter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipV4DNSServerList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> IpV4DNSServerList { get; set; }
    
        /// <summary>
        /// Gets or sets dns suffix list.
        /// Valid DNS suffixes for the current network. e.g. seattle.contoso.com
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsSuffixList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DnsSuffixList { get; set; }
    
    }
}

