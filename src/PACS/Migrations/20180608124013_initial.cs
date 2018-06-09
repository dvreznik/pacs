using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PACS.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GymMembers",
                columns: table => new
                {
                    GymMemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    DateRegistration = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    RelImage = table.Column<string>(nullable: true),
                    Staff = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymMembers", x => x.GymMemberId);
                });

            migrationBuilder.CreateTable(
                name: "GymCards",
                columns: table => new
                {
                    GymCardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOrder = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    GymMemberId = table.Column<int>(nullable: false),
                    Kind = table.Column<string>(nullable: true),
                    Trainer = table.Column<bool>(nullable: false),
                    Visible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymCards", x => x.GymCardId);
                    table.ForeignKey(
                        name: "FK_GymCards_GymMembers_GymMemberId",
                        column: x => x.GymMemberId,
                        principalTable: "GymMembers",
                        principalColumn: "GymMemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GymCards_GymMemberId",
                table: "GymCards",
                column: "GymMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymCards");

            migrationBuilder.DropTable(
                name: "GymMembers");
        }
    }
}
