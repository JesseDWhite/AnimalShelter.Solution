using System.ComponentModel.DataAnotations;

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
    public int Age { get; set; }

    [Required]
    public string Description { get; set; }
  }
}