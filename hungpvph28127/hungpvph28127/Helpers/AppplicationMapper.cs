using AutoMapper;
using hungpvph28127.Data;
using hungpvph28127.Models;

namespace hungpvph28127.Helpers
{
    public class AppplicationMapper : Profile
    {
        public AppplicationMapper() {
        CreateMap<Book, BookModel>().ReverseMap();

        }

    }
}
