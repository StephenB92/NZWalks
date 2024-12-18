using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Model.Domain;
using NZWalks.API.Model.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    // /api/walks
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }

        // CREATE Walks
        //POST: /api/walks
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDTO addWalkRequestDTO) 
        {
            // Map DTO to Domain Model
            var walkDomainModel = mapper.Map<Walks>(addWalkRequestDTO);

            await walkRepository.CreateAsync(walkDomainModel);

            // map domain model to DTO
            return Ok(mapper.Map<WalkDTO>(walkDomainModel));
        }


        // GET Walks
        // GET: /api/walks
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var walkDomainModel = await walkRepository.GetAllAsync();

            //Map Domain Model to DTO
            return Ok(mapper.Map<List<WalkDTO>>(walkDomainModel));
        }

        // Get Walk By id
        // GET: /api/Walks/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id) 
        {
            var walkDomainModel = await walkRepository.GetByIdAsync(id);

            if (walkDomainModel == null) 
            {
                return NotFound();
            }

            // map domain to dto
            return Ok(mapper.Map<WalkDTO>(walkDomainModel));
        }

        // Update walk by ID
        // PUT: api/Walks/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] Guid id, [FromBody] UpdateWalkRequestDTO updateWalkRequestDTO) 
        {
            // map DTO to domain model
            var walkDomainModel = mapper.Map<Walks>(updateWalkRequestDTO);

            walkDomainModel = await walkRepository.UpdateAsync(id, walkDomainModel);

            if (walkDomainModel == null) 
            {
                return NotFound();
            }

            // map domain to DTO
            return Ok(mapper.Map<WalkDTO>(walkDomainModel));
        }

        // delete walk by ID
        // DELETE: /api/Walks/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id) 
        {
           var deletedWalkDomainModel = await walkRepository.DeleteAsync(id);

            if (deletedWalkDomainModel == null) 
            {
                return NotFound();
            }
            // map domain model to DTO
            return Ok(mapper.Map<WalkDTO>(deletedWalkDomainModel));
        }

    }
}
