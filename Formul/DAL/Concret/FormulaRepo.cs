using Formul.DAL.Abstract;
using Formul.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Formul.DAL.Concret
{
    public class FormulaRepo : IFormulaRepo
    {
        private readonly DataContext _ctx;
        public FormulaRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Addasync(Formula formula)
        {
           await _ctx.Formulas.AddAsync(formula);
            await _ctx.SaveChangesAsync();

        }

        public async Task<List<Formula>> GetAsync()
        {
            return await  _ctx.Formulas.ToListAsync();
        }

        public async Task<Formula> GetAsync(int id)
        {
            Formula formula = await _ctx.Formulas.SingleAsync(m => m.FormulaId == id);
            return formula;
        }
    }
}
