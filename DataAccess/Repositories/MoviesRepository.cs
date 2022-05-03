using BusinessLogic.DomainModels;
using BusinessLogic.Interfaces;
using DataAccess.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class MoviesRepository : RepositoryBase<Models.Movie>, IMoviesRepository
    {
        public MoviesRepository(MoviesContext context) : base(context) { }
        public List<Movie> GetAll()
        {
            var movies = FindAll(false).ToList();
            var moviesDomain = movies.Select(x => x.ToDomainModel());
            return moviesDomain.ToList();

        }

        public Movie AddUserMovie(Movie movie)
        {
            var movies = FindAll(false).ToList();
            var movieModel = new Models.Movie()
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = movie.Name,
                Genre = movie.Genre,
                UserId = movie.UserId
            };
            Create(movieModel);
            return movieModel.ToDomainModel();
        }

        public List<Movie> GetMoviesByUserId(string id)
        {
            var movies = FindAll(false).ToList();
            var userMovies = movies.FindAll(u => u.UserId == id);
            var domainMovies = userMovies.Select(x => x.ToDomainModel()).ToList();
            return domainMovies;
        }

    }
}
