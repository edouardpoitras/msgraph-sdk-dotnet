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
    /// The type Recognize Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RecognizeOperation : CommsOperation
    {
    
        /// <summary>
        /// Gets or sets prompts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prompts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Prompt> Prompts { get; set; }
    
        /// <summary>
        /// Gets or sets barge in allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bargeInAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? BargeInAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets culture.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "culture", Required = Newtonsoft.Json.Required.Default)]
        public string Culture { get; set; }
    
        /// <summary>
        /// Gets or sets initial silence timeout in seconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initialSilenceTimeoutInSeconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InitialSilenceTimeoutInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets inter digit timeout in seconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interDigitTimeoutInSeconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InterDigitTimeoutInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets choices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "choices", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RecognitionOption> Choices { get; set; }
    
        /// <summary>
        /// Gets or sets collect digits.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "collectDigits", Required = Newtonsoft.Json.Required.Default)]
        public CollectDigits CollectDigits { get; set; }
    
    }
}

