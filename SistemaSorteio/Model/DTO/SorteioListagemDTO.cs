using System;

namespace SistemaSorteio.Model.DTO
{
    public class SorteioListagemDTO
    {
        public string NomeUsuario { get; set; } = string.Empty;
        public string NomeJogo { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public DateTime DataLimite { get; set; } = DateTime.Now;
        public int IdSorteio { get; set; }
        public int IdJogo { get; set; }
        public int QtdParticipantes { get; set; }
    }
}
