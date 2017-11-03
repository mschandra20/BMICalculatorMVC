using System.ComponentModel.DataAnnotations;

namespace BMIcalculater.Models
{
    public class BMIForm
    {
        public string Name { get; set; }

        [Required]
        public int FeetHeight { get; set; }

        [Required]
        public int InchHeight { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public double Weight { get; set; }

        public string BMI { get; set; } 


    }
}