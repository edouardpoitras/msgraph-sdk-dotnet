﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;

namespace Microsoft.Graph.Models;

public class PlannerAssignment: IAdditionalDataHolder, IBackedModel, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData {
        get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
        set { BackingStore?.Set("additionalData", value); }
    }
    /// <summary>Stores model information.</summary>
    public IBackingStore BackingStore { get; private set; }
    /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? OdataType {
        get { return BackingStore?.Get<string?>("@odata.type"); }
        set { BackingStore?.Set("@odata.type", value); }
    }
#nullable restore
#else
    public string OdataType {
        get { return BackingStore?.Get<string>("@odata.type"); }
        set { BackingStore?.Set("@odata.type", value); }
    }
#endif
    /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? OrderHint {
        get { return BackingStore?.Get<string?>("orderHint"); }
        set { BackingStore?.Set("orderHint", value); }
    }
#nullable restore
#else
    public string OrderHint {
        get { return BackingStore?.Get<string>("orderHint"); }
        set { BackingStore?.Set("orderHint", value); }
    }
#endif
    /// <summary>
    /// Instantiates a new auditActivityInitiator and sets the default values.
    /// </summary>
    public PlannerAssignment() {
        BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
        AdditionalData = new Dictionary<string, object>();
        OdataType = "#microsoft.graph.plannerAssignment";
        OrderHint = "!";
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static PlannerAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new PlannerAssignment();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
        return new Dictionary<string, Action<IParseNode>> {
            {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            {"orderHint", n => { OrderHint = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer) {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("@odata.type", OdataType);
        writer.WriteStringValue("orderHint", OrderHint);
        writer.WriteAdditionalData(AdditionalData);
    }
}
