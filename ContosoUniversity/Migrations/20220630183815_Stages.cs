using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    public partial class Stages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StagiaireID = table.Column<int>(type: "int", nullable: true),
                    BinomeID = table.Column<int>(type: "int", nullable: true),
                    EnseignantID = table.Column<int>(type: "int", nullable: false),
                    EncadrantID = table.Column<int>(type: "int", nullable: true),
                    SignatureValidation = table.Column<int>(type: "int", nullable: false),
                    sujet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageID);
                    table.ForeignKey(
                        name: "FK_Stage_Instructor_EncadrantID",
                        column: x => x.EncadrantID,
                        principalTable: "Instructor",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Stage_Student_BinomeID",
                        column: x => x.BinomeID,
                        principalTable: "Student",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Stage_Student_StagiaireID",
                        column: x => x.StagiaireID,
                        principalTable: "Student",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stage_BinomeID",
                table: "Stage",
                column: "BinomeID");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_EncadrantID",
                table: "Stage",
                column: "EncadrantID");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_StagiaireID",
                table: "Stage",
                column: "StagiaireID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stage");
        }
    }
}
