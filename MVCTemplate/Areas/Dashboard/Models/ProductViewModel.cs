using System.ComponentModel.DataAnnotations;

namespace MVCTemplate.Areas.Dashboard.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required, Display(Name = "Product Name: ", Prompt = "Product Name: "), MinLength(10), MaxLength(150)]
        public string Name { get; set; }

        [Required, DataType(DataType.MultilineText), Display(Name = "Product Detail: ", Prompt = "Product Detail: "), MinLength(10), MaxLength(1000)]
        public string Description { get; set; }

        [Required, Display(Name = "Category Name: ", Prompt = "Category Name: ")]
        public int CategoryId { get; set; }

        public bool Active { get; set; }

        [Required, Display(Name = "Brand Name: ", Prompt = "Brand Name: ")]
        public int BrandId { get; set; }

        public DateTime CreateDate { get; set; }

        [Required, DataType(DataType.Upload), Display(Name = "Featured Image: ", Prompt = "Featured Image: ")]
        public string FeaturedImage { get; set; }
    }
}
