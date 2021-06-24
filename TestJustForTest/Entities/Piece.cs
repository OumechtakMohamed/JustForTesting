namespace TestJustForTest.Entities
{
    using Pasquier.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestJustForTest.Common;

    /// PIECE Entity
    [Table("OVERLOG_STOCK_PIECE")]
    public class Piece : EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
}
