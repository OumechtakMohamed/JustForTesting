namespace TestJustForTest.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TestJustForTest.Contracts;
    using TestJustForTest.Entities;
    public class PieceRepository : RepositoryBase<Piece>, IPieceRepository
    {
        public PieceRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Piece>> GetPieces()
        {
            var pieceList = await _dbContext.Pieces
                                .ToListAsync();
            return pieceList;
        }
    }
}
