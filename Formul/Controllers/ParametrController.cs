using Formul.BLL.Abstarct;
using Formul.DTOs.ParametrDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Formul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrController : ControllerBase
    {
        private readonly IParametrService _parametrService;
        public ParametrController(IParametrService parametrService)
        {
            _parametrService = parametrService;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody]ParametrToAddDTO dto)
        {
            await _parametrService.Addasync(dto);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<ParametrToListDTO> dtos = await _parametrService.GetAsync();
            return Ok(dtos);
        }
    }
}
