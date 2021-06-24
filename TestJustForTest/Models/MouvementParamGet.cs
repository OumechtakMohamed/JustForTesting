using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestJustForTest.Entities;

namespace TestJustForTest.Models
{
    public class MouvementParamGet
    {
        /// <summary>
        /// Site
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

        /// Nombre de ressources à ommettre pour la pagination
        public int Skip { get; set; }
        /// Nombre d'enregistrement à récupérer pour la pagination
        [Range(1, 1000)]
        public int Take { get; set; } = 1000;
    }
}
