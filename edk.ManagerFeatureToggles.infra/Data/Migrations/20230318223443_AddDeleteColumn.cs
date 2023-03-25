using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace edk.ManagerFeatureToggles.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddDeleteColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ValueSelect",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ValueOptions",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "UserGroups",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Tenants",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Systems",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "FeatureToggles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Enviroments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "AccessSystem",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ValueSelect");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ValueOptions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "UserGroups");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Systems");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "FeatureToggles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Enviroments");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "AccessSystem");
        }
    }
}
