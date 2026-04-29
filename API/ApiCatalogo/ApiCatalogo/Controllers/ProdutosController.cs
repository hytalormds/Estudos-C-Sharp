using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 Listar produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            var produtos = await _context.Produtos
                .AsNoTracking()
                .ToListAsync();

            return Ok(produtos);
        }

        // 🔹 Buscar por ID
        [HttpGet("{id:int}", Name = "ObterProduto")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var produto = await _context.Produtos
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProdutoId == id);

            if (produto is null)
                return NotFound("Produto não encontrado");

            return Ok(produto);
        }

        // 🔹 Criar
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Produto produto)
        {
            if (produto is null)
                return BadRequest();

            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("ObterProduto",
                new { id = produto.ProdutoId }, produto);
        }

        // 🔹 Atualizar
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
                return BadRequest();

            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(produto);
        }

        // 🔹 Deletar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto is null)
                return NotFound("Produto não encontrado");

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return Ok(produto);
        }
    }
}