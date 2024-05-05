using GestaoColaboradoresUnidades.Model;

namespace GestaoColaboradoresUnidades.Services.Interfaces
{
    public interface IUnidadeRepository
    {
        void Add(Unidade unidade);

        void Update(int id, bool status);

        List<Unidade> GetAll();

        public class UpdateUnidadesDto
        {
            public bool Status { get; set; }
        }
    }
}