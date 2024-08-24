using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using TemplateBlazor.Models;

namespace TemplateBlazor.Services
{
    public class ImovelService
    {
        private readonly HttpClient _httpClient;

        public ImovelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Imovel>> GetImoveisAsync()
        {
            // Exemplo estático para demonstração
            return await Task.FromResult(new List<Imovel>
            {
                new Imovel
                {
                    Tipo = "Apartamento",
                    Estado = "SP",
                    Cidade = "São Paulo",
                    Bairro = "Centro",
                    Quartos = 3,
                    Preco = 500000,
                    Banheiros = 2,
                    Endereco = "Rua ABC, 123",
                    ImagemUrl = "https://example.com/imagem.jpg",
                    SuperDestaque = true
                },
                // Adicione mais imóveis para teste
            });
        }

        public async Task<List<string>> GetTiposAsync()
        {
            return await Task.FromResult(new List<string> { "Apartamento", "Casa", "Terreno" });
        }

        public async Task<List<string>> GetEstadosAsync()
        {
            return await Task.FromResult(new List<string> { "SP", "RJ", "MG" });
        }

        public async Task<List<string>> GetCidadesAsync()
        {
            return await Task.FromResult(new List<string> { "São Paulo", "Rio de Janeiro", "Belo Horizonte" });
        }

        public async Task<List<string>> GetBairrosAsync()
        {
            return await Task.FromResult(new List<string> { "Centro", "Zona Sul", "Zona Norte" });
        }
    }
}
