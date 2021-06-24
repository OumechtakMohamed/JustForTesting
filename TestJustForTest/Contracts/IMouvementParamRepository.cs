using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestJustForTest.Entities;
using TestJustForTest.Models;

namespace TestJustForTest.Contracts
{
    public interface IMouvementParamRepository : IAsyncRepository<MouvementParam>
    {
        Task<IEnumerable<MouvementParam>> MouvementParams(MouvementParamGet arg);
    }
}
