using System;

namespace SistemaSorteio.Model.DTO
{
    public class MeusSorteiosDTO
    {
        public string NomeJogo { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string StatusSorteio { get; set; } = "Aberto";
        public DateTime DataLimite { get; set; } = DateTime.Now;
        public int IdSorteio { get; set; }
        public int IdJogo { get; set; }
        public int QtdParticipantes { get; set; }
        public int Vencedor { get; set; }
    }
}
