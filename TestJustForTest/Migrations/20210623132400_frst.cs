using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestJustForTest.Migrations
{
    public partial class frst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_ACTIVITY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_ACTIVITY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_ARTICLE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_ARTICLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_CONDITIONNEDARTICLE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_CONDITIONNEDARTICLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_CONSOMMATIONUNITY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_CONSOMMATIONUNITY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_DEPOSITORY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_DEPOSITORY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_LOGISTICUNITY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_LOGISTICUNITY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_LOTQUANTITY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_LOTQUANTITY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_MOUVEMENTACTION",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_MOUVEMENTACTION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_PIECE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_PIECE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_SITE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_SITE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_STORAGEUNITY",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_STORAGEUNITY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_STORE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_STORE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OVERLOG_STOCK_MOUVEMENT",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateMouvement = table.Column<DateTime>(nullable: false),
                    ArticleId = table.Column<int>(nullable: true),
                    PieceId = table.Column<int>(nullable: true),
                    Dluo = table.Column<DateTime>(nullable: false),
                    PaletteNum = table.Column<string>(nullable: false),
                    QuantityPalette = table.Column<int>(nullable: false),
                    LogisticUnityId = table.Column<int>(nullable: true),
                    ConditionnedArticleId = table.Column<int>(nullable: true),
                    ConsommationUnityId = table.Column<int>(nullable: true),
                    LotQuantityId = table.Column<int>(nullable: true),
                    StorageUnityId = table.Column<int>(nullable: true),
                    LotNum = table.Column<string>(nullable: false),
                    PartenaryCode = table.Column<string>(nullable: true),
                    Matricule = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: true),
                    MouvementActionId = table.Column<int>(nullable: true),
                    DepositoryId = table.Column<int>(nullable: true),
                    SiteId = table.Column<int>(nullable: true),
                    ActivityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERLOG_STOCK_MOUVEMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_ACTIVITY_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "OVERLOG_STOCK_ACTIVITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_ARTICLE_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "OVERLOG_STOCK_ARTICLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_CONDITIONNEDARTICLE_ConditionnedArticleId",
                        column: x => x.ConditionnedArticleId,
                        principalTable: "OVERLOG_STOCK_CONDITIONNEDARTICLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_CONSOMMATIONUNITY_ConsommationUnityId",
                        column: x => x.ConsommationUnityId,
                        principalTable: "OVERLOG_STOCK_CONSOMMATIONUNITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_DEPOSITORY_DepositoryId",
                        column: x => x.DepositoryId,
                        principalTable: "OVERLOG_STOCK_DEPOSITORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_LOGISTICUNITY_LogisticUnityId",
                        column: x => x.LogisticUnityId,
                        principalTable: "OVERLOG_STOCK_LOGISTICUNITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_LOTQUANTITY_LotQuantityId",
                        column: x => x.LotQuantityId,
                        principalTable: "OVERLOG_STOCK_LOTQUANTITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_MOUVEMENTACTION_MouvementActionId",
                        column: x => x.MouvementActionId,
                        principalTable: "OVERLOG_STOCK_MOUVEMENTACTION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_PIECE_PieceId",
                        column: x => x.PieceId,
                        principalTable: "OVERLOG_STOCK_PIECE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_SITE_SiteId",
                        column: x => x.SiteId,
                        principalTable: "OVERLOG_STOCK_SITE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_STORAGEUNITY_StorageUnityId",
                        column: x => x.StorageUnityId,
                        principalTable: "OVERLOG_STOCK_STORAGEUNITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OVERLOG_STOCK_MOUVEMENT_OVERLOG_STOCK_STORE_StoreId",
                        column: x => x.StoreId,
                        principalTable: "OVERLOG_STOCK_STORE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "OVERLOG_STOCK_PIECE",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Piece1" });

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_ActivityId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_ArticleId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_ConditionnedArticleId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "ConditionnedArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_ConsommationUnityId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "ConsommationUnityId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_DepositoryId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "DepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_LogisticUnityId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "LogisticUnityId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_LotQuantityId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "LotQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_MouvementActionId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "MouvementActionId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_PieceId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_SiteId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_StorageUnityId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "StorageUnityId");

            migrationBuilder.CreateIndex(
                name: "IX_OVERLOG_STOCK_MOUVEMENT_StoreId",
                table: "OVERLOG_STOCK_MOUVEMENT",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_MOUVEMENT");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_ACTIVITY");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_ARTICLE");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_CONDITIONNEDARTICLE");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_CONSOMMATIONUNITY");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_DEPOSITORY");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_LOGISTICUNITY");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_LOTQUANTITY");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_MOUVEMENTACTION");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_PIECE");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_SITE");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_STORAGEUNITY");

            migrationBuilder.DropTable(
                name: "OVERLOG_STOCK_STORE");
        }
    }
}
