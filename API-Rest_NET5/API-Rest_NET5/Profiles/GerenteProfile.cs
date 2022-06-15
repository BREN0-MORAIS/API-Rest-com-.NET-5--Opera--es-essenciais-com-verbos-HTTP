using API_Rest_NET5.Data.Dtos.Gerente;
using API_Rest_NET5.Models;
using AutoMapper;

namespace API_Rest_NET5.Profiles
{
    public class GerenteProfile:Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>();
        }
    }
}
