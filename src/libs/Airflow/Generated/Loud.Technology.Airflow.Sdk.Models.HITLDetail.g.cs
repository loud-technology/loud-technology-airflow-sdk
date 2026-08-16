
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Schema for Human-in-the-loop detail.
    /// </summary>
    public sealed partial class HITLDetail
    {
        /// <summary>
        /// TaskInstance serializer for responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_instance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.TaskInstanceResponse TaskInstance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::System.Collections.Generic.IList<string>? Defaults { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiple")]
        public bool? Multiple { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_users")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.HITLUser>? AssignedUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responded_by_user")]
        public global::Loud.Technology.Airflow.Sdk.HITLUser? RespondedByUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responded_at")]
        public global::System.DateTime? RespondedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chosen_options")]
        public global::System.Collections.Generic.IList<string>? ChosenOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params_input")]
        public object? ParamsInput { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_received")]
        public bool? ResponseReceived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HITLDetail" /> class.
        /// </summary>
        /// <param name="taskInstance">
        /// TaskInstance serializer for responses.
        /// </param>
        /// <param name="options"></param>
        /// <param name="subject"></param>
        /// <param name="createdAt"></param>
        /// <param name="body"></param>
        /// <param name="defaults"></param>
        /// <param name="multiple">
        /// Default Value: false
        /// </param>
        /// <param name="params"></param>
        /// <param name="assignedUsers"></param>
        /// <param name="respondedByUser"></param>
        /// <param name="respondedAt"></param>
        /// <param name="chosenOptions"></param>
        /// <param name="paramsInput"></param>
        /// <param name="responseReceived">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HITLDetail(
            global::Loud.Technology.Airflow.Sdk.TaskInstanceResponse taskInstance,
            global::System.Collections.Generic.IList<string> options,
            string subject,
            global::System.DateTime createdAt,
            string? body,
            global::System.Collections.Generic.IList<string>? defaults,
            bool? multiple,
            object? @params,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.HITLUser>? assignedUsers,
            global::Loud.Technology.Airflow.Sdk.HITLUser? respondedByUser,
            global::System.DateTime? respondedAt,
            global::System.Collections.Generic.IList<string>? chosenOptions,
            object? paramsInput,
            bool? responseReceived)
        {
            this.TaskInstance = taskInstance ?? throw new global::System.ArgumentNullException(nameof(taskInstance));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Body = body;
            this.Defaults = defaults;
            this.Multiple = multiple;
            this.Params = @params;
            this.AssignedUsers = assignedUsers;
            this.CreatedAt = createdAt;
            this.RespondedByUser = respondedByUser;
            this.RespondedAt = respondedAt;
            this.ChosenOptions = chosenOptions;
            this.ParamsInput = paramsInput;
            this.ResponseReceived = responseReceived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HITLDetail" /> class.
        /// </summary>
        public HITLDetail()
        {
        }

    }
}