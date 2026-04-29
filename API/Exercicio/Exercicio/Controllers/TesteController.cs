using Exercicio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto {Id = 1, Nome = "Notebook", Quantidade = 15},
            new Produto {Id = 2, Nome = "Mouse", Quantidade = 25},
            new Produto {Id = 3, Nome = "Teclado", Quantidade = 30}
        };

        // ✅ GET - 200 OK
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return Ok(produtos);
        }

        // ✅ GET por ID - 200 ou 404
        [HttpGet("{id}")]
        public ActionResult<Produto> GetId(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        // ✅ POST - 201 ou 400
        [HttpPost]
        public ActionResult<Produto> Post([FromBody] Produto novoProduto)
        {
            if (string.IsNullOrEmpty(novoProduto.Nome) || novoProduto.Quantidade < 0)
                return BadRequest("Dados inválidos");

            novoProduto.Id = produtos.Max(p => p.Id) + 1;
            produtos.Add(novoProduto);

            return CreatedAtAction(nameof(GetId), new { id = novoProduto.Id }, novoProduto);
        }

        // ✅ PUT - 200, 404 ou 400
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Produto produtoAtualizado)
        {
            var produtoExistente = produtos.FirstOrDefault(p => p.Id == id);

            if (produtoExistente == null)
                return NotFound();

            if (string.IsNullOrEmpty(produtoAtualizado.Nome) || produtoAtualizado.Quantidade < 0)
                return BadRequest("Dados inválidos");

            produtoExistente.Nome = produtoAtualizado.Nome;
            produtoExistente.Quantidade = produtoAtualizado.Quantidade;

            return Ok(produtoExistente);
        }

        // ✅ DELETE - 204 ou 404
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
                return NotFound();

            produtos.Remove(produto);

            return NoContent();
        }
    }
}