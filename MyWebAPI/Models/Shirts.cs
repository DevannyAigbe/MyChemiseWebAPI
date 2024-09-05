using System.ComponentModel.DataAnnotations;

namespace MyChemiseWebAPI.Models
{
    public class Shirts
    {

        public int ShirtId { get; set; }
        [Required]
        public string? Brand { get; set; }

        [Required]
        public string? Color { get; set; }

        public int Size { get; set; }

        [Required]
        public string? gender { get; set; }

        public double? Price { get; set; }
    }
}
