using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nc_recordshop_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TrackList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "Description", "Genre", "Name", "Quantity", "ReleaseDate", "TrackList" },
                values: new object[,]
                {
                    { 1, "Pink Floyd", "The eigth albumn by Pink Floyd, it's a concept album exploring themes of conflict, greed, time", "Progressive Rock", "The Dark Side of the Moon", 3, new DateOnly(1973, 3, 1), "[\"Speak To Me\",\"Breathe\",\"On The Run\",\"Time\",\"The Great Gig In The Sky\",\"Money\",\"Us And Them\",\"Any Colour You Like\",\"Brain Damage\",\"Eclipse\"]" },
                    { 2, "Michael Jackson", "One of the best selling albums of all time", "Dance-pop", "Bad", 0, new DateOnly(1987, 8, 31), "[\"I Just Can\\u0027t Stop Loving You\",\"Bad\",\"The Way You Make Me Feel\",\"Man in the Mirror\",\"Dirty Diana\",\"Another Part of Me\",\"Smooth Criminal\",\"Leave Me Alone\",\"Liberian Girl\"]" },
                    { 3, "Adele", "Named after Adele's age during it's production", "Pop", "21", 17, new DateOnly(2011, 1, 24), "[\"Rolling in the Deep\",\"Someone like You\",\"Set Fire to the Rain\",\"Rumour Has It\",\"Turning Tables\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
