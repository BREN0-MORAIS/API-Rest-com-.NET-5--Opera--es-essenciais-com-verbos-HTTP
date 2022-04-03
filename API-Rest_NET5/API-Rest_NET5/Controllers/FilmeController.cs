using API_Rest_NET5.Data;
using API_Rest_NET5.Data.Dtos;
using API_Rest_NET5.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API_Rest_NET5.Controllers
{
    [ApiController]
    [Route("[controller]")] //referencia o controlle da classe, não é necessaria colocar o nome
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;
        public FilmeController(FilmeContext  context, IMapper mapper)
        {
            _context = context;
            _mapper =mapper;
        }
        public IActionResult AdiconarFilme([FromBody] CreateFilmeDto filmeDto)
        {
            var filme =_mapper.Map<Filme>(filmeDto);

            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarFilmePorId), new { id = filme.Id }, filme);

           // System.Console.WriteLine(filme.Titulo);
        } 

        [HttpGet]
        public IActionResult RecuperarFilmes()
        {
            return Ok(_context.Filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmePorId(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null) return NotFound("Não foi encontrado");
            return Ok(filme);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarFilem([FromBody] Filme filmeNovo)
        {
            _context.Filmes.Update(filmeNovo);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarFilme(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
            _context.Filmes.Remove(filme);
            _context.SaveChanges();


            return Ok();

        }
    }
}
