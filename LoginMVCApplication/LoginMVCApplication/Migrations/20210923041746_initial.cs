using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginMVCApplication.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    EmailID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.EmailID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EmailID", "Password" },
                values: new object[] { "demogmail.com", "demo" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EmailID", "Password" },
                values: new object[] { "chandru@gmail.com", "chandru2598" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
