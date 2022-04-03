using API_Rest_NET5.Data.Dtos.Endereco;
using API_Rest_NET5.Models;
using AutoMapper;

namespace API_Rest_NET5.Profiles
{
    public class EnderecoProfile:Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
