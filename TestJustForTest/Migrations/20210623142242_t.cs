using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestJustForTest.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OVERLOG_STOCK_PIECE",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_PIECE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_PIECE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_PIECE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_PIECE",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_PIECE");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_PIECE");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_PIECE");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_PIECE");

            migrationBuilder.InsertData(
                table: "OVERLOG_STOCK_PIECE",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Piece1" });
        }
    }
}
