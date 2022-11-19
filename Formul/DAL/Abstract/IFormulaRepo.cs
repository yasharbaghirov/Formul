using Formul.Entities;

namespace Formul.DAL.Abstract
{
    public interface IFormulaRepo
    {
        Task Addasync(Formula formula);
        Task<List<Formula>> GetAsync();
        Task <Formula> GetAsync(int id);   
    }
}
