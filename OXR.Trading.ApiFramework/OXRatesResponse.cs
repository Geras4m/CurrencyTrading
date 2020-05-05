using System.Collections.Generic;
using System.Net;

namespace OXR.Trading.ApiFramework
{
    internal class OXRatesResponse<TModel> : IOXRatesResponse<TModel>
    {
        public HttpStatusCode StatusCode { get; internal set; }

        public TModel Data { get; internal set; }
    }
}
