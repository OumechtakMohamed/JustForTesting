namespace TestJustForTest.Entities
{
    using Pasquier.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestJustForTest.Common;

    /// MOUVEMENTPARAM Entity
    [Table("OVERLOG_STOCK_MOUVEMENTPARAM")]
    public class MouvementParam : EntityBase
    {
        /// <summary>
        /// site
        /// </summary>
        public Site Site { get; set; }
        /// <summary>
        /// Activity
        /// </summary>
        public Activity Activity { get; set; }
        /// <summary>
        /// Depository
        /// </summary>
        public Depository Depository { get; set; }
        /// <summary>
        /// Mouvement Sens
        /// </summary>
        public MouvementSens MouvementSens { get; set; }
        /// <summary>
        /// Origin System
        /// </summary>
        public OriginSystem OriginSystem { get; set; }
        /// <summary>
        /// Mouvement Type
        /// </summary>
        [Required]
        public string MouvementType { get; set; }
   
    }
}
