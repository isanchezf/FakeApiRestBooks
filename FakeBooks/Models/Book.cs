using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeBooks.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Autor { get; set; }

        public string Genero { get; set; }
    }
}