using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Razorr3_10266464.Pages.Empleados
{
    /// <inheritdoc />
    public partial class AgregarTiposEmpleados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AplicacionesCreadas",
                table: "Empleado",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BugsReparados",
                table: "Empleado",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Empleado",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FacturasCreadas",
                table: "Empleado",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegistrosCreados",
                table: "Empleado",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AplicacionesCreadas",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "BugsReparados",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "FacturasCreadas",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "RegistrosCreados",
                table: "Empleado");
        }
    }
}
