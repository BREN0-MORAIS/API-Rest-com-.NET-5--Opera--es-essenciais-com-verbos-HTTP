﻿namespace API_Rest_NET5.Data.Dtos
{
    public class CreateFilmeDto
    {
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
    }
}
