using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UserAvatarColumnMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserAvatar",
                table: "users",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "permissions",
                columns: new[] { "Id", "CreatedAt", "PermissionName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("020429ef-f6da-4305-b584-e617be6fd06c"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7050), "UpdateUsers", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7050) },
                    { new Guid("27459897-3657-4c49-84a1-f25036b9c4dc"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7035), "UpdateBook", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7035) },
                    { new Guid("5c2fb2f3-24f9-40d5-9d6b-e4be28fd2597"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(5586), "PostBook", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(5586) },
                    { new Guid("757d7b85-118c-4d96-9805-2fc45510091d"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7074), "DeleteRoles", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7074) },
                    { new Guid("8350b2a2-5373-44db-8335-0b08f9c18372"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7037), "DeleteBook", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7037) },
                    { new Guid("89ca2c60-2775-4e24-a200-8bab4d43b82f"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7073), "UpdateRoles", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7073) },
                    { new Guid("8e14c1b5-73a5-43e5-8d4b-73d3a2ea0696"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7048), "GetUsers", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7048) },
                    { new Guid("8fd2c754-b3e8-4a71-a41f-efa5403154da"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7079), "UpdatePermissions", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7079) },
                    { new Guid("a862da45-010e-4378-95fb-9ad88d9dafd7"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7077), "GetPermissions", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7077) },
                    { new Guid("b060d2bb-22ef-4340-8676-d591704dbc30"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7071), "GetRoles", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7071) },
                    { new Guid("c02aa34c-8b38-401d-ada4-81f4694de773"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7076), "CreatePermission", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7076) },
                    { new Guid("d979c4e8-9507-4988-9142-6b50997f2a48"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7083), "DeletePermissions", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7083) },
                    { new Guid("e282232c-d7e6-4c94-b3d5-a524cb0734d8"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7066), "DeleteUsers", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7066) },
                    { new Guid("e5685cef-72f1-4350-9fc3-37491f1f329c"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7068), "CreateRole", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7068) },
                    { new Guid("f0918e6e-1227-448e-91e1-3cab2570d53b"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7039), "CreateUser", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(7039) },
                    { new Guid("f23de730-ef0d-4324-a870-e17d66199171"), new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(6904), "ReadBook", new DateTime(2025, 10, 16, 13, 24, 11, 523, DateTimeKind.Utc).AddTicks(6904) }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("500f596c-77c2-4218-aebd-fbc98e02182e"), new DateTime(2025, 10, 16, 13, 24, 11, 526, DateTimeKind.Utc).AddTicks(1304), "Reader", new DateTime(2025, 10, 16, 13, 24, 11, 526, DateTimeKind.Utc).AddTicks(1304) },
                    { new Guid("6d1653ea-87c2-49a7-b05d-5b83f8d3171a"), new DateTime(2025, 10, 16, 13, 24, 11, 526, DateTimeKind.Utc).AddTicks(1214), "Admin", new DateTime(2025, 10, 16, 13, 24, 11, 526, DateTimeKind.Utc).AddTicks(1214) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("020429ef-f6da-4305-b584-e617be6fd06c"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("27459897-3657-4c49-84a1-f25036b9c4dc"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c2fb2f3-24f9-40d5-9d6b-e4be28fd2597"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("757d7b85-118c-4d96-9805-2fc45510091d"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("8350b2a2-5373-44db-8335-0b08f9c18372"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("89ca2c60-2775-4e24-a200-8bab4d43b82f"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("8e14c1b5-73a5-43e5-8d4b-73d3a2ea0696"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("8fd2c754-b3e8-4a71-a41f-efa5403154da"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("a862da45-010e-4378-95fb-9ad88d9dafd7"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("b060d2bb-22ef-4340-8676-d591704dbc30"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("c02aa34c-8b38-401d-ada4-81f4694de773"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("d979c4e8-9507-4988-9142-6b50997f2a48"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("e282232c-d7e6-4c94-b3d5-a524cb0734d8"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("e5685cef-72f1-4350-9fc3-37491f1f329c"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("f0918e6e-1227-448e-91e1-3cab2570d53b"));

            migrationBuilder.DeleteData(
                table: "permissions",
                keyColumn: "Id",
                keyValue: new Guid("f23de730-ef0d-4324-a870-e17d66199171"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("500f596c-77c2-4218-aebd-fbc98e02182e"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("6d1653ea-87c2-49a7-b05d-5b83f8d3171a"));

            migrationBuilder.DropColumn(
                name: "UserAvatar",
                table: "users");

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
    }
}
