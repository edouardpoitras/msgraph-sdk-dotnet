namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum CallState {
        Incoming,
        Establishing,
        Established,
        Hold,
        Transferring,
        TransferAccepted,
        Redirecting,
        Terminating,
        Terminated,
        UnknownFutureValue,
    }
}