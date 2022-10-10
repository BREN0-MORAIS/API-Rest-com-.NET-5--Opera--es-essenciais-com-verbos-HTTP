using API_Rest_NET5.Data.Dtos.Gerente;
using API_Rest_NET5.Models;
using AutoMapper;
using System.Linq;

namespace API_Rest_NET5.Profiles
{
    public class GerenteProfile:Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>().ForMember( //selecionou o read gerente
                gerente=> gerente.Cinemas,  //selecionou o cinemas do readGerentes
                opts=> opts.MapFrom(gerente=> gerente.Cinemas.Select( //obeteve o Gerente 
                    cinema =>    //obteve o cinema do Gerente
                        new { cinema.Id, cinema.Nome, cinema.Endereco, cinema.EnderecoId} //selecionou os campos que quer trazer de cinema
                    ))
                );
        }
    }
}
