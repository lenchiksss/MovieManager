using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Contract.Requests
{
    public class UpsertGenreRequest
    {
        public int GenreId { get; set; }

        [Required]
        public string GenreName { get; set; }
    }
}
