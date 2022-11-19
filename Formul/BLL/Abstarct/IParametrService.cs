using Formul.DTOs.ParametrDTOs;
using Formul.Entities;

namespace Formul.BLL.Abstarct
{
    public interface IParametrService
    {
        Task Addasync(ParametrToAddDTO parametr);
        Task<List<ParametrToListDTO>> GetAsync();
    }
}
