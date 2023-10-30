using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Data.Entites
{
    [Table("Genre")]
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [StringLength(255)]
        public string GenreName { get; set; }
    }
}
