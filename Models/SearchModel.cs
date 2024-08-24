using System.ComponentModel.DataAnnotations;

namespace TemplateBlazor.Models
{
    public class SearchModel
    {
        public string Negocio { get; set; } // Tipo de negócio: Comprar, Vender, Alugar

        public string Tipo { get; set; } // Tipo de imóvel: Apartamento, Casa, etc.

        public string Estado { get; set; } // Estado selecionado
        public string Cidade { get; set; } // Cidade selecionada

        public string Bairro { get; set; } // Bairro selecionado

        public string Quartos { get; set; } // Número de quartos

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid value")]
        public string ValorMedio { get; set; } // Valor médio

        public string BuscaEndereco { get; set; } // Endereço ou empreendimento
    }
}
