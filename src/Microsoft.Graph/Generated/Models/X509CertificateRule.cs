using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class X509CertificateRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The identifier of the X.509 certificate. Required.</summary>
        public string Identifier {
            get { return BackingStore?.Get<string>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The type of strong authentication mode. The possible values are: x509CertificateSingleFactor, x509CertificateMultiFactor, unknownFutureValue. Required.</summary>
        public Microsoft.Graph.Models.X509CertificateAuthenticationMode? X509CertificateAuthenticationMode {
            get { return BackingStore?.Get<Microsoft.Graph.Models.X509CertificateAuthenticationMode?>("x509CertificateAuthenticationMode"); }
            set { BackingStore?.Set("x509CertificateAuthenticationMode", value); }
        }
        /// <summary>The type of the X.509 certificate mode configuration rule. The possible values are: issuerSubject, policyOID, unknownFutureValue. Required.</summary>
        public Microsoft.Graph.Models.X509CertificateRuleType? X509CertificateRuleType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.X509CertificateRuleType?>("x509CertificateRuleType"); }
            set { BackingStore?.Set("x509CertificateRuleType", value); }
        }
        /// <summary>
        /// Instantiates a new x509CertificateRule and sets the default values.
        /// </summary>
        public X509CertificateRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static X509CertificateRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new X509CertificateRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"x509CertificateAuthenticationMode", n => { X509CertificateAuthenticationMode = n.GetEnumValue<X509CertificateAuthenticationMode>(); } },
                {"x509CertificateRuleType", n => { X509CertificateRuleType = n.GetEnumValue<X509CertificateRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<X509CertificateAuthenticationMode>("x509CertificateAuthenticationMode", X509CertificateAuthenticationMode);
            writer.WriteEnumValue<X509CertificateRuleType>("x509CertificateRuleType", X509CertificateRuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}