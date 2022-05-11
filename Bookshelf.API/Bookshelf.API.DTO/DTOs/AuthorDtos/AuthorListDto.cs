using Bookshelf.API.DTO.DTOs.BaseDtos;
using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.AuthorDtos
{
    public class AuthorListDto : BaseListDto
    {
        public string Name { get; set; }
    }
}
