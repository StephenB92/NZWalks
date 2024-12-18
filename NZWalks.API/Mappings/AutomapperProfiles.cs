using AutoMapper;
using NZWalks.API.Model.Domain;
using NZWalks.API.Model.DTO;

namespace NZWalks.API.Mappings
{
    public class AutomapperProfiles:Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Region, RegionDTO>().ReverseMap();
            CreateMap<AddRegionRequestDTO, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDTO, Region>().ReverseMap();
            CreateMap<AddWalkRequestDTO, Walks>().ReverseMap();
            CreateMap<Walks, WalkDTO>().ReverseMap();
            CreateMap<Difficulty, DifficultyDTO>().ReverseMap();
            CreateMap<UpdateWalkRequestDTO, Walks>().ReverseMap();
   
        }
    }

}
