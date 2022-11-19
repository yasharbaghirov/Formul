using AutoMapper;
using Formul.BLL.Abstarct;
using Formul.DAL.Abstract;
using Formul.DAL.Concret;
using Formul.DTOs.FormulaDTOs;
using Formul.DTOs.ParametrDTOs;
using Formul.Entities;

namespace Formul.BLL.Concret
{
    public class FormulaService : IFormulaService
    {
        private readonly IFormulaRepo _formulaRepo;
        private readonly IMapper _mapper;
        public FormulaService(IFormulaRepo formulaRepo, IMapper mapper)
        {
            _formulaRepo = formulaRepo;
            _mapper = mapper;
        }

        public async Task Addasync(FormulaToAddDTO formula)
        {
            Formula entity = _mapper.Map<Formula>(formula);
            await _formulaRepo.Addasync(entity);
        }

        public async Task<List<FormulaToListDTO>> GetAsync()
        {
            List<Formula> entites = await _formulaRepo.GetAsync();
            List<FormulaToListDTO> dtos = _mapper.Map<List<FormulaToListDTO>>(entites);
            return dtos;
        }

        public async Task<FormulaToListDTO> GetAsync(int id)
        {
            Formula formula = await _formulaRepo.GetAsync(id);

            FormulaToListDTO dto=_mapper.Map<FormulaToListDTO>(formula);
            return dto;
        }
    }
}
