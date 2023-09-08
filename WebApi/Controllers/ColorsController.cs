using Business.Abstrac;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService= colorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result= _colorService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            } 
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
         public IActionResult Add(Color color) 
        {
            var result = _colorService.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
