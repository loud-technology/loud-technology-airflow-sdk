
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// TimeDelta can be used to interact with datetime.timedelta objects.
    /// </summary>
    public sealed partial class TimeDelta
    {
        /// <summary>
        /// Default Value: TimeDelta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microseconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Microseconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDelta" /> class.
        /// </summary>
        /// <param name="days"></param>
        /// <param name="seconds"></param>
        /// <param name="microseconds"></param>
        /// <param name="type">
        /// Default Value: TimeDelta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeDelta(
            int days,
            int seconds,
            int microseconds,
            string? type)
        {
            this.Type = type;
            this.Days = days;
            this.Seconds = seconds;
            this.Microseconds = microseconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDelta" /> class.
        /// </summary>
        public TimeDelta()
        {
        }

    }
}