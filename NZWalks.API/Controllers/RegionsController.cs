﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NZWalks.API.Data;
using NZWalks.API.Model.Domain;
using System.Reflection.Metadata.Ecma335;
using static System.Net.WebRequestMethods;

namespace NZWalks.API.Controllers
{

    // https://localhost:1234/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL REGIONS
        // GET: https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
           var regions = dbContext.Regions.ToList();
            return Ok(regions);
        }
    }
}
