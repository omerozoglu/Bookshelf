using AutoMapper;
using Bookshelf.API.DTO.DTOs.AuthorDtos;
using Bookshelf.API.DTO.DTOs.BookDtos;
using Bookshelf.API.DTO.DTOs.BookTransactionDtos;
using Bookshelf.API.DTO.DTOs.BookUserDtos;
using Bookshelf.API.DTO.DTOs.GenreDtos;
using Bookshelf.API.DTO.DTOs.PublisherDtos;
using Bookshelf.API.DTO.DTOs.UserDtos;
using Bookshelf.API.Entities.Concrete;

namespace Bookshelf.API.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserListDto, User>().ReverseMap();
            CreateMap<UserAddDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();
            CreateMap<UserLoginDto, User>().ReverseMap();

            CreateMap<AuthorListDto, Author>().ReverseMap();
            CreateMap<AuthorAddDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();

            CreateMap<BookListDto, Book>().ReverseMap();
            CreateMap<BookAddDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();

            CreateMap<BookTransactionListDto, BookTransaction>().ReverseMap();
            CreateMap<BookTransactionAddDto, BookTransaction>().ReverseMap();
            CreateMap<BookTransactionUpdateDto, BookTransaction>().ReverseMap();

            CreateMap<BookUserListDto, BookUser>().ReverseMap();
            CreateMap<BookUserAddDto, BookUser>().ReverseMap();
            CreateMap<BookUserUpdateDto, BookUser>().ReverseMap();

            CreateMap<GenreListDto, Genre>().ReverseMap();
            CreateMap<GenreAddDto, Genre>().ReverseMap();
            CreateMap<GenreUpdateDto, Genre>().ReverseMap();

            CreateMap<PublisherListDto, Publisher>().ReverseMap();
            CreateMap<PublisherAddDto, Publisher>().ReverseMap();
            CreateMap<PublisherUpdateDto, Publisher>().ReverseMap();

        }
    }
}
