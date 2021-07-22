// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type CallRequestBuilder.
    /// </summary>
    public partial class CallRequestBuilder : EntityRequestBuilder, ICallRequestBuilder
    {

        /// <summary>
        /// Constructs a new CallRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CallRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ICallRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ICallRequest Request(IEnumerable<Option> options)
        {
            return new CallRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="ICallOperationsCollectionRequestBuilder"/>.</returns>
        public ICallOperationsCollectionRequestBuilder Operations
        {
            get
            {
                return new CallOperationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("operations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Participants.
        /// </summary>
        /// <returns>The <see cref="ICallParticipantsCollectionRequestBuilder"/>.</returns>
        public ICallParticipantsCollectionRequestBuilder Participants
        {
            get
            {
                return new CallParticipantsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("participants"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for CallRedirect.
        /// </summary>
        /// <returns>The <see cref="ICallRedirectRequestBuilder"/>.</returns>
        public ICallRedirectRequestBuilder Redirect(
            IEnumerable<InvitationParticipantInfo> targets,
            Int32? timeout = null,
            string callbackUri = null)
        {
            return new CallRedirectRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.redirect"),
                this.Client,
                targets,
                timeout,
                callbackUri);
        }

        /// <summary>
        /// Gets the request builder for CallAnswer.
        /// </summary>
        /// <returns>The <see cref="ICallAnswerRequestBuilder"/>.</returns>
        public ICallAnswerRequestBuilder Answer(
            string callbackUri,
            MediaConfig mediaConfig,
            IEnumerable<Modality> acceptedModalities = null,
            Int32? participantCapacity = null)
        {
            return new CallAnswerRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.answer"),
                this.Client,
                callbackUri,
                mediaConfig,
                acceptedModalities,
                participantCapacity);
        }

        /// <summary>
        /// Gets the request builder for CallCancelMediaProcessing.
        /// </summary>
        /// <returns>The <see cref="ICallCancelMediaProcessingRequestBuilder"/>.</returns>
        public ICallCancelMediaProcessingRequestBuilder CancelMediaProcessing(
            string clientContext = null)
        {
            return new CallCancelMediaProcessingRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cancelMediaProcessing"),
                this.Client,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for CallChangeScreenSharingRole.
        /// </summary>
        /// <returns>The <see cref="ICallChangeScreenSharingRoleRequestBuilder"/>.</returns>
        public ICallChangeScreenSharingRoleRequestBuilder ChangeScreenSharingRole(
            ScreenSharingRole role)
        {
            return new CallChangeScreenSharingRoleRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.changeScreenSharingRole"),
                this.Client,
                role);
        }

        /// <summary>
        /// Gets the request builder for CallKeepAlive.
        /// </summary>
        /// <returns>The <see cref="ICallKeepAliveRequestBuilder"/>.</returns>
        public ICallKeepAliveRequestBuilder KeepAlive()
        {
            return new CallKeepAliveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.keepAlive"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for CallMute.
        /// </summary>
        /// <returns>The <see cref="ICallMuteRequestBuilder"/>.</returns>
        public ICallMuteRequestBuilder Mute(
            string clientContext = null)
        {
            return new CallMuteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.mute"),
                this.Client,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for CallPlayPrompt.
        /// </summary>
        /// <returns>The <see cref="ICallPlayPromptRequestBuilder"/>.</returns>
        public ICallPlayPromptRequestBuilder PlayPrompt(
            IEnumerable<Prompt> prompts,
            string clientContext = null)
        {
            return new CallPlayPromptRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.playPrompt"),
                this.Client,
                prompts,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for CallRecordResponse.
        /// </summary>
        /// <returns>The <see cref="ICallRecordResponseRequestBuilder"/>.</returns>
        public ICallRecordResponseRequestBuilder RecordResponse(
            IEnumerable<Prompt> prompts = null,
            bool? bargeInAllowed = null,
            Int32? initialSilenceTimeoutInSeconds = null,
            Int32? maxSilenceTimeoutInSeconds = null,
            Int32? maxRecordDurationInSeconds = null,
            bool? playBeep = null,
            IEnumerable<string> stopTones = null,
            string clientContext = null)
        {
            return new CallRecordResponseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.recordResponse"),
                this.Client,
                prompts,
                bargeInAllowed,
                initialSilenceTimeoutInSeconds,
                maxSilenceTimeoutInSeconds,
                maxRecordDurationInSeconds,
                playBeep,
                stopTones,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for CallReject.
        /// </summary>
        /// <returns>The <see cref="ICallRejectRequestBuilder"/>.</returns>
        public ICallRejectRequestBuilder Reject(
            RejectReason? reason = null,
            string callbackUri = null)
        {
            return new CallRejectRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reject"),
                this.Client,
                reason,
                callbackUri);
        }

        /// <summary>
        /// Gets the request builder for CallSubscribeToTone.
        /// </summary>
        /// <returns>The <see cref="ICallSubscribeToToneRequestBuilder"/>.</returns>
        public ICallSubscribeToToneRequestBuilder SubscribeToTone(
            string clientContext = null)
        {
            return new CallSubscribeToToneRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.subscribeToTone"),
                this.Client,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for CallTransfer.
        /// </summary>
        /// <returns>The <see cref="ICallTransferRequestBuilder"/>.</returns>
        public ICallTransferRequestBuilder Transfer(
            InvitationParticipantInfo transferTarget)
        {
            return new CallTransferRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.transfer"),
                this.Client,
                transferTarget);
        }

        /// <summary>
        /// Gets the request builder for CallUnmute.
        /// </summary>
        /// <returns>The <see cref="ICallUnmuteRequestBuilder"/>.</returns>
        public ICallUnmuteRequestBuilder Unmute(
            string clientContext = null)
        {
            return new CallUnmuteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unmute"),
                this.Client,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for CallUpdateRecordingStatus.
        /// </summary>
        /// <returns>The <see cref="ICallUpdateRecordingStatusRequestBuilder"/>.</returns>
        public ICallUpdateRecordingStatusRequestBuilder UpdateRecordingStatus(
            RecordingStatus status,
            string clientContext = null)
        {
            return new CallUpdateRecordingStatusRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateRecordingStatus"),
                this.Client,
                status,
                clientContext);
        }
    
    }
}
