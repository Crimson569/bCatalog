using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UsersActionPermissionsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
