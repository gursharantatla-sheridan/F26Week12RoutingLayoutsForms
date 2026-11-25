using System.ComponentModel.DataAnnotations;

namespace F26Week12RoutingLayoutsForms.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is a required field")]
        public string? Name { get; set; }

        [Range(0.01, 10000, ErrorMessage = "Price must be more than 0 and less than 10000")]
        public double Price { get; set; }
    }
}
