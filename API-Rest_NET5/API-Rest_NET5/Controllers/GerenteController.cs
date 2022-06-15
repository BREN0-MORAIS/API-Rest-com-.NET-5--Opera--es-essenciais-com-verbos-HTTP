using API_Rest_NET5.Data.Dtos.Gerente;
using API_Rest_NET5.Models;
using AutoMapper;
using FilmesApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace API_Rest_NET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public GerenteController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarGerente(CreateGerenteDto gerenteDto)
        {
            Gerente gerente = _mapper.Map<Gerente>(gerenteDto);

            _context.Gerentes.Add(gerente);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperarFerentesPorId), new { id = gerente.Id }, gerente);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFerentesPorId(int id)
        {
            var gerente = _context.Gerentes.Find(id);

            if(gerente != null)
            {
                ReadGerenteDto gerenteDto = _mapper.Map<ReadGerenteDto>(gerente);

                return Ok(gerenteDto);
            }

            return NotFound();

        }


    }
}
