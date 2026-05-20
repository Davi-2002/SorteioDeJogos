using SistemaSorteio.DAL;
using SistemaSorteio.Model;
using SistemaSorteio.Service;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaSorteio.BLL
{
    public class CadastroBLL
    {
        public static void ValidaCadastro(int idUsuarioAtual, string nomeUsuario, string senhaUsuario, string email, string telefone, string cep, string cidade, string numero, string complemento)
        {
            //NOME
            Erro.setErro(false);
            if (string.IsNullOrWhiteSpace(nomeUsuario))
            {
                Erro.setErro("O NOME DO USUÁRIO é de preenchimento obrigatório");
                return;
            }
            else if (!Regex.IsMatch(nomeUsuario, "^[a-zA-Z_0-9-]+$"))
            {
                Erro.setErro("digite um nome de usuário válido");
                return;
            }
            else if (nomeUsuario.Length > 180)
            {
                Erro.setErro("O nome de usuário não pode ter mais de 180 caracteres.");
                return;
            }
            else if(UsuarioDAL.BuscarNome(nomeUsuario, idUsuarioAtual))
            {
                Erro.setErro($"O nome de usuário: \"{nomeUsuario.ToUpper()}\" já existe");
                return;
            }

            //EMAIL
            if (email.Length == 0)
            {
                Erro.setErro("O email é de preenchimento obrigatório");
                return;
            }
            else if (!Regex.IsMatch(email, "^.+@.+\\.(com|com\\.br|br|edu|org|net)$"))
            {
                Erro.setErro("O email precisa ser válido");
                return;
            }
            else if (email.Length > 200)
            {
                Erro.setErro("O email não pode ter mais de 200 caracteres.");
                return;
            }
            else if (UsuarioDAL.BuscarEmail(email, idUsuarioAtual))
            {
                Erro.setErro($"O email: \"{email}\" já existe");
                return;
            }

            //SENHA
            if (idUsuarioAtual == 0)
            {
                if (string.IsNullOrWhiteSpace(senhaUsuario))
                {
                    Erro.setErro("A senha é de preenchimento obrigatório");
                    return;
                }
                else if(senhaUsuario.Length < 4)
                {
                    Erro.setErro("A senha precisa ter no mínimo 4 digitos");
                    return;
                }
            }
            if (senhaUsuario.Length > 100)
            {
                Erro.setErro("A senha não pode ter mais de 100 caracteres.");
                return;
            }

            //TELEFONE
            if (!Regex.IsMatch(telefone, "^\\([0-9]{2}\\) [0-9]{5}-[0-9]{4}$"))
            {
                Erro.setErro("O número de telefone precisa ser válido");
                return;
            }

            //CEP
            if(cidade.Length == 0)
            {
                Erro.setErro("Insira um CEP válido");
                return;
            }
            else if(!Regex.IsMatch(cep, "^[0-9]{5}-[0-9]{3}$"))
            {
                Erro.setErro("O formato do CEP está incorreto");
                return;
            }

            //NUMERO
            if (string.IsNullOrWhiteSpace(numero))
            {
                Erro.setErro("O Número é de preenchimento obrigatório");
                return;
            }
            else if (!Regex.IsMatch(numero, "^[0-9]+$"))
            {
                Erro.setErro("Insira um Número válido");
                return;
            }
            else if(int.Parse(numero) > 32500)
            {
                Erro.setErro("O Número não pode ultrapassar 32500 digitos");
                return;
            }

            //COMPLEMENTO
            if (complemento.Length >= 300)
            {
                Erro.setErro("O Complemento não pode ultrapassar 300 caracteres");
                return;
            }
        }
        public static void ValidaLogin(string nomeUsuario, string senhaUsuario)
        {
            //NOME
            Erro.setErro(false);
            if (string.IsNullOrWhiteSpace(nomeUsuario))
            {
                Erro.setErro("O NOME DO USUÁRIO é de preenchimento obrigatório");
                return;
            }
            else if (!Regex.IsMatch(nomeUsuario, "^[a-zA-Z_0-9-]+$"))
            {
                Erro.setErro("digite um nome de usuário válido");
                return;
            }


            //SENHA
            if (string.IsNullOrWhiteSpace(senhaUsuario))
            {
                Erro.setErro("A senha é de preenchimento obrigatório");
                return;
            }
        }

        public static void ValidaTextoCep(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool CadastrarUsuario(Usuario usuario, Endereco endereco)
        {
            ValidaCadastro(usuario.IdUsuario, usuario.Nome, usuario.Senha, usuario.Email, usuario.Telefone, usuario.Cep, endereco.Cidade, usuario.Numero, usuario.Complemento);

            if (Erro.getErro())
            {
                return false;
            }

            usuario.Senha = Criptografia.Encriptar(usuario.Senha);
            int idUsuario = UsuarioDAL.Salvar(usuario, endereco);
            usuario.IdUsuario = idUsuario;

            return true;
        }
    }
}
