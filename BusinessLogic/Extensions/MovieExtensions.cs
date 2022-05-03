using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extensions
{
    public static class MovieExtensions
    {
        public static DTO.Movie ToDTO(this DomainModels.Movie movie)
        {
            return new DTO.Movie()
            {
                Id = movie.Id,
                Name = movie.Id,
                Genre = movie.Genre,
                UserId = movie.UserId
            };
        }
    }
}
