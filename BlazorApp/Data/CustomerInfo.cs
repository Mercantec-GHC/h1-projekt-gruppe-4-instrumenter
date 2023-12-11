using System.ComponentModel.DataAnnotations;
namespace BlazorApp.Data
{
    public class CustomerInfo
    {
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}