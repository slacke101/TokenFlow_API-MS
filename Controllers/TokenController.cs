using TokenFlow_API_MS.Services;
using Microsoft.AspNetCore.Mvc;
using TokenFlow_API_MS.Models;
using System.Reflection.Metadata.Ecma335;

namespace TokenFlow_API_MS.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        // GET method for token retrieval 
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult GetAll()
        {
            var tokens = _TokenService.GetAll();
            return Ok(tokens);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var token = _tokenService.Get(id);

            if (token == null)
                return NotFound("Token not found");

            return Ok(token);
        }



        // 
    }
}
