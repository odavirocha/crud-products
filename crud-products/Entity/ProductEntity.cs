using System.ComponentModel.DataAnnotations.Schema;

namespace crud_products.Entity;

[Table("products")]
public class ProductEntity
{
    [Column("id")]
    public int Id { get; private set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("qntd")]
    public int Qntd { get; set; }
}