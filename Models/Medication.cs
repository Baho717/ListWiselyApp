using System.ComponentModel.DataAnnotations;

namespace ListWiselyApp.Models
{
    public class Medication
    {

        [Key]
        public int Id { get; set; }
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
        [Required(ErrorMessage = "Interactions of Medication Required")]
        public string? DrugInteractions { get; set; }
        [Required(ErrorMessage = "Drug information of Medication Required")]
        public string? DrugInformation { get; set; }
        [Required]
        [Range(1, 10000)]
        public int MedicationAmount { get; set; }
        [Required(ErrorMessage = "Price of Medication Required")]
        public double Price { get; set; }

    }
}