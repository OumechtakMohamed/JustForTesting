using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestJustForTest.Common
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastModifiedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }
    }
}
