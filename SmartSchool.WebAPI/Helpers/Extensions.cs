using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SmartSchool.WebAPI.Helpers
{
    public static class Extensions
    {
        public static void AddPagnation(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var pagnationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            response.Headers.Add("Pagination", JsonConvert.SerializeObject(pagnationHeader, camelCaseFormatter));
            response.Headers.Add("Access-Control-Expose-Header","Pagination");
            

        }
    }
}