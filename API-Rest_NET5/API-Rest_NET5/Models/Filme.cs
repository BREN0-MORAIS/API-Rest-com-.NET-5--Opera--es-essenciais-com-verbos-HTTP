﻿using System.ComponentModel.DataAnnotations;

namespace API_Rest_NET5.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
    }
}
