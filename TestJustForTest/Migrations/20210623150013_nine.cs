using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestJustForTest.Migrations
{
    public partial class nine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_STORE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_STORE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_STORE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_STORE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_STORAGEUNITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_STORAGEUNITY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_STORAGEUNITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_STORAGEUNITY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_SITE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_SITE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_SITE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_SITE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENTACTION",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENTACTION",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENTACTION",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENTACTION",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_LOTQUANTITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_LOTQUANTITY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_LOTQUANTITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_LOTQUANTITY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_LOGISTICUNITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_LOGISTICUNITY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_LOGISTICUNITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_LOGISTICUNITY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_DEPOSITORY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_DEPOSITORY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_DEPOSITORY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_DEPOSITORY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_ARTICLE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_ARTICLE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_ARTICLE",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_ARTICLE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_ACTIVITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_ACTIVITY",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_ACTIVITY",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_ACTIVITY",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_STORE");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_STORE");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_STORE");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_STORE");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_STORAGEUNITY");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_STORAGEUNITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_STORAGEUNITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_STORAGEUNITY");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_SITE");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_SITE");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_SITE");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_SITE");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENTPARAM");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENTACTION");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENTACTION");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENTACTION");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENTACTION");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENT_SENS");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_MOUVEMENT");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_MOUVEMENT");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_MOUVEMENT");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_MOUVEMENT");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_LOTQUANTITY");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_LOTQUANTITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_LOTQUANTITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_LOTQUANTITY");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_LOGISTICUNITY");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_LOGISTICUNITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_LOGISTICUNITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_LOGISTICUNITY");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_DEPOSITORY");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_DEPOSITORY");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_DEPOSITORY");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_DEPOSITORY");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_CONSOMMATIONUNITY");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_CONDITIONNEDARTICLE");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_ARTICLE");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_ARTICLE");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_ARTICLE");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_ARTICLE");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OVERLOG_STOCK_ACTIVITY");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OVERLOG_STOCK_ACTIVITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OVERLOG_STOCK_ACTIVITY");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "OVERLOG_STOCK_ACTIVITY");
        }
    }
}
