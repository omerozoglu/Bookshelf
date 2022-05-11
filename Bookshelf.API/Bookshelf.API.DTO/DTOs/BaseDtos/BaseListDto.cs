using Bookshelf.API.DTO.Interfaces;

namespace Bookshelf.API.DTO.DTOs.BaseDtos
{
    public class BaseListDto : IDto
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
