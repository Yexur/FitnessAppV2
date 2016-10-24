using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitnessAppV2.Data.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FitnessClassType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessClassType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FitnessClass",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    DateOfClass = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<string>(nullable: false),
                    FitnessClassType_Id = table.Column<int>(nullable: true),
                    Instructors_Id = table.Column<int>(nullable: true),
                    Locations_Id = table.Column<int>(nullable: true),
                    StartTime = table.Column<string>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FitnessClass_FitnessClassType_FitnessClassType_Id",
                        column: x => x.FitnessClassType_Id,
                        principalTable: "FitnessClassType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FitnessClass_Instructor_Instructors_Id",
                        column: x => x.Instructors_Id,
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FitnessClass_Location_Locations_Id",
                        column: x => x.Locations_Id,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FitnessClass_Id = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    WaitListed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationRecord_FitnessClass_FitnessClass_Id",
                        column: x => x.FitnessClass_Id,
                        principalTable: "FitnessClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FitnessClass_FitnessClassType_Id",
                table: "FitnessClass",
                column: "FitnessClassType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessClass_Instructors_Id",
                table: "FitnessClass",
                column: "Instructors_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FitnessClass_Locations_Id",
                table: "FitnessClass",
                column: "Locations_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationRecord_FitnessClass_Id",
                table: "RegistrationRecord",
                column: "FitnessClass_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationRecord");

            migrationBuilder.DropTable(
                name: "FitnessClass");

            migrationBuilder.DropTable(
                name: "FitnessClassType");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
