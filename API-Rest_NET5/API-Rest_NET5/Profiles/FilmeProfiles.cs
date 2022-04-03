
using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

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
