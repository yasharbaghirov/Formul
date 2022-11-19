using AutoMapper;
using Formul.DTOs.FormulaDTOs;
using Formul.DTOs.ParametrDTOs;
using Formul.Entities;

namespace Formul.BLL
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ParametrToAddDTO, Parametr>();
            CreateMap<Parametr, ParametrToListDTO>();
            CreateMap<Formula, FormulaToListDTO>();
            CreateMap<FormulaToAddDTO, Formula>();
        }

    }
}
