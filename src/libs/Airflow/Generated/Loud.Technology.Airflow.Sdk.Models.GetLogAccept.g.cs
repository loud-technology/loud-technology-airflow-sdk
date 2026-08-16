
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Default Value: */*
    /// </summary>
    public enum GetLogAccept
    {
        /// <summary>
        /// 
        /// </summary>
        AnyAny,
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationXNdjson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLogAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLogAccept value)
        {
            return value switch
            {
                GetLogAccept.AnyAny => "*/*",
                GetLogAccept.ApplicationJson => "application/json",
                GetLogAccept.ApplicationXNdjson => "application/x-ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLogAccept? ToEnum(string value)
        {
            return value switch
            {
                "*/*" => GetLogAccept.AnyAny,
                "application/json" => GetLogAccept.ApplicationJson,
                "application/x-ndjson" => GetLogAccept.ApplicationXNdjson,
                _ => null,
            };
        }
    }
}