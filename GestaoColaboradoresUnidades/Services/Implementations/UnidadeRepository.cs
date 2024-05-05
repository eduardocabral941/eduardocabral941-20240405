using GestaoColaboradoresUnidades.Data;
using GestaoColaboradoresUnidades.Model;
using GestaoColaboradoresUnidades.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestaoColaboradoresUnidades.Services.Implementations
{
    public class UnidadeRepository : IUnidadeRepository
    {
        private readonly ConectionContext _context = new ConectionContext();

        public void Add(Unidade unidade)
        {
           _context.Unidades.Add(unidade);
           _context.SaveChanges();
        }

        public List<Unidade> GetAll()
        {
           return _context.Unidades.Include(u => u.Colaboradores).ToList();
        }

        public void Update(int id, bool status)
        {
            var unidade = _context.Unidades.Find(id);
            if (unidade != null)
            {
                unidade.Status = status;
                _context.SaveChanges();
            }
        }
    }
}
