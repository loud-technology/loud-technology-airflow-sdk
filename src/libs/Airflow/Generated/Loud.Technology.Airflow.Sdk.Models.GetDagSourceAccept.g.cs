
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Default Value: */*
    /// </summary>
    public enum GetDagSourceAccept
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
    public static class GetDagSourceAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDagSourceAccept value)
        {
            return value switch
            {
                GetDagSourceAccept.AnyAny => "*/*",
                GetDagSourceAccept.ApplicationJson => "application/json",
                GetDagSourceAccept.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDagSourceAccept? ToEnum(string value)
        {
            return value switch
            {
                "*/*" => GetDagSourceAccept.AnyAny,
                "application/json" => GetDagSourceAccept.ApplicationJson,
                "text/plain" => GetDagSourceAccept.TextPlain,
                _ => null,
            };
        }
    }
}