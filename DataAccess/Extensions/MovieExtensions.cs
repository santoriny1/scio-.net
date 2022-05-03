using BusinessLogic.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Extensions
{
    public static class MovieExtensions
    {
        public static Movie ToDomainModel(this Models.Movie movie)
        {
            return new Movie
            {
                Id = movie.Id,
                Name = movie.Name,
                Genre = movie.Genre,
                UserId = movie.UserId
            };
        }
    }
}
