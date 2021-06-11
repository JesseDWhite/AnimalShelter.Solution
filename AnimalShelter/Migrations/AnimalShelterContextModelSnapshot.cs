﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AnimalName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AnimalType")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 15,
                            AnimalName = "Beans",
                            AnimalType = "Cat",
                            Description = "Total gossip queen. Claims to hate drama but secretly loves stirring the pot. Posts no makeup selfies, abuses the word literally, and dreams of landing her own reality show on Bravo. Her favorite Kardashian is Khloé, obviously.",
                            Gender = "Female"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 3,
                            AnimalName = "Fishbait",
                            AnimalType = "Cat",
                            Description = "Is admittedly not very good in front of the camera. Enjoys spoiling Game of Thrones for people who didn't read the books. Has spent much of his adult life living with his mom. Trolls your blog.",
                            Gender = "Male"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 7,
                            AnimalName = "Jasper",
                            AnimalType = "Dog",
                            Description = "Doesn't trust the government. Believes in UFOs. Has a sneaking suspicion the mailman is spying on him, which is why he tells his friends to hand deliver any and all messages between the hours of midnight and 3 a.m. Has quite possibly spiraled back into his meth addiction.",
                            Gender = "Male"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 1,
                            AnimalName = "Chloe",
                            AnimalType = "Dog",
                            Description = "No kids but still goes all out for the holidays. Enjoys DIY crafts and finding inspirational quotes on Pinterest. Guilty pleasures include Marie Callender's microwavable meals and binge-watching Scandal on Netflix.",
                            Gender = "Female"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 6,
                            AnimalName = "Cheesecake",
                            AnimalType = "Cat",
                            Description = "I see you. I might not literally see you but I SEE You. With my heart and my soul. Thing is. My eyes can't see but who needs sight when you have my heart and soul? Sight is over rated. I like long walks on the beach...but the neighborhood at your house will do just fine. I ain't picky. I like all sorts of people. Like I said. I ain't picky. I like cat friends but if it were just you and me,baby,life would still be good. I'm 42 in cat years. That's 6 in human years. Yes. I'm quite skilled in arithmetic. I'm actually a member of MENSA. Do you like smart, romantic gals? If you do look no further. Let's grab a cocktail and have a quick make out sesh under the stars.",
                            Gender = "Female"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 10,
                            AnimalName = "Buster Scrubs",
                            AnimalType = "Dog",
                            Description = "Introverted home body seeking introverted home body. The outside world can be scary. I prefer the comfort of home where I can sit and write tele novela's and do laundry in peace and quiet. I like romantic cuddle sessions on the sofa and enjoy snacking on meatballs. A human partner who enjoys couches and meatballs is preferred. Dog parks and hikes are too chaotic for me. I like my house. Did I mention that I like being home? Well I do. Do you have a home? If you do I would like to be your life partner.",
                            Gender = "Female"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 12,
                            AnimalName = "Canned Corn",
                            AnimalType = "Cat",
                            Description = "Petite lady with minimal body hair seeks human companion. For life. I'm the real deal and I'm looking for a commitment. I've been married before and was left high and dry so if you're just here to play around keep swiping. I like to take things slow. I'm a foodie. I like cats. Dogs too. Kids. Bleh. No kids. They stress me out. Just being honest. Did I mention how honest I am? Well, I am. I'm also a catch. Come catch me.",
                            Gender = "Female"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
