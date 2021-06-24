namespace TestJustForTest.Entities
{
    using Microsoft.EntityFrameworkCore;
    using Pasquier.EntityFramework;
    using System.Collections.Generic;

    public class DatabaseContext : PasquierDbContext
    {
        /// <summary>
        /// Initialise l'instance
        /// </summary>
        /// <param name="options">Options</param>
        public DatabaseContext(DbContextOptions options) : base( options)
        { }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        /// Modèles des Articles
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ConditionnedArticle> ConditionnedArticles { get; set; }
        public DbSet<ConsommationUnity> ConsommationUnities { get; set; }
        public DbSet<Depository> Depositories { get; set; } 
        public DbSet<LogisticUnity> LogisticUnities { get; set; }
        public DbSet<LotQuantity> LotQuantities { get; set; }
        public DbSet<Mouvement> Mouvements { get; set; }
        public DbSet<MouvementAction> MouvementActions { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<StorageUnity> StorageUnities { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<OriginSystem> OriginSystemes { get; set; }
        public DbSet<MouvementSens> MouvementSenses { get; set; }
        public DbSet<MouvementParam> MouvementParams { get; set; }
    }
}