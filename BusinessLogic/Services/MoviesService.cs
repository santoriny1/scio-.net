using BusinessLogic.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Extensions;

namespace BusinessLogic.Services
{
    public class MoviesService
    {
        private readonly IRepositoryManager _repositoryManager;

        public MoviesService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public List<Movie> GetMovies()
        {
            return _repositoryManager.Movies.GetAll().Select(x => new Movie()
            {
                Id = x.Id,
                Name = x.Name,
                Genre = x.Genre,
                UserId = x.UserId
            }).ToList();
        }

        public Movie AddUserMovie(Movie movie)
        {
            var domainMovie = new DomainModels.Movie()
            {
                Name = movie.Name,
                Genre = movie.Genre,
                UserId= movie.UserId
            };

            var dbMovie = _repositoryManager.Movies.AddUserMovie(domainMovie);
            _repositoryManager.Save();

            return dbMovie.ToDTO();
        }

        public List<Movie> GetMoviesByUserId(string id)
        {
            return _repositoryManager.Movies.GetMoviesByUserId(id).Select(x => new Movie()
            {
                Id = x.Id,
                Name = x.Name,
                Genre = x.Genre,
                UserId = x.UserId
            }).ToList();
        }

    }
}
