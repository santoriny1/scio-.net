using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IMoviesRepository
    {
        public List<DomainModels.Movie> GetAll();
        public List<DomainModels.Movie> GetMoviesByUserId(string id);
        public DomainModels.Movie AddUserMovie(DomainModels.Movie movie);
    }
}
