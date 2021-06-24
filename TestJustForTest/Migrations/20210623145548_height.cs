using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestJustForTest.Migrations
{
    public partial class height : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_MOUVEMENT_SENS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_MOUVEMENT_SENS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_ORIGIN_SYSTEM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_ORIGIN_SYSTEM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_MOUVEMENTPARAM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<int>(nullable: true),
                    ActivityId = table.Column<int>(nullable: true),
                    DepositoryId = table.Column<int>(nullable: true),
                    MouvementSensId = table.Column<int>(nullable: true),
                    OriginSystemId = table.Column<int>(nullable: true),
                    MouvementType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_MOUVEMENTPARAM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENTPARAM_OVERLOG_STOCK_ACTIVITY_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "OVERLOG_STOCK_ACTIVITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENTPARAM_OVERLOG_STOCK_DEPOSITORY_DepositoryId",
                        column: x => x.DepositoryId,
                        principalTable: "OVERLOG_STOCK_DEPOSITORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENTPARAM_OVERLOG_STOCK_MOUVEMENT_SENS_MouvementSensId",
                        column: x => x.MouvementSensId,
                        principalTable: "OVERLOG_STOCK_MOUVEMENT_SENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENTPARAM_OVERLOG_STOCK_ORIGIN_SYSTEM_OriginSystemId",
                        column: x => x.OriginSystemId,
                        principalTable: "OVERLOG_STOCK_ORIGIN_SYSTEM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENTPARAM_OVERLOG_STOCK_SITE_SiteId",
                        column: x => x.SiteId,
                        principalTable: "OVERLOG_STOCK_SITE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENTPARAM_ActivityId",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENTPARAM_DepositoryId",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                column: "DepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENTPARAM_MouvementSensId",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                column: "MouvementSensId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENTPARAM_OriginSystemId",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                column: "OriginSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENTPARAM_SiteId",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                column: "SiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_MOUVEMENTPARAM");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_MOUVEMENT_SENS");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_ORIGIN_SYSTEM");
        }
    }
}
