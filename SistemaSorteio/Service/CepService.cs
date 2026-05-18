using SistemaSorteio.Model;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSorteio.Service
{
    public static class CepService
    {
        static HttpClient busca = new HttpClient();

        public static async Task<Endereco> Buscar(string cepParaBuscar)
        {
            string url = $"https://viacep.com.br/ws/{cepParaBuscar}/json/";
            HttpResponseMessage resposta = await busca.GetAsync(url);
            string json = await resposta.Content.ReadAsStringAsync();
            Endereco enderecoAutomatico = JsonSerializer.Deserialize<Endereco>(json);
            return enderecoAutomatico;
        }
    }
}
