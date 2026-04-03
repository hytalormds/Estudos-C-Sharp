using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        // FONTE DE DADOS
        var listaProdutos = new List<Produto>()
        {
            new Produto {Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 10},
            new Produto {Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
            new Produto {Id = 4, CategoriaId = 1, Nome = "Maquina de lavar", Status = false, Valor = 32},
            new Produto {Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99},
            new Produto {Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
            new Produto {Id = 8, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45},
            new Produto {Id = 4, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
            new Produto {Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90},
            new Produto {Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12},
        };

        var listaCategorias = new List<Categoria>()
        {
            new Categoria {Id = 1, Status = true, Nome="Eletronics"},
            new Categoria {Id = 2, Status = true, Nome="Alimentos"},
            new Categoria {Id = 3, Status = true, Nome="Vestuario"},
        };

        //first

        //var resultado = listaProdutos.First();
        //Console.WriteLine($"Nome: {resultado.Nome} | Id: {resultado.Id}");

        //firstOrDefault

        //var resultado = listaProdutos.FirstOrDefault();
        //Console.WriteLine($"Nome: {resultado.Nome} | Id: {resultado.Id}");

        //last

        //var resultado = listaProdutos.Last();
        //Console.WriteLine($"Nome: {resultado.Nome} | Id: {resultado.Id}");

        //single

        //var resultado = listaProdutos.Single(x => x.Id == 50);
        //Console.WriteLine($"Nome: {resultado.Nome} | Id: {resultado.Id}");

        // singleOrDefault

        //var resultado = listaProdutos.SingleOrDefault(x => x.Id == 4);
        //Console.WriteLine($"Nome: {resultado.Nome} | Id: {resultado.Id}");

        // where
        //var resultado = listaProdutos.Where(p => p.Id >= 2 & p.Id <= 5);

        // order by
        //resultado = resultado.OrderBy(p => p.Id);

        // order by descending
        //resultado = resultado.OrderByDescending(p => p.Id);

        // revert
        //resultado = resultado.Reverse();

        //select

        var listaResposta = new List<ProdutoResponse>();
        
        foreach(var produto in listaProdutos)
        {

        }
        //var result = from prod in listaProdutos
        //             join cat in listaCategorias
        //             on prod.CategoriaId equals cat.Id
        //             select new
        //             {
        //                 Produto = prod,
        //                 Categoria = cat,
        //             };

        //foreach (var item in result)
        //{
        //    Console.WriteLine($"Produto: {item.Produto.Nome} | Categoria: {item.Categoria.Nome}");
        //}

        // LINQ com projeção (DTO)
        //var resultado = from produto in listaProdutos
        //               select new ProdutoDto
        //                {
        //                    Nome = produto.Nome.ToUpper(),
        //                   Valor = produto.Valor + 10,
        //                    Status = produto.Status
        //                };

        // 🔥 Exibindo resultado
        //foreach (var item in resultado)
        //{
        //    Console.WriteLine($"Nome: {item.Nome} | Valor: {item.Valor} | Status: {item.Status}");
        //}
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
    }

    class Categoria
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Nome { get; set; }
    }

    class ProdutoDto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
    }

    class ProdutoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}