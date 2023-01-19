using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTemplate.Entities.Demo
{
    [Table("eba_products")]
    public class Product : EntityBase
    {
        public Nullable<DateTime> PublishDate { get; set; }

        [Required]
        public bool IsDraft { get; set; } = true;

        [Required]
        public int AccountId { get; set; }

        [Required]
        public string DocumentPath { get; set; }

        [Required]
        public decimal DocumentSize { get; set; }

        [Required]
        public string DocumentType { get; set; }

        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
