using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {

    }

    public DbSet<Animal> Animals { get; set; }
    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Animal>()
    //   .HasData(
    //     new Animal
    //     {
    //       AnimalName = "Beans",
    //       AnimalType = "Cat",
    //       Age = "15",
    //       Description = "Beans is a wonderful cat full of love and affection. His previous owners had to give him up after they "
    //     }
    //   );
    // }
  }
}