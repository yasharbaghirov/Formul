using AutoMapper;
using Formul.BLL.Abstarct;
using Formul.DAL.Abstract;
using Formul.DTOs.ParametrDTOs;
using Formul.Entities;

namespace Formul.BLL.Concret
{
    public class ParametrService : IParametrService
    {
        private readonly IParametrRepo _parametrrepo;
        private readonly IMapper _mapper;
        public ParametrService(IParametrRepo parametrrepo, IMapper mapper)
        {
            _parametrrepo = parametrrepo;
            _mapper = mapper;
        }

        public async Task Addasync(ParametrToAddDTO parametr)
        {
            Parametr entity= _mapper.Map<Parametr>(parametr);
            await _parametrrepo.Addasync(entity);

        }

        public async Task<List<ParametrToListDTO>> GetAsync()
        {
            List<Parametr> entites = await _parametrrepo.GetAsync();
            List<ParametrToListDTO> dtos=_mapper.Map<List<ParametrToListDTO>>(entites);
            return dtos;
        }
    }
}
