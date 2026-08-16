#nullable enable

namespace Loud.Technology.Airflow.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class TaskInstanceStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Loud.Technology.Airflow.Sdk.TaskInstanceState>
    {
        /// <inheritdoc />
        public override global::Loud.Technology.Airflow.Sdk.TaskInstanceState Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Loud.Technology.Airflow.Sdk.TaskInstanceStateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Loud.Technology.Airflow.Sdk.TaskInstanceState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Loud.Technology.Airflow.Sdk.TaskInstanceState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Loud.Technology.Airflow.Sdk.TaskInstanceState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Loud.Technology.Airflow.Sdk.TaskInstanceStateExtensions.ToValueString(value));
        }
    }
}
