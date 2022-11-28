using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "b0c4f0bc-cfb8-4688-b2c0-a8dded00ee22", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "1c3b5441-263a-4e25-8a22-347a0654704d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "01efb7f3-6b4f-4a8c-9721-211e943de3a6", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEFh4GXsqYozdDrTs15dLBmYiXrL8dNaYAs9LP5dGB+qhYCuKDRz5wwpyIIv3Ab6J/w==", null, false, "91c1123f-a939-4a04-ae9b-c0da08865384", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 16, 19, 2, 804, DateTimeKind.Local).AddTicks(8221), new DateTime(2022, 11, 28, 16, 19, 2, 807, DateTimeKind.Local).AddTicks(2423), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 16, 19, 2, 807, DateTimeKind.Local).AddTicks(5738), new DateTime(2022, 11, 28, 16, 19, 2, 807, DateTimeKind.Local).AddTicks(5750), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 16, 19, 2, 810, DateTimeKind.Local).AddTicks(7101), new DateTime(2022, 11, 28, 16, 19, 2, 810, DateTimeKind.Local).AddTicks(7134), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 16, 19, 2, 810, DateTimeKind.Local).AddTicks(7140), new DateTime(2022, 11, 28, 16, 19, 2, 810, DateTimeKind.Local).AddTicks(7142), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3696), new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3708), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3713), new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3715), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3717), new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3719), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3721), new DateTime(2022, 11, 28, 16, 19, 2, 811, DateTimeKind.Local).AddTicks(3722), "RAV4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
