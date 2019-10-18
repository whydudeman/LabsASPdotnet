using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -5, "Tobey Maguire", new DateTime(2002, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superhero, Drama, Sci-FI", "Spider-man", "http://www.gstatic.com/tv/thumb/v22vodart/29821/p29821_v_v8_ae.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -6, "Rober Dawney Jr", new DateTime(2008, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superhero,Drama,Sci-FI, Fantasy, Action", "Iron man", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4mi0mHK2Yz9yXZ4poPAc0mRmVe8KtPfrhjXPOQL1dEw6C4qIZaA&s" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -5);
        }
    }
}
