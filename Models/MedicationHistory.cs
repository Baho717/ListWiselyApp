using System.ComponentModel.DataAnnotations;


namespace ListWiselyApp.Models
{
    public class MedicationHistory
    {
        [Key] 
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        public string? Name { get; set; }
        [Required]
        [Range(1, 100000)]
        public int Dosage { get; set; }
        [Required(ErrorMessage = "Brand of Medication Required (Example: Generic, Brand-name)")]
        public string? Brand { get; set; }
        [Required(ErrorMessage = "Form of Medication Required (Example: Chewable Tablet, Lozenges, Etc.)")]
        public string? Form { get; set; }
        [Required]
        [Range(1, 10000)]
        public int MedicationAmount { get; set; }
        [Required(ErrorMessage = "Price of Medication Required")]
    }
}