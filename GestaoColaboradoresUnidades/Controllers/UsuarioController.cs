using GestaoColaboradoresUnidades.Model;
using GestaoColaboradoresUnidades.Services.Interfaces;
using GestaoColaboradoresUnidades.ViewModel;
using Microsoft.AspNetCore.Mvc;
using static GestaoColaboradoresUnidades.Services.Interfaces.IUsuarioRepository;

namespace GestaoColaboradoresUnidades.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        [HttpPost]
        public IActionResult Add(UsuarioViewModel usuarioView)
        {
            var usuario = new Usuario(usuarioView.Login, usuarioView.Senha, usuarioView.Status);
            _usuarioRepository.Add(usuario);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateUsuarioDto updateUsuarioDto)
        {
            try
            {
                _usuarioRepository.Update(id, updateUsuarioDto.Senha, updateUsuarioDto.Status);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var usuarios = _usuarioRepository.GetAll();
            return Ok(usuarios);
        }

        [HttpGet("{status}")]
        public IActionResult GetByStatus(bool status)
        {
            var usuarios = _usuarioRepository.GetByStatus(status);
            return Ok(usuarios);
        }   

    }
}
