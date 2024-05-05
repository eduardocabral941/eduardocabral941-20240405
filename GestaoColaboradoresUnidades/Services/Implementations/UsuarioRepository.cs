using GestaoColaboradoresUnidades.Data;
using GestaoColaboradoresUnidades.Model;
using GestaoColaboradoresUnidades.Services.Interfaces;

namespace GestaoColaboradoresUnidades.Services.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ConectionContext _context = new ConectionContext();

        public class UsuarioDto
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public bool Status { get; set; }
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public List<UsuarioDto> GetAll()
        {
            return _context.Usuarios.Select(u => new UsuarioDto
            {
                Id = u.Id,
                Login = u.Login,
                Status = u.Status
            }).ToList();
        }

        public List<UsuarioDto> GetByStatus(bool status)
        {
            return _context.Usuarios.Where(u => u.Status == status).Select(u => new UsuarioDto
            {
                Login = u.Login,
                Status = u.Status
            }).ToList();
        }

        public void Update(int id, string senha, bool status)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                usuario.AlterarSenha(senha);
                usuario.AlterarStatus(status);
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
            }
           

        }

    }
}
