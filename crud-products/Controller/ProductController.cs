using crud_products.DTOs;
using crud_products.Entity;
using crud_products.Service;
using Microsoft.AspNetCore.Mvc;

namespace crud_products.Controller;

[ApiController]
[Route("products")]
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

    [HttpGet]
    public IActionResult GetProducts()
    {
        List<ProductEntity> productEntities = _productService.GetProducts();
        return Ok(productEntities);
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        ProductEntity productEntity = _productService.GetProduct(id);
        return Ok(productEntity);
    }
    
}