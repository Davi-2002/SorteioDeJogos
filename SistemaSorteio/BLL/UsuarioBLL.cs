using SistemaSorteio.DAL;
using SistemaSorteio.Model;
using SistemaSorteio.Service;

namespace SistemaSorteio.BLL
{
    public static class UsuarioBLL
    {
        public static Usuario FazerLogin(string nome, string senha)
        {
            CadastroBLL.ValidaLogin(nome, senha);

            if (Erro.getErro())
            {
                return null;
            }

            string senhaFinal = Criptografia.Encriptar(senha);
            return UsuarioDAL.Login(nome, senhaFinal);
        }

        public static bool EditarUsuario(Usuario usuario, Endereco endereco)
        {
            CadastroBLL.ValidaCadastro(usuario.IdUsuario, usuario.Nome, usuario.Senha, usuario.Email, usuario.Telefone, usuario.Cep, endereco.Cidade, usuario.Numero, usuario.Complemento);

            if (Erro.getErro())
            {
                return false;
            }

            if(!string.IsNullOrWhiteSpace(usuario.Senha))
                usuario.Senha = Criptografia.Encriptar(usuario.Senha);

            UsuarioDAL.Editar(usuario, endereco);
            return true;
        }

        public static void ApagarUsuario(int idUsuario)
        {
            UsuarioDAL.Apagar(idUsuario);
        }
    }
}
