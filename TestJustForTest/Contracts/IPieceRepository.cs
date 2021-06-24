using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestJustForTest.Entities;

namespace TestJustForTest.Contracts
{
    public interface IPieceRepository : IAsyncRepository<Piece>
    {
        Task<IEnumerable<Piece>> GetPieces();
    }
}
