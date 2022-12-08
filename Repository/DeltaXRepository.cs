using IMDbDeltaX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace IMDbDeltaX.Repository
{
    public class DeltaXRepository : IDeltaXRepository
    {
        private readonly IMDbWebAPIDbContext dbContext;

        public DeltaXRepository(IMDbWebAPIDbContext context)
        {
            dbContext = context;
        }

        public async Task<string> CreateMovie(Movie movie)
        {
            string status = "";
            dbContext.Movies.Add(movie);
            await dbContext.SaveChangesAsync();
            status = "Movie Created";
            return status;

        }

        public Movie GetMovieFromName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
