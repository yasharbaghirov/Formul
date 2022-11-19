using Formul.Entities;

namespace Formul.DAL.Abstract
{
    public interface IParametrRepo
    {
        Task Addasync(Parametr parametr);
        Task<List<Parametr>> GetAsync();

    }
}
