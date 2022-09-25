using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Context;

namespace ProjetoAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class VendaController : ControllerBase
    {
        private VendaContext _context;

        [HttpPost("RegistrarVenda")]
        public IActionResult RegistrarVenda()
        {
            _context = new VendaContext();

            var pedido = _context.AdicionarVenda();

            var dados = new
            {
                pedido = pedido,
            };

            return Ok(dados);
        }

        [HttpGet("BuscarVenda/{id}")]
        public IActionResult BuscarVenda(int id)
        {
            _context = new VendaContext();

            var pedidos = _context.BuscarVendaPorId(id);

            var dados = new
            {
                pedido = pedidos,
            };

            return Ok(dados);
        }

        [HttpPut("AtualizarVenda/{id}")]
        public IActionResult AtualizarVenda(int id)
        {
            _context = new VendaContext();

            var pedido = _context.AtualizarVendaPorId(id);

            var dados = new
            {
                pedido = pedido,
            };

            return Ok(dados);
        }
    }
}
