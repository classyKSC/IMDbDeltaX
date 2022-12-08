using IMDbDeltaX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDbDeltaX.Repository
{
    public interface IDeltaXRepository
    {
        public Movie GetMovieFromName(string name);
        public Task<string> CreateMovie(Movie movie);
    }

}
