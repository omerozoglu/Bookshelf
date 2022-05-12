using AutoMapper;
using Bookshelf.API.Business.Interfaces;
using Bookshelf.API.DTO.DTOs.PublisherDtos;
using Bookshelf.API.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Bookshelf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherService _publisherService;
        private readonly IMapper _mapper;

        public PublisherController(IPublisherService publisherService, IMapper mapper)
        {
            _publisherService = publisherService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<PublisherListDto>>(await _publisherService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<PublisherListDto>(await _publisherService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(PublisherAddDto publisher)
        {
            await _publisherService.AddAsync(_mapper.Map<Publisher>(publisher));
            return Created("", publisher);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PublisherUpdateDto publisher)
        {
            if (id != publisher.Id)
                return BadRequest("");
            await _publisherService.UpdateAsync(_mapper.Map<Publisher>(publisher));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _publisherService.RemoveAsync(new Publisher { Id = id });
            return NoContent();
        }
    }
}
