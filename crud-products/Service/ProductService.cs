using crud_products.Data;
using crud_products.DTOs;
using crud_products.Entity;

namespace crud_products.Service;


public class ProductService
{
    
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }
    
    public DefaultResponseDTO CreateProduct(ProductDTO product)
    {
        
        ProductEntity productEntity = new ProductEntity { Name = product.Name, Qntd = product.Qntd};
        
        _context.Products.Add(productEntity);
        _context.SaveChanges();
        return new  DefaultResponseDTO("Product Created" + productEntity.Id);
    }
    
}