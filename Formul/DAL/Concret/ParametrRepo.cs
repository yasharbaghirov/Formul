using Formul.DAL.Abstract;
using Formul.Entities;
using Microsoft.EntityFrameworkCore;

namespace Formul.DAL.Concret
{
    public class ParametrRepo : IParametrRepo
    {
        private readonly DataContext _ctx;
        public ParametrRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Addasync(Parametr parametr)
        {
            await _ctx.Parametrs.AddAsync(parametr);
            await _ctx.SaveChangesAsync();
        }

        public async Task<List<Parametr>> GetAsync()
        {
            return await _ctx.Parametrs.ToListAsync();
        }
    }
}
