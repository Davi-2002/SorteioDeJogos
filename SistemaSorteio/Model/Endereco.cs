using System.Text.Json.Serialization;

namespace SistemaSorteio.Model
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; } = string.Empty;

        [JsonPropertyName("logradouro")]
        public string Rua { get; set; } = string.Empty;

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; } = string.Empty;

        [JsonPropertyName("localidade")]
        public string Cidade { get; set; } = string.Empty;

        [JsonPropertyName("uf")]
        public string Estado { get; set; } = string.Empty;
    }
}
