using ApplicationCore.Entities;
using AutoMapper;
using MovieApplication.Models.ViewModels;

namespace MovieApplication.Mappings
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieCardVM>();
        }
    }
}
