namespace TestJustForTest.Entities
{
    using Pasquier.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestJustForTest.Common;

    /// SITE Entity
    [Table("OVERLOG_STOCK_SITE")]
    public class Site : EntityBase
    {
        /// Activity
        public Activity Activity { get; set; }
    }
}