using AutoMapper;
using Reserve.Core.Entities.ApiClient.Reserve.GolClient;
using Reserve.Core.Models.ApiClient.Reserve.GolClient;

namespace Reserve.Api.Mappers.ProfileMappers
{
    public class MappingMappers : Profile
    {
        public MappingMappers()
        {
            CreateMap<GolDTO, Gol>().ReverseMap();
        }
    }
}
