using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jalgrattaeksam.Migrations
{
    /// <inheritdoc />
    public partial class addedEksam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eksam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Koha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Eksamineerija = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eksam", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eksam");
        }
    }
}
