using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    fName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    IQLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "Age", "Department", "Email", "IQLevel", "fName", "lName" },
                values: new object[,]
                {
                    { 1, 27, 1, "Mustafa@gmail.com", "Super intelligent", "Mustafa", "Abdo" },
                    { 2, 25, 4, "Ahmed@gmail.com", "Super intelligent", "Ahmed", "Ali" },
                    { 3, 30, 0, "Sara@gmail.com", "Super intelligent", "Sara", "Mohamed" },
                    { 4, 28, 2, "Fatima@gmail.com", "Super intelligent", "Fatima", "Hassan" },
                    { 5, 26, 3, "Khaled@gmail.com", "Super intelligent", "Khaled", "Ahmed" },
                    { 6, 29, 1, "Laila@gmail.com", "Super intelligent", "Laila", "Omar" },
                    { 7, 24, 1, "Youssef@gmail.com", "Super intelligent", "Youssef", "Kareem" },
                    { 8, 31, 0, "Nour@gmail.com", "Super intelligent", "Nour", "Ahmed" },
                    { 9, 27, 3, "Ali@gmail.com", "Super intelligent", "Ali", "Sara" },
                    { 10, 32, 2, "Hala@gmail.com", "Super intelligent", "Hala", "Mohamed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
