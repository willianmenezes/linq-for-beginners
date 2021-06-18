using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // fonte de dados
            var categorias = new List<Categoria>()
            {
                new Categoria() { Id = 1, Nome = "Esporte" },
                new Categoria() { Id = 2, Nome = "Alimento" },
                new Categoria() { Id = 3, Nome = "Eletronicos" },
            };

            var produtos = new List<Produto>()
            {
                new Produto() { Id = 1, Nome = "Camisa Flamengo", CategoriaId = 1 },
                new Produto() { Id = 2, Nome = "PS5", CategoriaId = 3 },
                new Produto() { Id = 3, Nome = "Carne", CategoriaId = 2 },
                new Produto() { Id = 4, Nome = "Camisa Cruzeiro", CategoriaId = 1 },
                new Produto() { Id = 5, Nome = "Feijão", CategoriaId = 2 },
                new Produto() { Id = 6, Nome = "PC Gamer", CategoriaId = 3 },
            };

            // consulta linq

            //var itens = from produto in produtos select produto;

            //var itens = from produto in produtos 
            //            where produto.CategoriaId == 1
            //            select produto;

            //var itens = from produto in produtos
            //            where produto.Nome.Substring(0, 1) == "P"
            //            select produto;

            //var itens = from produto in produtos
            //            where produto.Id == 1 || produto.Id == 2
            //            select produto;

            //var itens = from produto in produtos
            //            select new { Id = produto.Id, Nome = produto.Nome }; 

            //var itens = from produto in produtos
            //            select new { IdNome = $"{produto.Id} | {produto.Nome}" };

            //var itens = from produto in produtos
            //            orderby produto.Id 
            //            select produto;

            //var itens = from produto in produtos
            //            orderby produto.Id descending
            //            select produto;

            //var itens = from produto in produtos
            //            orderby produto.Nome.Substring(0, 1), produto.Id
            //            select produto;

            //var itens = from produto in produtos
            //            join categoria in categorias
            //            on produto.CategoriaId equals categoria.Id
            //            orderby produto.Nome.Substring(0, 1), categoria.Nome.Substring(0, 1)
            //            select new { NomeProduto = produto.Nome, NomeCategoria = categoria.Nome };  

            //var itens = from produto in produtos
            //            join categoria in categorias
            //            on produto.CategoriaId equals categoria.Id
            //            where produto.Id == 1 || categoria.Id == 1
            //            orderby produto.Nome
            //            select new { NomeProduto = produto.Nome, NomeCategoria = categoria.Nome };

            //foreach (var item in itens)
            //{
            //    Console.WriteLine($"{item.NomeProduto} | {item.NomeCategoria}");
            //}
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
    }

    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
