﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Contract.Responses
{
    public class GenreResponse
    {
        public int GenreId { get; set; }

        public string GenreName { get; set; }
    }
}
