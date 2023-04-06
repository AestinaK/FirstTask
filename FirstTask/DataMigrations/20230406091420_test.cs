using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstTask.DataMigrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_hello",
                table: "hello");

            migrationBuilder.RenameTable(
                name: "hello",
                newName: "Hellos");

            migrationBuilder.RenameColumn(
                name: "time",
                table: "Hellos",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "place",
                table: "Hellos",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Hellos",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Hellos",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Hellos",
                newName: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hellos",
                table: "Hellos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hellos",
                table: "Hellos");

            migrationBuilder.RenameTable(
                name: "Hellos",
                newName: "hello");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "hello",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "hello",
                newName: "place");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "hello",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "hello",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "hello",
                newName: "email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hello",
                table: "hello",
                column: "Id");
        }
    }
}
