using MovieManager.Data.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Service.Commands
{
    public class UpsertGenreCommand
    {
        public int GenreId { get; set; }

        public string GenreName { get; set; }

        public Genre UpsertGenre()
        {
            var genre = new Genre
            {
                GenreId = GenreId,
                GenreName = GenreName
            };

            return genre;
        }
    }
}
