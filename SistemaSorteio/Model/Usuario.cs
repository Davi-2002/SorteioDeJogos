namespace SistemaSorteio.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public bool Admin { get; set; } = false;
        public string Cep { get; set; } = string.Empty;

        public Usuario(string nome, string email, string senha, string telefone, bool admin, string cep)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Admin = admin;
            Cep = cep;
        }

        public Usuario() { }
    }
}
