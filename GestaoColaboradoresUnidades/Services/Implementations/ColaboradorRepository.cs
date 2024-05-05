using GestaoColaboradoresUnidades.Data;
using GestaoColaboradoresUnidades.Model;
using GestaoColaboradoresUnidades.Services.Interfaces;

namespace GestaoColaboradoresUnidades.Services.Implementations
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly ConectionContext _context = new ConectionContext();

        public void Add(Colaborador colaborador)
        {
            var unidade = _context.Unidades.Find(colaborador.UnidadeId);
            if (unidade != null && unidade.Status)
            {
                _context.Colaboradores.Add(colaborador);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("A unidade não está ativa.");
            }

            var usuario = _context.Usuarios.Find(colaborador.UserId);
            if (usuario == null)
            {
                throw new Exception("O usuário  não existe.");
            }
        }

        public void Update(int id, string nome, int unidadeid)
        {
            var colaborador = _context.Colaboradores.Find(id);
            if (colaborador != null)
            {
                colaborador.AlterarNome(nome);
                colaborador.AlterarUnidade(unidadeid);
                _context.Colaboradores.Update(colaborador);
                _context.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            var colaborador = _context.Colaboradores.Find(id);
            if (colaborador != null)
            {
                _context.Colaboradores.Remove(colaborador);
                _context.SaveChanges();
            }
        }

        public List<Colaborador> GetAll()
        {
            return _context.Colaboradores.ToList();
        }

    }
}
