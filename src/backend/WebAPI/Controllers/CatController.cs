using Client.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        private readonly ICatService _catService;
        public CatController(ICatService catService)
        {
            _catService = catService;
        }

        [HttpGet("catfact")]
        public async Task<ActionResult> Get()
        {
            var response = await _catService.Get();
            return Ok(response);
        }
    }
}
