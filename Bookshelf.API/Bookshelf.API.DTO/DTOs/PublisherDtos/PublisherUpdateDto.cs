using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.PublisherDtos
{
    public class PublisherUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
