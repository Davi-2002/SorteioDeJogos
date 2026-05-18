using System;

namespace SistemaSorteio.Model
{
    public class Sorteio
    {
        public int IdSorteio { get; set; }
        public DateTime DataLimite { get; set; } = DateTime.Now;
        public int IdUsuarioAdmin { get; set; }
        public int IdJogo { get; set; }
    }
}
