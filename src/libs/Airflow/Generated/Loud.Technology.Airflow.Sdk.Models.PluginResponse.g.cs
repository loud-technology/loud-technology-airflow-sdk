
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Plugin serializer.
    /// </summary>
    public sealed partial class PluginResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("macros")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Macros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flask_blueprints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FlaskBlueprints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fastapi_apps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.FastAPIAppResponse> FastapiApps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fastapi_root_middlewares")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.FastAPIRootMiddlewareResponse> FastapiRootMiddlewares { get; set; }

        /// <summary>
        /// Aggregate all external views. Both 'external_views' and 'appbuilder_menu_items' are included here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ExternalViewResponse> ExternalViews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("react_apps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ReactAppResponse> ReactApps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appbuilder_views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AppBuilderViewResponse> AppbuilderViews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appbuilder_menu_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AppBuilderMenuItemResponse> AppbuilderMenuItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_operator_extra_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> GlobalOperatorExtraLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator_extra_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OperatorExtraLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listeners")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Listeners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timetables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Timetables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="macros"></param>
        /// <param name="flaskBlueprints"></param>
        /// <param name="fastapiApps"></param>
        /// <param name="fastapiRootMiddlewares"></param>
        /// <param name="externalViews">
        /// Aggregate all external views. Both 'external_views' and 'appbuilder_menu_items' are included here.
        /// </param>
        /// <param name="reactApps"></param>
        /// <param name="appbuilderViews"></param>
        /// <param name="appbuilderMenuItems"></param>
        /// <param name="globalOperatorExtraLinks"></param>
        /// <param name="operatorExtraLinks"></param>
        /// <param name="source"></param>
        /// <param name="listeners"></param>
        /// <param name="timetables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PluginResponse(
            string name,
            global::System.Collections.Generic.IList<string> macros,
            global::System.Collections.Generic.IList<string> flaskBlueprints,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.FastAPIAppResponse> fastapiApps,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.FastAPIRootMiddlewareResponse> fastapiRootMiddlewares,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ExternalViewResponse> externalViews,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ReactAppResponse> reactApps,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AppBuilderViewResponse> appbuilderViews,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AppBuilderMenuItemResponse> appbuilderMenuItems,
            global::System.Collections.Generic.IList<string> globalOperatorExtraLinks,
            global::System.Collections.Generic.IList<string> operatorExtraLinks,
            string source,
            global::System.Collections.Generic.IList<string> listeners,
            global::System.Collections.Generic.IList<string> timetables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Macros = macros ?? throw new global::System.ArgumentNullException(nameof(macros));
            this.FlaskBlueprints = flaskBlueprints ?? throw new global::System.ArgumentNullException(nameof(flaskBlueprints));
            this.FastapiApps = fastapiApps ?? throw new global::System.ArgumentNullException(nameof(fastapiApps));
            this.FastapiRootMiddlewares = fastapiRootMiddlewares ?? throw new global::System.ArgumentNullException(nameof(fastapiRootMiddlewares));
            this.ExternalViews = externalViews ?? throw new global::System.ArgumentNullException(nameof(externalViews));
            this.ReactApps = reactApps ?? throw new global::System.ArgumentNullException(nameof(reactApps));
            this.AppbuilderViews = appbuilderViews ?? throw new global::System.ArgumentNullException(nameof(appbuilderViews));
            this.AppbuilderMenuItems = appbuilderMenuItems ?? throw new global::System.ArgumentNullException(nameof(appbuilderMenuItems));
            this.GlobalOperatorExtraLinks = globalOperatorExtraLinks ?? throw new global::System.ArgumentNullException(nameof(globalOperatorExtraLinks));
            this.OperatorExtraLinks = operatorExtraLinks ?? throw new global::System.ArgumentNullException(nameof(operatorExtraLinks));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Listeners = listeners ?? throw new global::System.ArgumentNullException(nameof(listeners));
            this.Timetables = timetables ?? throw new global::System.ArgumentNullException(nameof(timetables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginResponse" /> class.
        /// </summary>
        public PluginResponse()
        {
        }

    }
}