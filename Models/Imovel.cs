namespace TemplateBlazor.Models
{
    public class Imovel
    {
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int Quartos { get; set; }
        public decimal Preco { get; set; }
        public int Banheiros { get; set; }
        public string Endereco { get; set; }
        public string ImagemUrl { get; set; }
        public bool SuperDestaque { get; set; }
    }
}
