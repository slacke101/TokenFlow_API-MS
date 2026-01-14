using TokenFlow_API_MS.Services;
using Microsoft.AspNetCore.Mvc;
using TokenFlow_API_MS.Models;

namespace TokenFlow_API_MS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpGet]  // GET all tokens for users
        public IActionResult GetAll()
        {
            var tokens = _tokenService.GetAll();
            return Ok(tokens);
        }

        [HttpGet("{id}")]  // GET token by specific GUID 
        public IActionResult Get(Guid id)
        {
            var token = _tokenService.Get(id);

            if (token == null)
                return NotFound("Token not found");

            return Ok(token);
        }
    }
}