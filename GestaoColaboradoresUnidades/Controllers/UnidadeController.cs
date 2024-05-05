using GestaoColaboradoresUnidades.Model;
using GestaoColaboradoresUnidades.Services.Interfaces;
using GestaoColaboradoresUnidades.ViewModel;
using Microsoft.AspNetCore.Mvc;
using static GestaoColaboradoresUnidades.Services.Interfaces.IUnidadeRepository;

namespace GestaoColaboradoresUnidades.Controllers
{
    [ApiController]
    [Route("api/unidades")]
    public class UnidadeController : ControllerBase
    {
        private readonly IUnidadeRepository _unidadesRepository;

        public UnidadeController(IUnidadeRepository unidadesRepository)
        {
            _unidadesRepository = unidadesRepository ?? throw new ArgumentNullException(nameof(unidadesRepository));
        }

        [HttpPost]
        public IActionResult Add(UnidadeViewModel unidadeView)
        {
            var unidade = new Unidade(unidadeView.CodigoUnidade, unidadeView.Nome, unidadeView.Status );
            _unidadesRepository.Add(unidade);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateUnidadesDto updateUnidadesDto)
        {
            try
            {
                _unidadesRepository.Update(id, updateUnidadesDto.Status);
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
            var unidades = _unidadesRepository.GetAll();
            return Ok(unidades);
        }

    }
}
