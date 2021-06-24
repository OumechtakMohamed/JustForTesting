namespace TestJustForTest.Entities
{
    using Pasquier.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestJustForTest.Common;

    /// MOUVEMENT Entity
    [Table("OVERLOG_STOCK_MOUVEMENT")]
    public class Mouvement : EntityBase
    {

        public DateTime DateMouvement { get; set; }

        public Article Article { get; set; }

        public Piece Piece { get; set; }

        public DateTime Dluo { get; set; }
        [Required]
        public string PaletteNum { get; set; }

        public int QuantityPalette { get; set; }

        public LogisticUnity LogisticUnity { get; set; }
        
        public ConditionnedArticle ConditionnedArticle { get; set; }

        public ConsommationUnity ConsommationUnity { get; set; }

        public LotQuantity LotQuantity { get; set; }

        public StorageUnity StorageUnity { get; set; }

        [Required]
        public string LotNum { get; set; }

        public string PartenaryCode { get; set; }

        public string Matricule { get; set; }

        public Store Store { get; set; }

        public MouvementAction MouvementAction { get; set; }

        public Depository Depository { get; set; }

        public Site Site { get; set; }

        public Activity Activity { get; set; }

    }
}