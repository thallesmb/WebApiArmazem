using Microsoft.AspNetCore.Mvc;
using WebApiArmazem.Data;
using WebApiArmazem.DTO.Produto;
using WebApiArmazem.Models;

namespace WebApiArmazem.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<ProdutoModel>> BuscarProdutos()
        {
            var produtos = _context.Produtos.ToList();

            return Ok(produtos);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProdutoModel> BuscarProdutosPorId(int id)
        {
            var produtos = _context.Produtos.Find(id);

            if (produtos == null)
                return NotFound("Registro não localizado!");

            return Ok(produtos);
        }

        [HttpPost]
        public ActionResult<ProdutoModel> CriarProduto(ProdutoCriacaoModel produtoCriacaoModel)
        {
            if (produtoCriacaoModel == null)
                return BadRequest("Ocorreu um erro na solicitação.");

            var novoProduto = new ProdutoModel
            {
                Nome = produtoCriacaoModel.Nome,
                Descricao = produtoCriacaoModel.Descricao,
                QuantidadeEstoque = produtoCriacaoModel.QuantidadeEstoque,
                CodigoDeBarras = produtoCriacaoModel.CodigoDeBarras,
                Marca = produtoCriacaoModel.Marca
            };

            _context.Produtos.Add(novoProduto);
            _context.SaveChanges();

            return CreatedAtAction(nameof(BuscarProdutosPorId), new { id = novoProduto.Id }, novoProduto);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<ProdutoModel> EditarProduto(ProdutoEdicaoModel produtoEdicaoModel, int id)
        {
            var produtos = _context.Produtos.Find(id);

            if (produtos == null)
                return NotFound("Registro não localizado!");

            produtos.Nome = produtoEdicaoModel.Nome;
            produtos.Descricao = produtoEdicaoModel.Descricao;
            produtos.QuantidadeEstoque = produtoEdicaoModel.QuantidadeEstoque;
            produtos.CodigoDeBarras = produtoEdicaoModel.CodigoDeBarras;
            produtos.Marca = produtoEdicaoModel.Marca;

            _context.Produtos.Update(produtos);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<ProdutoModel> DeletarProduto(int id)
        {
            var produtos = _context.Produtos.Find(id);

            if (produtos == null)
                return NotFound("Registro não localizado!");

            _context.Produtos.Remove(produtos);
            _context.SaveChanges();

            return NoContent();
        }
    }
}