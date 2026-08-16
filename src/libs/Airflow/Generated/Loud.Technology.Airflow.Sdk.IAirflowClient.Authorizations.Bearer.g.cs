
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IAirflowClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}