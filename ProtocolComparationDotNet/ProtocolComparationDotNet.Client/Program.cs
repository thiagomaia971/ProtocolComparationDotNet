using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ProtocolComparationDotNet.Domain.Entities;

namespace ProtocolComparationDotNet.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001");
                var vendas = await GetVendas(client);
                foreach (var venda in vendas)
                {
                    var produtos = await GetProdutos(client, venda.Id);
                }
            }
            Console.ReadKey();
        }

        private static async Task<IEnumerable<Venda>> GetVendas(HttpClient client)
            => await Get<IEnumerable<Venda>>(client, "api/venda");

        private static async Task<IEnumerable<Produto>> GetProdutos(HttpClient client, int id)
            => await Get<IEnumerable<Produto>>(client, $"api/venda/{id}/produtos");

        private static async Task<T> Get<T>(HttpClient client, string url)
        {
            var httpResponseMessage = await client.GetAsync(url);
            var task = await httpResponseMessage.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(task);
        }
    }
}
