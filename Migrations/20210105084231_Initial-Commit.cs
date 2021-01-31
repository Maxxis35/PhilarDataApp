using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhilarDataApp.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfThe = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConcertVenue = table.Column<string>(type: "TEXT", nullable: true),
                    Soloist = table.Column<string>(type: "TEXT", nullable: true),
                    Conductor = table.Column<string>(type: "TEXT", nullable: true),
                    Performer = table.Column<string>(type: "TEXT", nullable: true),
                    MusicalCompositions = table.Column<string>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    CountCameras = table.Column<int>(type: "INTEGER", nullable: false),
                    Sound = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "ConcertVenue", "Conductor", "CountCameras", "DateOfThe", "MusicalCompositions", "Note", "Performer", "Soloist", "Sound", "Title" },
                values: new object[] { 1, "САТ им. П.Ойунского", "Ф. Мастранджело", 2, new DateTime(2012, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Симфонический оркестр", "", "", "Концерт – премьера симфонического оркестра филармонии Якутии" });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "ConcertVenue", "Conductor", "CountCameras", "DateOfThe", "MusicalCompositions", "Note", "Performer", "Soloist", "Sound", "Title" },
                values: new object[] { 2, "ДДН им. А. Кулаковского", "Ф. Мастранджело", 2, new DateTime(2012, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Симфонический оркестр", "Иван Почекин", "", "Концерт – проект большого симфонического оркестра филармонии Якутии" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concerts");
        }
    }
}
