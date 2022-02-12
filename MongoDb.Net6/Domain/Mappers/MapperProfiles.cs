using AutoMapper;
using Domain.Entities;
using Shared.DTO;

namespace Domain.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            AddBookProfile();
        }
        private void AddBookProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
