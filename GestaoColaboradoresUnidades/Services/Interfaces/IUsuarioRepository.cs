using GestaoColaboradoresUnidades.Model;
using static GestaoColaboradoresUnidades.Services.Implementations.UsuarioRepository;

namespace GestaoColaboradoresUnidades.Services.Interfaces
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);
        List<UsuarioDto> GetAll();
        List<UsuarioDto> GetByStatus(bool status);
        void Update(int id, string senha, bool status);

        public class UpdateUsuarioDto
        {
            public string Senha { get; set; }
            public bool Status { get; set; }
        }

    }
}