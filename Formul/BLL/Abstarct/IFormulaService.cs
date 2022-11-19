using Formul.DTOs.FormulaDTOs;
using Formul.DTOs.ParametrDTOs;

namespace Formul.BLL.Abstarct
{
    public interface IFormulaService
    {
        Task Addasync(FormulaToAddDTO formula);
        Task<List<FormulaToListDTO>> GetAsync();
        Task<FormulaToListDTO> GetAsync(int id);
    }
}
