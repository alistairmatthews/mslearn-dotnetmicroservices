using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductInfoController : ControllerBase
    {
        private static readonly ProductInfo[] TheMenu = new[]
        {
            new ProductInfo { ProductName = ".NET Blue Hoodie", Description = "Good quality, cotton hoodie with the .NET text of the back.", Cost = 12, InStock = "yes"},
            new ProductInfo { ProductName = ".NET Bot Black Hoodie", Description = "Good quality, cotton hoodie with the .NET mascot on the front", Cost = 19, InStock = "no"},
            new ProductInfo { ProductName = ".NET Foundation T-Shirt", Description = "Purple cotton tee with the .NET Foundation logo", Cost = 12, InStock = "yes"},
            new ProductInfo { ProductName = ".NET Black & White Mug", Description = "White mug in enamelled metal with the .NET logo", Cost = 8, InStock = "yes"},
            new ProductInfo { ProductName = ".NET Foundation Pin", Description = "Purple badge with the .NET Foundation logo", Cost = 12, InStock = "no"},
            new ProductInfo { ProductName = "Kudu Purple Hoodie", Description = "Purple, zipped hoodie with the Kudu logo on the front.", Cost = 8, InStock = "yes"}
        };

        private readonly ILogger<ProductInfoController> _logger;

        public ProductInfoController(ILogger<ProductInfoController> logger)
        {
            _logger = logger;
        }

         [HttpGet]
         public IEnumerable<ProductInfo> Get()
         {
             return TheMenu;
         }
    }
}
