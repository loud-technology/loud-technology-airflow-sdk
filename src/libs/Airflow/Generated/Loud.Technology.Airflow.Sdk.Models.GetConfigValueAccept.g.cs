
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Default Value: */*
    /// </summary>
    public enum GetConfigValueAccept
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
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigValueAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigValueAccept value)
        {
            return value switch
            {
                GetConfigValueAccept.AnyAny => "*/*",
                GetConfigValueAccept.ApplicationJson => "application/json",
                GetConfigValueAccept.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigValueAccept? ToEnum(string value)
        {
            return value switch
            {
                "*/*" => GetConfigValueAccept.AnyAny,
                "application/json" => GetConfigValueAccept.ApplicationJson,
                "text/plain" => GetConfigValueAccept.TextPlain,
                _ => null,
            };
        }
    }
}