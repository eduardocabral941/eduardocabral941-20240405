using GestaoColaboradoresUnidades.Model;

namespace GestaoColaboradoresUnidades.Services.Interfaces
{
    public interface IColaboradorRepository
    {
        void Add(Colaborador colaborador);
        void Update(int id, string nome, int unidadeid);
        void Remove(int id);
        List<Colaborador> GetAll();

        public class UpdateColaboradoresDto
        {
            public string Nome { get; set; }
            public int UnidadeId { get; set; }
        }
    }
}
