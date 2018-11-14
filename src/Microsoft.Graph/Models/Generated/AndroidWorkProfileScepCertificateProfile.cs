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
    /// The type Android Work Profile Scep Certificate Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileScepCertificateProfile : AndroidWorkProfileCertificateProfileBase
    {
    
        /// <summary>
        /// Gets or sets scep server urls.
        /// SCEP Server Url(s)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scepServerUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ScepServerUrls { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format string.
        /// Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectNameFormatString", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets key usage.
        /// SCEP Key Usage
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyUsage", Required = Newtonsoft.Json.Required.Default)]
        public KeyUsages? KeyUsage { get; set; }
    
        /// <summary>
        /// Gets or sets key size.
        /// SCEP Key Size
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keySize", Required = Newtonsoft.Json.Required.Default)]
        public KeySize? KeySize { get; set; }
    
        /// <summary>
        /// Gets or sets hash algorithm.
        /// SCEP Hash Algorithm
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hashAlgorithm", Required = Newtonsoft.Json.Required.Default)]
        public HashAlgorithms? HashAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name format string.
        /// Custom String that defines the AAD Attribute.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameFormatString", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectAlternativeNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets certificate store.
        /// Target store certificate
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateStore", Required = Newtonsoft.Json.Required.Default)]
        public CertificateStore? CertificateStore { get; set; }
    
        /// <summary>
        /// Gets or sets custom subject alternative names.
        /// Custom Subject Alterantive Name Settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customSubjectAlternativeNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CustomSubjectAlternativeName> CustomSubjectAlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name type.
        /// Certificate Subject Alternative Name Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameType", Required = Newtonsoft.Json.Required.Default)]
        public SubjectAlternativeNameType? SubjectAlternativeNameType { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceCertificateStates", Required = Newtonsoft.Json.Required.Default)]
        public IAndroidWorkProfileScepCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesPage ManagedDeviceCertificateStates { get; set; }
    
    }
}

