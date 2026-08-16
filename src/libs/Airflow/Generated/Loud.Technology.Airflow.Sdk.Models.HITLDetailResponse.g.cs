
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Response of updating a Human-in-the-loop detail.
    /// </summary>
    public sealed partial class HITLDetailResponse
    {
        /// <summary>
        /// Schema for a Human-in-the-loop users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responded_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.HITLUser RespondedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responded_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RespondedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chosen_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ChosenOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params_input")]
        public object? ParamsInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HITLDetailResponse" /> class.
        /// </summary>
        /// <param name="respondedBy">
        /// Schema for a Human-in-the-loop users.
        /// </param>
        /// <param name="respondedAt"></param>
        /// <param name="chosenOptions"></param>
        /// <param name="paramsInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HITLDetailResponse(
            global::Loud.Technology.Airflow.Sdk.HITLUser respondedBy,
            global::System.DateTime respondedAt,
            global::System.Collections.Generic.IList<string> chosenOptions,
            object? paramsInput)
        {
            this.RespondedBy = respondedBy ?? throw new global::System.ArgumentNullException(nameof(respondedBy));
            this.RespondedAt = respondedAt;
            this.ChosenOptions = chosenOptions ?? throw new global::System.ArgumentNullException(nameof(chosenOptions));
            this.ParamsInput = paramsInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HITLDetailResponse" /> class.
        /// </summary>
        public HITLDetailResponse()
        {
        }

    }
}