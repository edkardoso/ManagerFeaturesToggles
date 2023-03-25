using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace edk.ManagerFeatureToggles.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddTenantToFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "FeatureToggles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FeatureToggles_TenantId",
                table: "FeatureToggles",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureToggles_Tenants_TenantId",
                table: "FeatureToggles",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureToggles_Tenants_TenantId",
                table: "FeatureToggles");

            migrationBuilder.DropIndex(
                name: "IX_FeatureToggles_TenantId",
                table: "FeatureToggles");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "FeatureToggles");
        }
    }
}
