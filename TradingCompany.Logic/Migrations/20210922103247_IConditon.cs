using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TradingCompany.Logic.Migrations
{
    public partial class IConditon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "ItemMaster",
                table: "Condition");

            migrationBuilder.DropColumn(
                name: "Discount",
                schema: "ItemMaster",
                table: "Condition");

            migrationBuilder.RenameColumn(
                name: "PriceNet",
                schema: "ItemMaster",
                table: "Condition",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Count",
                schema: "ItemMaster",
                table: "Condition",
                newName: "type");

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                schema: "ItemMaster",
                table: "Condition",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                schema: "ItemMaster",
                table: "Condition");

            migrationBuilder.RenameColumn(
                name: "type",
                schema: "ItemMaster",
                table: "Condition",
                newName: "Count");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                schema: "ItemMaster",
                table: "Condition",
                newName: "PriceNet");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "ItemMaster",
                table: "Condition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                schema: "ItemMaster",
                table: "Condition",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
