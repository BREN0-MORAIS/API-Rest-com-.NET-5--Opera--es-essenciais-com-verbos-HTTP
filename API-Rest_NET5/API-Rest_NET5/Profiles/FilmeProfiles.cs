using API_Rest_NET5.Data.Dtos;
using API_Rest_NET5.Models;
using AutoMapper;

namespace API_Rest_NET5.Profiles
{
    public class FilmeProfiles : Profile
    {
        public FilmeProfiles()
        {
            CreateFilme();
        }

        public void CreateFilme()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, CreateFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
