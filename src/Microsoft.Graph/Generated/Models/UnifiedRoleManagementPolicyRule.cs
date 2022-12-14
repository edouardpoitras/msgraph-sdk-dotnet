using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Provides operations to manage the appCatalogs singleton.
    /// </summary>
    public class UnifiedRoleManagementPolicyRule : Entity, IParsable {
        /// <summary>Defines details of scope that&apos;s targeted by role management policy rule. The details can include the principal type, the role assignment type, and actions affecting a role. Supports $filter (eq, ne).</summary>
        public UnifiedRoleManagementPolicyRuleTarget Target {
            get { return BackingStore?.Get<UnifiedRoleManagementPolicyRuleTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicyRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.unifiedRoleManagementPolicyApprovalRule" => new UnifiedRoleManagementPolicyApprovalRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyAuthenticationContextRule" => new UnifiedRoleManagementPolicyAuthenticationContextRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyEnablementRule" => new UnifiedRoleManagementPolicyEnablementRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule" => new UnifiedRoleManagementPolicyExpirationRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule" => new UnifiedRoleManagementPolicyNotificationRule(),
                _ => new UnifiedRoleManagementPolicyRule(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"target", n => { Target = n.GetObjectValue<UnifiedRoleManagementPolicyRuleTarget>(UnifiedRoleManagementPolicyRuleTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UnifiedRoleManagementPolicyRuleTarget>("target", Target);
        }
    }
}