using AutoMapper;
using Medicination.API.Core.Dtos;
using Medicination.API.Core.Models;

namespace Medicination.API.Services.Mapping
{
	public class MapProfile:Profile
	{
        public MapProfile()
        {
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<Medicine, MedicineDto>().ReverseMap();
            CreateMap<Member, MemberDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

		}
    }
}
