using BACK.Data;
using BACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace BACK.Controllers
{
    [ApiController]
    [Route("/cards")]
    public class CardController : ControllerBase
    {
        private readonly KanbanContext _context;
        public CardController(KanbanContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Cards);
        }

        [HttpPost]
        public IActionResult Post(Card card)
        {
            return Ok($"Método POST de CardController.cs\n{card.Id}, {card.Titulo}");
        }

        [HttpPut]
        public IActionResult Put(int id, Card card)
        {
            return Ok($"Método PUT da classe CardController.cs\n{id}, {card.Id}, {card.Titulo}");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok($"Método DELETE da classe Controller.cs\nId a ser deletado: {id}");
        }
    }
}