﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Movie
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string UserId { get; set; }
    }
}
