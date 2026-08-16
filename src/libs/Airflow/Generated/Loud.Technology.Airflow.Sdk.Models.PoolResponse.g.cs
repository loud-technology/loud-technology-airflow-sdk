
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Pool serializer for responses.
    /// </summary>
    public sealed partial class PoolResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Slots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_deferred")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeDeferred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occupied_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OccupiedSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunningSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueuedSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScheduledSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deferred_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeferredSlots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slots"></param>
        /// <param name="includeDeferred"></param>
        /// <param name="occupiedSlots"></param>
        /// <param name="runningSlots"></param>
        /// <param name="queuedSlots"></param>
        /// <param name="scheduledSlots"></param>
        /// <param name="openSlots"></param>
        /// <param name="deferredSlots"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PoolResponse(
            string name,
            int slots,
            bool includeDeferred,
            int occupiedSlots,
            int runningSlots,
            int queuedSlots,
            int scheduledSlots,
            int openSlots,
            int deferredSlots,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slots = slots;
            this.Description = description;
            this.IncludeDeferred = includeDeferred;
            this.OccupiedSlots = occupiedSlots;
            this.RunningSlots = runningSlots;
            this.QueuedSlots = queuedSlots;
            this.ScheduledSlots = scheduledSlots;
            this.OpenSlots = openSlots;
            this.DeferredSlots = deferredSlots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolResponse" /> class.
        /// </summary>
        public PoolResponse()
        {
        }

    }
}