using API_Rest_NET5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Rest_NET5.Controllers
{
    [ApiController]
    [Route("[controller]")] //referencia o controlle da classe, não é necessaria colocar o nome
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdiconarFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
            System.Console.WriteLine(filme.Titulo);

            if(filme.Titulo == "")
            {
                for(int i = 0; i < 1000; i++)
                {
                    System.Console.WriteLine("Olá Mundo!!");

                }
            }
        }
    }
}
