using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BaseDtos
{
    public class BaseUpdateDto : IDto
    {
        public int Id { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
