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
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "903870ea-123e-4e7e-94fe-f5cde6b04299", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "f3c4cc43-fce5-4ec3-9bb6-e425adc85431", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ec479f0c-5cf1-4e9c-bc41-5cbbd756de5a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEHxwpbI+mw3eWxSQmJsbACj6nOa0foU3/VpbS2CjaIlybGrougrnGPIpcu/4R8pS2g==", null, false, "c493c44c-8a8b-4f92-904c-f03aa293d866", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 21, 19, 16, 19, 717, DateTimeKind.Local).AddTicks(6379), new DateTime(2021, 11, 21, 19, 16, 19, 718, DateTimeKind.Local).AddTicks(3202), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 21, 19, 16, 19, 718, DateTimeKind.Local).AddTicks(3757), new DateTime(2021, 11, 21, 19, 16, 19, 718, DateTimeKind.Local).AddTicks(3760), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(1906), new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(1915), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(1917), new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(1918), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4333), new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4338), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4340), new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4341), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4342), new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4343), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4344), new DateTime(2021, 11, 21, 19, 16, 19, 719, DateTimeKind.Local).AddTicks(4345), "Rav4", "System" }
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
