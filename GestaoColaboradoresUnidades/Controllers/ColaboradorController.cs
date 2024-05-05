using GestaoColaboradoresUnidades.Model;
using GestaoColaboradoresUnidades.Services.Interfaces;
using GestaoColaboradoresUnidades.ViewModel;
using Microsoft.AspNetCore.Mvc;
using static GestaoColaboradoresUnidades.Services.Interfaces.IColaboradorRepository;

namespace GestaoColaboradoresUnidades.Controllers
{
    [ApiController]
    [Route("api/colaboradores")]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorRepository _colaboradoresRepository;

        public ColaboradorController(IColaboradorRepository colaboradoresRepository)
        {
            _colaboradoresRepository = colaboradoresRepository ?? throw new ArgumentNullException(nameof(colaboradoresRepository));
        }

        [HttpPost]
        public IActionResult Add(ColaboradorViewModel colaboradorView)
        {
            var colaborador = new Colaborador(colaboradorView.Nome, colaboradorView.UnidadeId, colaboradorView.UserId);
            _colaboradoresRepository.Add(colaborador);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var colaboradores = _colaboradoresRepository.GetAll();
            return Ok(colaboradores);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateColaboradoresDto updateColaboradoresDto)
        {
            try
            {
                _colaboradoresRepository.Update(id, updateColaboradoresDto.Nome, updateColaboradoresDto.UnidadeId);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                _colaboradoresRepository.Remove(id);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
