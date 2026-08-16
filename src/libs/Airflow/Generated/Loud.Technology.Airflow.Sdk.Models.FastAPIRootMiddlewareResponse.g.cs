
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Serializer for Plugin FastAPI root middleware responses.
    /// </summary>
    public sealed partial class FastAPIRootMiddlewareResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middleware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Middleware { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FastAPIRootMiddlewareResponse" /> class.
        /// </summary>
        /// <param name="middleware"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FastAPIRootMiddlewareResponse(
            string middleware,
            string name)
        {
            this.Middleware = middleware ?? throw new global::System.ArgumentNullException(nameof(middleware));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FastAPIRootMiddlewareResponse" /> class.
        /// </summary>
        public FastAPIRootMiddlewareResponse()
        {
        }

    }
}