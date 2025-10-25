using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RoleConfigurationErrorFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("30a9dd81-84ce-481e-9c54-5b2d3d89c626"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("983e2c1f-5dd9-42fb-899f-ad6fab48a831"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("cd07830b-75fd-4a13-8cac-f23006b95d96"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("d548b93f-d2a2-46f5-af90-ba51429e2e75"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("723e0026-7add-4adf-bb66-a97ce406d9d6"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("e66d5c22-8d2c-4a8a-a773-46df66ce6c4c"));

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "Id", "CreatedAt", "PermissionName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1236fa18-0a82-4185-adc2-6fdf5f6596a2"), new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(1809), "ReadBook", new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(1809) },
                    { new Guid("9a378d7a-3aae-495a-91da-ce6e9f3644a8"), new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(1903), "UpdateBook", new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(1903) },
                    { new Guid("db8c6617-8ce7-40ab-9894-769038cf65a6"), new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(677), "PostBook", new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(677) },
                    { new Guid("ed14b72b-fa5a-41e7-8fa8-2a8783486b64"), new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(1906), "DeleteBook", new DateTime(2025, 10, 8, 14, 54, 56, 511, DateTimeKind.Utc).AddTicks(1906) }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1cf281d9-f144-48ac-8b57-73876816522b"), new DateTime(2025, 10, 8, 14, 54, 56, 513, DateTimeKind.Utc).AddTicks(5856), "Reader", new DateTime(2025, 10, 8, 14, 54, 56, 513, DateTimeKind.Utc).AddTicks(5856) },
                    { new Guid("a1fd0ebe-0cfe-4dfb-8d2d-395e0b431e0a"), new DateTime(2025, 10, 8, 14, 54, 56, 513, DateTimeKind.Utc).AddTicks(5763), "Admin", new DateTime(2025, 10, 8, 14, 54, 56, 513, DateTimeKind.Utc).AddTicks(5763) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionEntity_PermissionId",
                table: "RolePermissionEntity",
                column: "PermissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissionEntity_permissions_PermissionId",
                table: "RolePermissionEntity",
                column: "PermissionId",
                principalTable: "permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissionEntity_roles_RoleId",
                table: "RolePermissionEntity",
                column: "RoleId",
                principalTable: "roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissionEntity_permissions_PermissionId",
                table: "RolePermissionEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissionEntity_roles_RoleId",
                table: "RolePermissionEntity");

            migrationBuilder.DropIndex(
                name: "IX_RolePermissionEntity_PermissionId",
                table: "RolePermissionEntity");

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("1236fa18-0a82-4185-adc2-6fdf5f6596a2"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("9a378d7a-3aae-495a-91da-ce6e9f3644a8"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("db8c6617-8ce7-40ab-9894-769038cf65a6"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed14b72b-fa5a-41e7-8fa8-2a8783486b64"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("1cf281d9-f144-48ac-8b57-73876816522b"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("a1fd0ebe-0cfe-4dfb-8d2d-395e0b431e0a"));

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    PermissionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    RolesId = table.Column<Guid>(type: "uuid", nullable: false),
                    Permissions = table.Column<string[]>(type: "text[]", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.PermissionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "Id", "CreatedAt", "PermissionName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("30a9dd81-84ce-481e-9c54-5b2d3d89c626"), new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(7908), "PostBook", new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(7908) },
                    { new Guid("983e2c1f-5dd9-42fb-899f-ad6fab48a831"), new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(9090), "ReadBook", new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(9090) },
                    { new Guid("cd07830b-75fd-4a13-8cac-f23006b95d96"), new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(9229), "DeleteBook", new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(9229) },
                    { new Guid("d548b93f-d2a2-46f5-af90-ba51429e2e75"), new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(9227), "UpdateBook", new DateTime(2025, 10, 8, 14, 44, 48, 113, DateTimeKind.Utc).AddTicks(9227) }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("723e0026-7add-4adf-bb66-a97ce406d9d6"), new DateTime(2025, 10, 8, 14, 44, 48, 116, DateTimeKind.Utc).AddTicks(7185), "Reader", new DateTime(2025, 10, 8, 14, 44, 48, 116, DateTimeKind.Utc).AddTicks(7185) },
                    { new Guid("e66d5c22-8d2c-4a8a-a773-46df66ce6c4c"), new DateTime(2025, 10, 8, 14, 44, 48, 116, DateTimeKind.Utc).AddTicks(7067), "Admin", new DateTime(2025, 10, 8, 14, 44, 48, 116, DateTimeKind.Utc).AddTicks(7067) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RolesId",
                table: "RolePermissions",
                column: "RolesId");
        }
    }
}
