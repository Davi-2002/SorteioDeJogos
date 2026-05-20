using Dapper;
using SistemaSorteio.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace SistemaSorteio.DAL
{
    public static class UsuarioDAL
    {
        private readonly static string stringDeConexao = ConfigurationManager.ConnectionStrings["ConexaoBanco"].ConnectionString;
        public static int Salvar(Usuario usuario, Endereco endereco)
        {
            string cepBuscado = BuscarCep(usuario.Cep);
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                conexao.Open();
                if(cepBuscado == null)
                    conexao.Execute("INSERT INTO endereco(cd_cep, nm_cidade, nm_estado, nm_rua, nm_bairro)\r\nVALUES(@Cep, @Cidade, @Estado, @Rua, @Bairro)", endereco);
                
                return conexao.QuerySingle<int>("INSERT INTO usuario(nm_usuario, nm_email, cd_senha, cd_telefone, ic_admin, cd_cep, cd_numero, ds_complemento)\r\nVALUES(@Nome, @Email, @Senha, @Telefone, @Admin, @Cep, @Numero, @Complemento); SELECT SCOPE_IDENTITY();", usuario);
            }
        }

        public static Usuario Login(string nome, string senha)
        {
            Usuario tentativaLogin = null;
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                conexao.Open();

                string comandoSql = @"
                    SELECT 
                        cd_usuario AS IdUsuario, 
                        nm_usuario AS Nome, 
                        nm_email AS Email, 
                        cd_senha AS Senha, 
                        cd_telefone AS Telefone, 
                        ic_admin AS Admin, 
                        cd_cep AS Cep,
                        cd_numero AS Numero,
                        ds_complemento AS Complemento
                    FROM usuario 
                    WHERE nm_usuario = @Nome AND cd_senha = @Senha";

                tentativaLogin = conexao.QueryFirstOrDefault<Usuario>(comandoSql, new { Nome = nome, Senha = senha });
            }

            return tentativaLogin;
        }

        public static void Editar(Usuario usuario, Endereco endereco)
        {
            string cepBuscado = BuscarCep(usuario.Cep);
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = "UPDATE usuario SET nm_usuario = @Nome, nm_email = @Email, cd_telefone = @Telefone, cd_cep = @Cep, cd_numero = @Numero, ds_complemento = @Complemento";

                if(!string.IsNullOrWhiteSpace(usuario.Senha))
                {
                    comandoSql += ", cd_senha = @Senha";
                }

                comandoSql += " WHERE cd_usuario = @IdUsuario;";

                conexao.Open();
                if (cepBuscado == null)
                    conexao.Execute("INSERT INTO endereco(cd_cep, nm_cidade, nm_estado, nm_rua, nm_bairro)\r\nVALUES(@Cep, @Cidade, @Estado, @Rua, @Bairro)", endereco);

                conexao.Execute(comandoSql, usuario);
            }
        }

        public static void Apagar(int idUsuario)
        {
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = @"
                                    DELETE FROM usuario_sorteio WHERE cd_sorteio IN (SELECT cd_sorteio FROM sorteio WHERE cd_usuario = @IdUsuario);
                                    DELETE FROM usuario_sorteio WHERE cd_usuario = @IdUsuario;
                                    DELETE FROM sorteio WHERE cd_usuario = @IdUsuario;
                                    DELETE FROM usuario WHERE cd_usuario = @IdUsuario;";

                conexao.Execute(comandoSql, new { IdUsuario = idUsuario });
            }
        }

        public static bool BuscarNome(string nomeUsuario, int idUsuarioAtual)
        {
            int idUsuario;
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                idUsuario = conexao.QueryFirstOrDefault<int>("SELECT cd_usuario FROM usuario WHERE nm_usuario = @NomeUsuario AND cd_usuario != @IdUsuarioAtual", new { NomeUsuario = nomeUsuario, IdUsuarioAtual = idUsuarioAtual });
            }

            return idUsuario != 0;
        }

        public static bool BuscarEmail(string email, int idUsuarioAtual)
        {
            int idUsuario;
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                idUsuario = conexao.QueryFirstOrDefault<int>("SELECT cd_usuario FROM usuario WHERE nm_email = @Email AND cd_usuario != @IdUsuarioAtual", new { Email = email, IdUsuarioAtual = idUsuarioAtual });
            }

            return idUsuario != 0;
        }
        public static string BuscarCep(string cep)
        {
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                return conexao.QueryFirstOrDefault<string>("SELECT cd_cep FROM endereco WHERE cd_cep  = @Cep", new { Cep = cep });
            }
        }
    }
}





