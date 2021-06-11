using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {

    }

    public DbSet<Animal> Animals { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal
        {
          AnimalName = "Beans",
          AnimalType = "Cat",
          Gender = "Female",
          Age = "15",
          Description = "Total gossip queen. Claims to hate drama but secretly loves stirring the pot. Posts no makeup selfies, abuses the word literally, and dreams of landing her own reality show on Bravo. Her favorite Kardashian is Khloé, obviously."
        },
        new Animal
        {
          AnimalName = "Hector",
          AnimalType = "Cat",
          Gender = "Male",
          Age = "3",
          Description = "Is admittedly not very good in front of the camera. Enjoys spoiling Game of Thrones for people who didn't read the books. Has spent much of his adult life living with his mom. Trolls your blog."
        },
        new Animal
        {
          AnimalName = "Jasper",
          AnimalType = "Dog",
          Gender = "Male",
          Age = "7",
          Description = "Doesn't trust the government. Believes in UFOs. Has a sneaking suspicion the mailman is spying on him, which is why he tells his friends to hand deliver any and all messages between the hours of midnight and 3 a.m. Has quite possibly spiraled back into his meth addiction."
        },
        new Animal
        {
          AnimalName = "Chloe",
          AnimalType = "Dog",
          Gender = "Female",
          Age = "1",
          Description = "No kids but still goes all out for the holidays. Enjoys DIY crafts and finding inspirational quotes on Pinterest. Guilty pleasures include Marie Callender's microwavable meals and binge-watching Scandal on Netflix."
        },
          new Animal
          {
            AnimalName = "Cheesecake",
            AnimalType = "Cat",
            Gender = "Female",
            Age = "6",
            Description = "I see you. I might not literally see you but I SEE You. With my heart and my soul. Thing is. My eyes can't see but who needs sight when you have my heart and soul? Sight is over rated. I like long walks on the beach...but the neighborhood at your house will do just fine. I ain't picky. I like all sorts of people. Like I said. I ain't picky. I like cat friends but if it were just you and me,baby,life would still be good. I'm 42 in cat years. That's 6 in human years. Yes. I'm quite skilled in arithmetic. I'm actually a member of MENSA. Do you like smart, romantic gals? If you do look no further. Let's grab a cocktail and have a quick make out sesh under the stars."
          },
          new Animal
          {
            AnimalName = "Buster Scrubs",
            AnimalType = "Dog",
            Gender = "Female",
            Age = "10",
            Description = "Introverted home body seeking introverted home body. The outside world can be scary. I prefer the comfort of home where I can sit and write tele novela's and do laundry in peace and quiet. I like romantic cuddle sessions on the sofa and enjoy snacking on meatballs. A human partner who enjoys couches and meatballs is preferred. Dog parks and hikes are too chaotic for me. I like my house. Did I mention that I like being home? Well I do. Do you have a home? If you do I would like to be your life partner."
          },
          new Animal
          {
            AnimalName = "Canned Corn",
            AnimalType = "Cat",
            Gender = "Female",
            Age = "12",
            Description = "Petite lady with minimal body hair seeks human companion. For life. I'm the real deal and I'm looking for a commitment. I've been married before and was left high and dry so if you're just here to play around keep swiping. I like to take things slow. I'm a foodie. I like cats. Dogs too. Kids. Bleh. No kids. They stress me out. Just being honest. Did I mention how honest I am? Well, I am. I'm also a catch. Come catch me. "
          }
      );
    }
  }
}