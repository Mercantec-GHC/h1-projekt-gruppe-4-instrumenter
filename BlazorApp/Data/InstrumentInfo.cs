using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class InstrumentInfo
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type of Instrument is required")]
        public string TypeInstrument { get; set; }

        [Required(ErrorMessage = "Condition is required")]
        public string Condition { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int? Year { get; set; }


        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Material is required")]
        public string Material { get; set; }
        public byte[] Photo { get; set; }
    }
}
