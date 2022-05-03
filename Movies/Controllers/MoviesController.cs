using BusinessLogic.Services;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Movies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesService _moviesService;

        public MoviesController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        [ActionName("Get Movies")]
        public List<Movie> Get()
        {
            return _moviesService.GetMovies();
        }

        [HttpGet("{id}")]
        [ActionName("Get Movies By User ID")]
        public List<Movie> Post(string id)
        {
            return _moviesService.GetMoviesByUserId(id);
        }

        [HttpPost]
        [ActionName("Add User Movie")]
        public Movie Post([FromBody] Movie movie)
        {
            return _moviesService.AddUserMovie(movie);
        }
    }
}
