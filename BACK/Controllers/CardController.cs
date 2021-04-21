using BACK.Data;
using BACK.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BACK.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/cards")]
    public class CardController : ControllerBase
    {
        private readonly IRepository _repository;

        public CardController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAllCards());
        }

        [HttpPost]
        public IActionResult Post(Card card)
        {
            if(!card.CamposValidos())
                return BadRequest("Erro 400: Campos não podem ser nulos ou vazios.");

            _repository.Add(card);
            if(_repository.SaveChanges()) return Ok(card);

            return BadRequest("Card não inserido.");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Card card)
        {
            if(!card.CamposValidos()) return BadRequest("Erro 400: Campos não podem ser nulos ou vazios.");

            if(id != card.Id) return BadRequest("Erro 400: Id na URL deve ser igual ao Id passado no corpo da requisição.");

            if(_repository.GetCardById(id) == null) return NotFound("Erro 404: Id não encontrado.");

            _repository.Update(card);
            if(_repository.SaveChanges())
            {
                card.RegistrarAtividade("alterar");
                return Ok(card);
            } 
                

            return BadRequest("Card não atualizado.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var card = _repository.GetCardById(id);

            if(card == null) return NotFound("Erro 404: Id não encontrado.");

            _repository.Delete(card);
            if(_repository.SaveChanges())
            {
                card.RegistrarAtividade("remover");
                return Ok(_repository.GetAllCards());
            } 

            return BadRequest("Card não deletado.");
        }
    }
}