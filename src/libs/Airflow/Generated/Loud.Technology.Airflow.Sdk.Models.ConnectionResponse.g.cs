
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Connection serializer for responses.
    /// </summary>
    public sealed partial class ConnectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conn_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionResponse" /> class.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="connType"></param>
        /// <param name="description"></param>
        /// <param name="host"></param>
        /// <param name="login"></param>
        /// <param name="schema"></param>
        /// <param name="port"></param>
        /// <param name="password"></param>
        /// <param name="extra"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionResponse(
            string connectionId,
            string connType,
            string? description,
            string? host,
            string? login,
            string? schema,
            int? port,
            string? password,
            string? extra)
        {
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.ConnType = connType ?? throw new global::System.ArgumentNullException(nameof(connType));
            this.Description = description;
            this.Host = host;
            this.Login = login;
            this.Schema = schema;
            this.Port = port;
            this.Password = password;
            this.Extra = extra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionResponse" /> class.
        /// </summary>
        public ConnectionResponse()
        {
        }

    }
}