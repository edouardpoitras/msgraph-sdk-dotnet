using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Users.Item.Onenote.Notebooks.GetRecentNotebooksWithIncludePersonalNotebooks {
    /// <summary>
    /// Provides operations to call the getRecentNotebooks method.
    /// </summary>
    public class GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="includePersonalNotebooks">Usage: includePersonalNotebooks={includePersonalNotebooks}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, bool? includePersonalNotebooks = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/onenote/notebooks/microsoft.graph.getRecentNotebooks(includePersonalNotebooks={includePersonalNotebooks}){?%24top,%24skip,%24search,%24filter,%24count}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("includePersonalNotebooks", includePersonalNotebooks);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user%2Did}/onenote/notebooks/microsoft.graph.getRecentNotebooks(includePersonalNotebooks={includePersonalNotebooks}){?%24top,%24skip,%24search,%24filter,%24count}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getRecentNotebooks
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateGetRequestInformation(Action<GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getRecentNotebooks
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<GetRecentNotebooksWithIncludePersonalNotebooksResponse> GetAsync(Action<GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetRecentNotebooksWithIncludePersonalNotebooksResponse>(requestInfo, GetRecentNotebooksWithIncludePersonalNotebooksResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getRecentNotebooks
        /// </summary>
        public class GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
            /// <summary>Search items by search phrases</summary>
            [QueryParameter("%24search")]
            public string Search { get; set; }
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new getRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}