using Bookshelf.API.DTO.DTOs.BaseDtos;

namespace Bookshelf.API.DTO.DTOs.PublisherDtos
{
    public class PublisherUpdateDto : BaseUpdateDto
    {
        public string? Name { get; set; }
    }
}
