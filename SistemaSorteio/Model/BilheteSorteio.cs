namespace SistemaSorteio.Model
{
    public class BilheteSorteio
    {
        public int IdUsuario { get; set; }
        public int IdSorteio { get; set; }
        public int NumeroBilhete { get; set; }
        public bool IsVencedor { get; set; } = false;
    }
}
