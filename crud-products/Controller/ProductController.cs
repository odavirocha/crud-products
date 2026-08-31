using crud_products.DTOs;
using crud_products.Entity;
using crud_products.Service;
using Microsoft.AspNetCore.Mvc;

namespace crud_products.Controller;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }
    
    [HttpPost]
    public IActionResult CreateProduct([FromBody] ProductDTO product)
    {
        ProductEntity productEntity = _productService.CreateProduct(product);
        return Created("Produto criado com sucesso!", productEntity);
    }
    
}