using Microsoft.AspNetCore.Mvc;

namespace crud_products.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    [HttpPost]
    public String CreateProduct()
    {
        return "Product created";
    }
    
}