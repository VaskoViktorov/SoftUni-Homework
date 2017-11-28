using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarDealer.Data.Migrations
{
    public partial class InitialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsIporter",
                table: "Suppliers");

            migrationBuilder.AddColumn<bool>(
                name: "IsImporter",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsImporter",
                table: "Suppliers");

            migrationBuilder.AddColumn<bool>(
                name: "IsIporter",
                table: "Suppliers",
                nullable: false,
                defaultValue: false);
        }
    }
}
