using Microsoft.EntityFrameworkCore.Migrations;

namespace IsBasvurusu.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KisiSehir",
                columns: table => new
                {
                    KisilerId = table.Column<int>(type: "int", nullable: false),
                    SehirlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KisiSehir", x => new { x.KisilerId, x.SehirlerId });
                    table.ForeignKey(
                        name: "FK_KisiSehir_Kisiler_KisilerId",
                        column: x => x.KisilerId,
                        principalTable: "Kisiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KisiSehir_Sehirler_SehirlerId",
                        column: x => x.SehirlerId,
                        principalTable: "Sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 18, "Budapeşte" },
                    { 17, "Hamburg" },
                    { 16, "Barcelona" },
                    { 15, "Krakow" },
                    { 14, "Çanakkale" },
                    { 13, "Afyon" },
                    { 12, "Eskişehir" },
                    { 11, "Rize" },
                    { 10, "Trabzon" },
                    { 9, "Elazığ" },
                    { 8, "Antalya" },
                    { 7, "Muğla" },
                    { 6, "Mersin" },
                    { 5, "Gaziantep" },
                    { 4, "İzmir" },
                    { 3, "İstanbul" },
                    { 2, "Ankara" },
                    { 19, "Kahire" },
                    { 20, "Rio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KisiSehir_SehirlerId",
                table: "KisiSehir",
                column: "SehirlerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KisiSehir");

            migrationBuilder.DropTable(
                name: "Kisiler");

            migrationBuilder.DropTable(
                name: "Sehirler");
        }
    }
}
