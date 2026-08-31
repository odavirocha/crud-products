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
    
    public ProductEntity CreateProduct(ProductDTO product)
    {
        ProductEntity productEntity = new ProductEntity { Name = product.Name, Qntd = product.Qntd};

        if (_context.Products.Any(p => p.Name == product.Name)) {
            throw new Exception("Product already exists");
        }
        
        _context.Products.Add(productEntity);
        _context.SaveChanges();
        return productEntity;
    }
    
}