using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTemplate.Entities.Demo
{
    [Table("eba_categories")]
    public class Category : EntityBase
    {
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
