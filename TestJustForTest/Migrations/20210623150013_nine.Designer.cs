﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestJustForTest.Entities;

namespace TestJustForTest.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210623150013_nine")]
    partial class nine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestJustForTest.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_ACTIVITY");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_ARTICLE");
                });

            modelBuilder.Entity("TestJustForTest.Entities.ConditionnedArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_CONDITIONNEDARTICLE");
                });

            modelBuilder.Entity("TestJustForTest.Entities.ConsommationUnity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_CONSOMMATIONUNITY");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Depository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("OVERLOG_STOCK_DEPOSITORY");
                });

            modelBuilder.Entity("TestJustForTest.Entities.LogisticUnity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_LOGISTICUNITY");
                });

            modelBuilder.Entity("TestJustForTest.Entities.LotQuantity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_LOTQUANTITY");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Mouvement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int?>("ConditionnedArticleId")
                        .HasColumnType("int");

                    b.Property<int?>("ConsommationUnityId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateMouvement")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepositoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dluo")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LogisticUnityId")
                        .HasColumnType("int");

                    b.Property<string>("LotNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LotQuantityId")
                        .HasColumnType("int");

                    b.Property<string>("Matricule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MouvementActionId")
                        .HasColumnType("int");

                    b.Property<string>("PaletteNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartenaryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PieceId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityPalette")
                        .HasColumnType("int");

                    b.Property<int?>("SiteId")
                        .HasColumnType("int");

                    b.Property<int?>("StorageUnityId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ConditionnedArticleId");

                    b.HasIndex("ConsommationUnityId");

                    b.HasIndex("DepositoryId");

                    b.HasIndex("LogisticUnityId");

                    b.HasIndex("LotQuantityId");

                    b.HasIndex("MouvementActionId");

                    b.HasIndex("PieceId");

                    b.HasIndex("SiteId");

                    b.HasIndex("StorageUnityId");

                    b.HasIndex("StoreId");

                    b.ToTable("OVERLOG_STOCK_MOUVEMENT");
                });

            modelBuilder.Entity("TestJustForTest.Entities.MouvementAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_MOUVEMENTACTION");
                });

            modelBuilder.Entity("TestJustForTest.Entities.MouvementParam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepositoryId")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MouvementSensId")
                        .HasColumnType("int");

                    b.Property<string>("MouvementType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OriginSystemId")
                        .HasColumnType("int");

                    b.Property<int?>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("DepositoryId");

                    b.HasIndex("MouvementSensId");

                    b.HasIndex("OriginSystemId");

                    b.HasIndex("SiteId");

                    b.ToTable("OVERLOG_STOCK_MOUVEMENTPARAM");
                });

            modelBuilder.Entity("TestJustForTest.Entities.MouvementSens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_MOUVEMENT_SENS");
                });

            modelBuilder.Entity("TestJustForTest.Entities.OriginSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_ORIGIN_SYSTEM");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Piece", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_PIECE");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("OVERLOG_STOCK_SITE");
                });

            modelBuilder.Entity("TestJustForTest.Entities.StorageUnity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_STORAGEUNITY");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OVERLOG_STOCK_STORE");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Depository", b =>
                {
                    b.HasOne("TestJustForTest.Entities.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Mouvement", b =>
                {
                    b.HasOne("TestJustForTest.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("TestJustForTest.Entities.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId");

                    b.HasOne("TestJustForTest.Entities.ConditionnedArticle", "ConditionnedArticle")
                        .WithMany()
                        .HasForeignKey("ConditionnedArticleId");

                    b.HasOne("TestJustForTest.Entities.ConsommationUnity", "ConsommationUnity")
                        .WithMany()
                        .HasForeignKey("ConsommationUnityId");

                    b.HasOne("TestJustForTest.Entities.Depository", "Depository")
                        .WithMany()
                        .HasForeignKey("DepositoryId");

                    b.HasOne("TestJustForTest.Entities.LogisticUnity", "LogisticUnity")
                        .WithMany()
                        .HasForeignKey("LogisticUnityId");

                    b.HasOne("TestJustForTest.Entities.LotQuantity", "LotQuantity")
                        .WithMany()
                        .HasForeignKey("LotQuantityId");

                    b.HasOne("TestJustForTest.Entities.MouvementAction", "MouvementAction")
                        .WithMany()
                        .HasForeignKey("MouvementActionId");

                    b.HasOne("TestJustForTest.Entities.Piece", "Piece")
                        .WithMany()
                        .HasForeignKey("PieceId");

                    b.HasOne("TestJustForTest.Entities.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId");

                    b.HasOne("TestJustForTest.Entities.StorageUnity", "StorageUnity")
                        .WithMany()
                        .HasForeignKey("StorageUnityId");

                    b.HasOne("TestJustForTest.Entities.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("TestJustForTest.Entities.MouvementParam", b =>
                {
                    b.HasOne("TestJustForTest.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("TestJustForTest.Entities.Depository", "Depository")
                        .WithMany()
                        .HasForeignKey("DepositoryId");

                    b.HasOne("TestJustForTest.Entities.MouvementSens", "MouvementSens")
                        .WithMany()
                        .HasForeignKey("MouvementSensId");

                    b.HasOne("TestJustForTest.Entities.OriginSystem", "OriginSystem")
                        .WithMany()
                        .HasForeignKey("OriginSystemId");

                    b.HasOne("TestJustForTest.Entities.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId");
                });

            modelBuilder.Entity("TestJustForTest.Entities.Site", b =>
                {
                    b.HasOne("TestJustForTest.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");
                });
#pragma warning restore 612, 618
        }
    }
}