using Microsoft.EntityFrameworkCore;
using MovieManager.Contract.Responses;
using MovieManager.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Service.Queries
{
    public class GetGenreQueryHandler : IRequestHandler<IList<GenreResponse>>
    {
        private readonly MovieManagerContext _context;

        public GetGenreQueryHandler(MovieManagerContext context)
        {
            _context = context;
        }

        public async Task<IList<GenreResponse>> Handle(CancellationToken cancellationToken = default)
        {
            return await _context.Genres
                .AsNoTracking()
                .Select(x => new GenreResponse
                {
                    GenreId = x.GenreId,
                    GenreName = x.GenreName
                })
                .OrderByDescending(x => x.GenreId)
                .ToListAsync(cancellationToken);
        }
    }
}
