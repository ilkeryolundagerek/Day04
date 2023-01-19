using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTemplate.Entities
{
    public abstract class EntityBase
    {
        //Key: SQL tarafında primary key, Ef tarafında ise entity key olarak anılır. Tekildir, bütün datada/tabloda aynı anahtardan başka bir olamaz. int olarak ayarlanırsa her yeni kayıtta bir arttırarak kullanılır.
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public bool Deleted { get; set; }

        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;//Varsayılan değer.
        public Nullable<DateTime> UpdateDate { get; set; }
        public Nullable<DateTime> DeleteDate { get; set; }
    }
}
