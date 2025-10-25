using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_users_UserEmail",
                table: "users",
                column: "UserEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_UserName",
                table: "users",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_roles_RoleName",
                table: "roles",
                column: "RoleName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_users_UserEmail",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserName",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_roles_RoleName",
                table: "roles");
        }
    }
}
