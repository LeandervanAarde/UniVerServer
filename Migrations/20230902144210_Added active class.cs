﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniVerServer.Migrations
{
    /// <inheritdoc />
    public partial class Addedactiveclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_active",
                table: "course_enrollments",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_active",
                table: "course_enrollments");
        }
    }
}
