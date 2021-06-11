using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class namechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "AnimalName",
                value: "Fishbait");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "Description",
                value: "Petite lady with minimal body hair seeks human companion. For life. I'm the real deal and I'm looking for a commitment. I've been married before and was left high and dry so if you're just here to play around keep swiping. I like to take things slow. I'm a foodie. I like cats. Dogs too. Kids. Bleh. No kids. They stress me out. Just being honest. Did I mention how honest I am? Well, I am. I'm also a catch. Come catch me.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "AnimalName",
                value: "Hector");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "Description",
                value: "Petite lady with minimal body hair seeks human companion. For life. I'm the real deal and I'm looking for a commitment. I've been married before and was left high and dry so if you're just here to play around keep swiping. I like to take things slow. I'm a foodie. I like cats. Dogs too. Kids. Bleh. No kids. They stress me out. Just being honest. Did I mention how honest I am? Well, I am. I'm also a catch. Come catch me. ");
        }
    }
}
