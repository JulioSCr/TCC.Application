using AutoMapper;
using TCC.Application.GRPC.Models;
using TCC.Application.GRPC.Protos;

namespace TCC.Application.GRPC.Mapper
{
    public class PaisProfile : Profile
    {
        public PaisProfile()
        {
            CreateMap<Pais, PaisModel>().ReverseMap();
        }
    }
}
