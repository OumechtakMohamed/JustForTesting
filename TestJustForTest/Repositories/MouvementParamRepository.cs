using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestJustForTest.Contracts;
using TestJustForTest.Entities;
using TestJustForTest.Models;

namespace TestJustForTest.Repositories
{
    public class MouvementParamRepository : RepositoryBase<MouvementParam>, IMouvementParamRepository
    {
        public MouvementParamRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<MouvementParam>> MouvementParams(MouvementParamGet arg)
        {
            var mouvementParamsList = await _dbContext.MouvementParams
                               .ToListAsync();
            return mouvementParamsList;
        }
    }
}

