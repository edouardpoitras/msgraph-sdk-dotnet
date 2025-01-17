using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CustomSecurityAttributeDefinition : Entity, IParsable {
        /// <summary>The allowedValues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AllowedValue>? AllowedValues {
            get { return BackingStore?.Get<List<AllowedValue>?>("allowedValues"); }
            set { BackingStore?.Set("allowedValues", value); }
        }
#nullable restore
#else
        public List<AllowedValue> AllowedValues {
            get { return BackingStore?.Get<List<AllowedValue>>("allowedValues"); }
            set { BackingStore?.Set("allowedValues", value); }
        }
#endif
        /// <summary>The attributeSet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttributeSet {
            get { return BackingStore?.Get<string?>("attributeSet"); }
            set { BackingStore?.Set("attributeSet", value); }
        }
#nullable restore
#else
        public string AttributeSet {
            get { return BackingStore?.Get<string>("attributeSet"); }
            set { BackingStore?.Set("attributeSet", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The isCollection property</summary>
        public bool? IsCollection {
            get { return BackingStore?.Get<bool?>("isCollection"); }
            set { BackingStore?.Set("isCollection", value); }
        }
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable {
            get { return BackingStore?.Get<bool?>("isSearchable"); }
            set { BackingStore?.Set("isSearchable", value); }
        }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>The usePreDefinedValuesOnly property</summary>
        public bool? UsePreDefinedValuesOnly {
            get { return BackingStore?.Get<bool?>("usePreDefinedValuesOnly"); }
            set { BackingStore?.Set("usePreDefinedValuesOnly", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomSecurityAttributeDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomSecurityAttributeDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedValues", n => { AllowedValues = n.GetCollectionOfObjectValues<AllowedValue>(AllowedValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attributeSet", n => { AttributeSet = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isCollection", n => { IsCollection = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"usePreDefinedValuesOnly", n => { UsePreDefinedValuesOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AllowedValue>("allowedValues", AllowedValues);
            writer.WriteStringValue("attributeSet", AttributeSet);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isCollection", IsCollection);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteBoolValue("usePreDefinedValuesOnly", UsePreDefinedValuesOnly);
        }
    }
}
