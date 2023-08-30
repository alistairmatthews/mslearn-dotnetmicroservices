using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace frontend
{
   public class ProductClient
   {
      private readonly JsonSerializerOptions options = new JsonSerializerOptions()
      {
         PropertyNameCaseInsensitive = true,
         PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
      };

      private readonly HttpClient client;
      private readonly ILogger<ProductClient> _logger;

      public ProductClient(HttpClient client, ILogger<ProductClient> logger)
      {
         this.client = client;
         this._logger = logger;
      }

      public async Task<ProductInfo[]> GetProductsAsync()
      {
         try {
            var responseMessage = await this.client.GetAsync("/productinfo");
            
            if(responseMessage!=null)
            {
               var stream = await responseMessage.Content.ReadAsStreamAsync();
               return await JsonSerializer.DeserializeAsync<ProductInfo[]>(stream, options);
            }
         }
         catch(HttpRequestException ex)
         {
            _logger.LogError(ex.Message);
            throw;
         }
         return new ProductInfo[] {};

      }
   }
}
