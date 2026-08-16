
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Schema for updating the content of a Human-in-the-loop detail.
    /// </summary>
    public sealed partial class UpdateHITLDetailPayload
    {
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
        /// Initializes a new instance of the <see cref="UpdateHITLDetailPayload" /> class.
        /// </summary>
        /// <param name="chosenOptions"></param>
        /// <param name="paramsInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateHITLDetailPayload(
            global::System.Collections.Generic.IList<string> chosenOptions,
            object? paramsInput)
        {
            this.ChosenOptions = chosenOptions ?? throw new global::System.ArgumentNullException(nameof(chosenOptions));
            this.ParamsInput = paramsInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHITLDetailPayload" /> class.
        /// </summary>
        public UpdateHITLDetailPayload()
        {
        }

    }
}