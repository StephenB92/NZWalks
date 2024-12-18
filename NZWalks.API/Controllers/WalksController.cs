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
    }
}
