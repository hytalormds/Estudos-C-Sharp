using ApiCatalogo.Context;
using ApiCatalogo.Filters;
using ApiCatalogo.Models;
using ApiCatalogo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMeuServico _meuServico;
        private readonly IConfiguration _configuration;

        public CategoriasController(
            AppDbContext context,
            IMeuServico meuServico,
            IConfiguration configuration)
        {
            _context = context;
            _meuServico = meuServico;
            _configuration = configuration;
        }

        // 🔹 Lendo configurações
        [HttpGet("config")]
        public ActionResult<string> GetValores()
        {
            var valor1 = _configuration["chave1"];
            var valor2 = _configuration["chave2"];
            var secao1 = _configuration["secao1:chave2"];

            return Ok($"Valor1: {valor1}, Valor2: {valor2}, Secao1: {secao1}");
        }

        // 🔹 Usando serviço via construtor
        [HttpGet("saudacao/{nome}")]
        public ActionResult<string> GetSaudacao(string nome)
        {
            return Ok(_meuServico.Saudacao(nome));
        }

        // 🔹 Listar categorias com produtos
        [HttpGet("produtos")]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoriasProdutos()
        {
            var categorias = await _context.Categorias
                .Include(c => c.Produtos)
                .AsNoTracking()
                .ToListAsync();

            return Ok(categorias);
        }

        // 🔹 Listar categorias
        [HttpGet]
        [ServiceFilter(typeof(ApiLoggingFilter))]
        public async Task<ActionResult<IEnumerable<Categoria>>> Get()
        {
            try
            {
                var categorias = await _context.Categorias
                    .AsNoTracking()
                    .ToListAsync();

                return Ok(categorias);
            }
            catch
            {
                return StatusCode(500, "Erro ao obter categorias");
            }
        }

        // 🔹 Buscar por ID
        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            var categoria = await _context.Categorias
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CategoriaId == id);

            if (categoria is null)
                return NotFound("Categoria não encontrada");

            return Ok(categoria);
        }

        // 🔹 Criar
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Categoria categoria)
        {
            if (categoria is null)
                return BadRequest();

            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtRoute("ObterCategoria",
                new { id = categoria.CategoriaId }, categoria);
        }

        // 🔹 Atualizar
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
                return BadRequest();

            _context.Entry(categoria).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(categoria);
        }

        // 🔹 Deletar
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria is null)
                return NotFound("Categoria não encontrada");

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return Ok(categoria);
        }
    }
}