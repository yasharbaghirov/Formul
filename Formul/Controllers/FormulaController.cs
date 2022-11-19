using Formul.BLL.Abstarct;
using Formul.BLL.Concret;
using Formul.DTOs.FormulaDTOs;
using Formul.DTOs.ParametrDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Formul.Methods;
using System.IO.MemoryMappedFiles;
using Formul.Mehtods;

namespace Formul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormulaController : ControllerBase
    {
       
        
        private readonly IFormulaService _formulaService;
        private readonly IParametrService _parametrService;
        public FormulaController(IFormulaService formulaService, IParametrService parametrService)
        {
            _formulaService = formulaService;
            _parametrService = parametrService;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] FormulaToAddDTO dto)
        {
            await _formulaService.Addasync(dto);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<FormulaToListDTO> dtos = await _formulaService.GetAsync();
            return Ok(dtos);
        }
        [HttpGet("{id}/calculate")]
        public async Task<IActionResult> CalculateFormula([FromRoute] int id)
        {
            FormulaToListDTO dto = await _formulaService.GetAsync(id);
            string formula = dto.Formul;

            List<string> x =Calculate.FormulaQueue(formula);
            List<ParametrToListDTO> dtos = await _parametrService.GetAsync();
            string ccc = Calculate2.FormulaString(x, dtos);
            int cvb = Calculate3.Cavab(ccc);
            return Ok(cvb);









        }

        


    }
}
