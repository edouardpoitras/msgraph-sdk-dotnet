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
    /// The type Dep Enrollment Base Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DepEnrollmentBaseProfile : EnrollmentProfile
    {
    
		///<summary>
		/// The internal DepEnrollmentBaseProfile constructor
		///</summary>
        protected internal DepEnrollmentBaseProfile()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets is default.
        /// Indicates if this is the default profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets supervised mode enabled.
        /// Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/en-us/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supervisedModeEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SupervisedModeEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets support department.
        /// Support department information
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportDepartment", Required = Newtonsoft.Json.Required.Default)]
        public string SupportDepartment { get; set; }
    
        /// <summary>
        /// Gets or sets pass code disabled.
        /// Indicates if Passcode setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passCodeDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? PassCodeDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets is mandatory.
        /// Indicates if the profile is mandatory
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMandatory", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMandatory { get; set; }
    
        /// <summary>
        /// Gets or sets location disabled.
        /// Indicates if Location service setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locationDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? LocationDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets support phone number.
        /// Support phone number
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportPhoneNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SupportPhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets profile removal disabled.
        /// Indicates if the profile removal option is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileRemovalDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ProfileRemovalDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets restore blocked.
        /// Indicates if Restore setup pane is blocked
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restoreBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? RestoreBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets apple id disabled.
        /// Indicates if Apple id setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleIdDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppleIdDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets terms and conditions disabled.
        /// Indicates if 'Terms and Conditions' setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsAndConditionsDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? TermsAndConditionsDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets touch id disabled.
        /// Indicates if touch id setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "touchIdDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? TouchIdDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets apple pay disabled.
        /// Indicates if Apple pay setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applePayDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ApplePayDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets zoom disabled.
        /// Indicates if zoom setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "zoomDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ZoomDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets siri disabled.
        /// Indicates if siri setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siriDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SiriDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets diagnostics disabled.
        /// Indicates if diagnostics setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "diagnosticsDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DiagnosticsDisabled { get; set; }
    
    }
}

