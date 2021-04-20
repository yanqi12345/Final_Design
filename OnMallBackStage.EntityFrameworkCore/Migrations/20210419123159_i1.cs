using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnMallBackStage.EntityFrameworkCore.Migrations
{
    public partial class i1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classifies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ClassDetail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Level = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MerchandiseId = table.Column<Guid>(type: "char(36)", nullable: false),
                    CommentDetail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ManagerNo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ManagerPassword = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchandises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    MerchandiseNo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MerchandiseName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Sum = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Introduction = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClassifyId = table.Column<Guid>(type: "char(36)", nullable: false),
                    MerchantId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchandises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    MerchantNo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MerchantName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MerchantPassword = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MerchantTel = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classifies");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Merchandises");

            migrationBuilder.DropTable(
                name: "Merchants");
        }
    }
}
