using crud_products.Data;
using crud_products.DTOs;
using crud_products.Entity;
using crud_products.Exceptions;

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
            throw new AlreadyExists("Product already exists");
        }
        
        _context.Products.Add(productEntity);
        _context.SaveChanges();
        return productEntity;
    }

    public List<ProductEntity> GetProducts()
    {
        return _context.Products.ToList();
    }

    public ProductEntity GetProduct(int id)
    {
        return _context.Products.Find(id);
    }
    
}