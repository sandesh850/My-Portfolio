using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(100)", nullable: false),
                    Password = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblPersonal_Project_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "Varchar(100)", nullable: false),
                    ProjectDescription = table.Column<string>(type: "Varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPersonal_Project_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblServices_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    img = table.Column<byte[]>(type: "Varbinary(MAX)", nullable: false),
                    ServiceName = table.Column<string>(type: "Varchar(100)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "Varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblServices_Details", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblLogins");

            migrationBuilder.DropTable(
                name: "TblPersonal_Project_Details");

            migrationBuilder.DropTable(
                name: "TblServices_Details");
        }
    }
}
