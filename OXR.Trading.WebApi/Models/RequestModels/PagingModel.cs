using Newtonsoft.Json;

namespace OXR.Trading.WebApi.Models.RequestModels
{
    public class PagingModel
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; } = 1;

        [JsonProperty("pageSize")]
        public int PageSize { get; set; } = 3;
    }
}
