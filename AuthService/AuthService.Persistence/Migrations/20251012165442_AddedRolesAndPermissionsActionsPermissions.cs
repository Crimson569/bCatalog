using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesAndPermissionsActionsPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("1b9cd590-14b6-4ae8-a41a-af8913010904"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("50f51955-3cac-4f34-8320-f9297717fa5d"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("62537d2e-52bf-45d2-8738-dfadd993783c"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("7fa7a99a-a35c-4600-9aa7-ec01f9098797"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("82f5063e-b1a7-416c-aaf8-8f1990fccc36"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("cdba64f4-36ba-49e6-a068-74c57c2d16c1"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed8b616d-9bba-4495-a472-0fd588719851"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("f0f98a71-fe04-4372-88ea-27a80b3ed0d3"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("6145ce78-b91c-4f48-bcb9-1f6bc4c07f1f"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("c1f0d250-acca-44a2-98cd-08e260dcf780"));

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "Id", "CreatedAt", "PermissionName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("160dba9f-a165-4064-8980-9bfc350d0261"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8442), "DeleteBook", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8442) },
                    { new Guid("1fd34a1f-4677-4df7-aa80-b73eb3eb1fb4"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8460), "CreateRole", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8460) },
                    { new Guid("2e9c5133-9e36-44f8-8b2f-e1963ec3207a"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8450), "GetUsers", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8450) },
                    { new Guid("453a3fd1-5e65-4609-a150-1743975bb1b7"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8464), "GetRoles", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8464) },
                    { new Guid("5aabf6f9-4c24-432e-b395-75a6be33b4f0"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8453), "DeleteUsers", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8453) },
                    { new Guid("60720ce7-bf9a-4b74-b68e-399dbec622d8"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8466), "UpdateRoles", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8466) },
                    { new Guid("7973ae6a-fe37-4389-874e-0ec963015bf7"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8473), "UpdatePermissions", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8473) },
                    { new Guid("7b99fe3e-a58f-4f3a-b117-a35a15ed7d8f"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8367), "ReadBook", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8367) },
                    { new Guid("9369aa9a-bb79-4b3b-9e14-57ce4d7952d2"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8439), "UpdateBook", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8439) },
                    { new Guid("c88ac6ae-0190-4d94-b081-071169a20b9f"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(7215), "PostBook", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(7215) },
                    { new Guid("d45e6052-2206-4f4b-a846-ca0fe6a32bd5"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8470), "CreatePermission", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8470) },
                    { new Guid("dedb6bdf-2c55-4ccc-befc-e62ce0fbedf5"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8471), "GetPermissions", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8471) },
                    { new Guid("dfe6977a-e0b3-4ee5-89d8-c3b0aab43d7a"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8452), "UpdateUsers", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8452) },
                    { new Guid("e5e5a53f-52d5-404a-a98f-c7b9fb441223"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8468), "DeleteRoles", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8468) },
                    { new Guid("e9dac16b-39f0-4dcf-a850-39bbeea7fd09"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8444), "CreateUser", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8444) },
                    { new Guid("f9bcf4e2-f468-4d3a-ba73-95259d697e8a"), new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8475), "DeletePermissions", new DateTime(2025, 10, 12, 16, 54, 41, 727, DateTimeKind.Utc).AddTicks(8475) }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5e40e037-cdbe-4710-bf8d-a6f69ebba65e"), new DateTime(2025, 10, 12, 16, 54, 41, 730, DateTimeKind.Utc).AddTicks(393), "Reader", new DateTime(2025, 10, 12, 16, 54, 41, 730, DateTimeKind.Utc).AddTicks(393) },
                    { new Guid("ac4a6ca0-8aee-4603-8e72-a5c30c1f6b32"), new DateTime(2025, 10, 12, 16, 54, 41, 730, DateTimeKind.Utc).AddTicks(237), "Admin", new DateTime(2025, 10, 12, 16, 54, 41, 730, DateTimeKind.Utc).AddTicks(237) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("160dba9f-a165-4064-8980-9bfc350d0261"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("1fd34a1f-4677-4df7-aa80-b73eb3eb1fb4"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e9c5133-9e36-44f8-8b2f-e1963ec3207a"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("453a3fd1-5e65-4609-a150-1743975bb1b7"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("5aabf6f9-4c24-432e-b395-75a6be33b4f0"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("60720ce7-bf9a-4b74-b68e-399dbec622d8"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("7973ae6a-fe37-4389-874e-0ec963015bf7"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("7b99fe3e-a58f-4f3a-b117-a35a15ed7d8f"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("9369aa9a-bb79-4b3b-9e14-57ce4d7952d2"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("c88ac6ae-0190-4d94-b081-071169a20b9f"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("d45e6052-2206-4f4b-a846-ca0fe6a32bd5"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("dedb6bdf-2c55-4ccc-befc-e62ce0fbedf5"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("dfe6977a-e0b3-4ee5-89d8-c3b0aab43d7a"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("e5e5a53f-52d5-404a-a98f-c7b9fb441223"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("e9dac16b-39f0-4dcf-a850-39bbeea7fd09"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("f9bcf4e2-f468-4d3a-ba73-95259d697e8a"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("5e40e037-cdbe-4710-bf8d-a6f69ebba65e"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("ac4a6ca0-8aee-4603-8e72-a5c30c1f6b32"));

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "Id", "CreatedAt", "PermissionName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b9cd590-14b6-4ae8-a41a-af8913010904"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(2949), "ReadBook", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(2949) },
                    { new Guid("50f51955-3cac-4f34-8320-f9297717fa5d"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3026), "CreateUser", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3026) },
                    { new Guid("62537d2e-52bf-45d2-8738-dfadd993783c"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(1889), "PostBook", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(1889) },
                    { new Guid("7fa7a99a-a35c-4600-9aa7-ec01f9098797"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3100), "DeleteUsers", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3100) },
                    { new Guid("82f5063e-b1a7-416c-aaf8-8f1990fccc36"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3021), "UpdateBook", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3021) },
                    { new Guid("cdba64f4-36ba-49e6-a068-74c57c2d16c1"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3024), "DeleteBook", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3024) },
                    { new Guid("ed8b616d-9bba-4495-a472-0fd588719851"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3098), "UpdateUsers", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3098) },
                    { new Guid("f0f98a71-fe04-4372-88ea-27a80b3ed0d3"), new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3095), "GetUsers", new DateTime(2025, 10, 9, 15, 43, 31, 66, DateTimeKind.Utc).AddTicks(3095) }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6145ce78-b91c-4f48-bcb9-1f6bc4c07f1f"), new DateTime(2025, 10, 9, 15, 43, 31, 68, DateTimeKind.Utc).AddTicks(4505), "Admin", new DateTime(2025, 10, 9, 15, 43, 31, 68, DateTimeKind.Utc).AddTicks(4505) },
                    { new Guid("c1f0d250-acca-44a2-98cd-08e260dcf780"), new DateTime(2025, 10, 9, 15, 43, 31, 68, DateTimeKind.Utc).AddTicks(4585), "Reader", new DateTime(2025, 10, 9, 15, 43, 31, 68, DateTimeKind.Utc).AddTicks(4585) }
                });
        }
    }
}
