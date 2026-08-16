
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Default Value: */*
    /// </summary>
    public enum GetConfigAccept
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
    public static class GetConfigAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigAccept value)
        {
            return value switch
            {
                GetConfigAccept.AnyAny => "*/*",
                GetConfigAccept.ApplicationJson => "application/json",
                GetConfigAccept.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigAccept? ToEnum(string value)
        {
            return value switch
            {
                "*/*" => GetConfigAccept.AnyAny,
                "application/json" => GetConfigAccept.ApplicationJson,
                "text/plain" => GetConfigAccept.TextPlain,
                _ => null,
            };
        }
    }
}