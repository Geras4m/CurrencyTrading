using System.Collections.Generic;
using System.Net;

namespace OXR.Trading.ApiFramework
{
    public interface IOXRatesResponse<TModel>
    {
        HttpStatusCode StatusCode { get; }
        TModel Data { get; }
    }
}
