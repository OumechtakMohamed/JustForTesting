namespace TestJustForTest.Entities
{
    using Pasquier.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TestJustForTest.Common;

    /// DEPOSITORY Entity
    [Table("OVERLOG_STOCK_DEPOSITORY")]
    public class Depository : EntityBase
    {

        /// <summary>
        /// Site
        /// </summary>
        public Site Site { get; set; }

    }
}