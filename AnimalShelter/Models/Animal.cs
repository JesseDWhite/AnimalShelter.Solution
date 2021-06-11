using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    [Required]
    [Display(Name = "Animal Name")]
    public string AnimalName { get; set; }

    [Required]
    [Display(Name = "Type of Animal")]
    public string AnimalType { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    [Range(1, 100, ErrorMessage = "Age must be from 1 to 100.")]
    public int Age { get; set; }

    [Required]
    public string Description { get; set; }
  }
}