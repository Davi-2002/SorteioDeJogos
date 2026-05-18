using Dapper;
using SistemaSorteio.Model;
using SistemaSorteio.Model.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SistemaSorteio.DAL
{
    public static class SorteioDAL
    {
        private static readonly string stringDeConexao = ConfigurationManager.ConnectionStrings["ConexaoBanco"].ConnectionString;
        
        public static void Salvar(string nome, string genero, int idUsuario, DateTime data)
        {
            int jogoBuscado = BuscarJogo(nome);
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                conexao.Open();
                if (jogoBuscado == 0)
                    jogoBuscado = conexao.QuerySingle<int>("INSERT INTO jogo(nm_jogo, nm_generoJogo)\r\nVALUES (@Nome, @Genero); SELECT SCOPE_IDENTITY();", new { Nome = nome, Genero = genero });
                
                conexao.Execute("INSERT INTO sorteio(dt_dataLimite, cd_usuario, cd_jogo) VALUES (@DataLimite, @IdUsuario, @IdJogo);", new { DataLimite = data, IdUsuario = idUsuario, IdJogo = jogoBuscado });
            }
        }

        public static List<MeusSorteiosDTO> ListarMeusSorteios(int idUsuario)
        {
            List<MeusSorteiosDTO> listaSorteios = null;

            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = @"
                    SELECT 
                        jogo.cd_jogo AS IdJogo, 
                        jogo.nm_jogo AS NomeJogo, 
                        jogo.nm_generoJogo AS Genero, 
                        sorteio.cd_sorteio AS IdSorteio, 
                        sorteio.dt_dataLimite AS DataLimite, 
                        sorteio.ds_status AS StatusSorteio, 
                        COUNT(usuario_sorteio.cd_usuario) AS QtdParticipantes 
                    FROM jogo 
                    INNER JOIN sorteio ON jogo.cd_jogo = sorteio.cd_jogo 
                    LEFT JOIN usuario_sorteio ON usuario_sorteio.cd_sorteio = sorteio.cd_sorteio 
                    WHERE sorteio.cd_usuario = @IdUsuario 
                    GROUP BY 
                        jogo.cd_jogo,  
                        jogo.nm_jogo, 
                        jogo.nm_generoJogo, 
                        sorteio.cd_sorteio, 
                        sorteio.dt_dataLimite, 
                        sorteio.ds_status
                    ORDER BY sorteio.dt_dataLimite ASC;";

                listaSorteios = conexao.Query<MeusSorteiosDTO>(comandoSql, new { IdUsuario = idUsuario }).ToList();
            }

            return listaSorteios;
        }

        public static List<MeusSorteiosDTO> FiltrarMeusSorteios(int idUsuario, string genero, string nomeJogo, string statusSorteio)
        {
            List<MeusSorteiosDTO> listaSorteios = null;

            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = @"
                    SELECT 
                        jogo.cd_jogo AS IdJogo, 
                        jogo.nm_jogo AS NomeJogo, 
                        jogo.nm_generoJogo AS Genero, 
                        sorteio.cd_sorteio AS IdSorteio, 
                        sorteio.dt_dataLimite AS DataLimite, 
                        sorteio.ds_status AS StatusSorteio, 
                        COUNT(usuario_sorteio.cd_usuario) AS QtdParticipantes 
                    FROM jogo 
                    INNER JOIN sorteio ON jogo.cd_jogo = sorteio.cd_jogo 
                    LEFT JOIN usuario_sorteio ON usuario_sorteio.cd_sorteio = sorteio.cd_sorteio 
                    WHERE sorteio.cd_usuario = @IdUsuario 
                          AND jogo.nm_jogo LIKE '%' + @NomeJogo + '%'
                          AND (@Genero = '' OR jogo.nm_generoJogo = @Genero)
                          AND (@StatusSorteio = '' OR sorteio.ds_status = @StatusSorteio)
                    GROUP BY 
                        jogo.cd_jogo,  
                        jogo.nm_jogo, 
                        jogo.nm_generoJogo, 
                        sorteio.cd_sorteio, 
                        sorteio.dt_dataLimite, 
                        sorteio.ds_status
                    ORDER BY sorteio.dt_dataLimite ASC;";

                listaSorteios = conexao.Query<MeusSorteiosDTO>(comandoSql, new { IdUsuario = idUsuario, Genero = genero, NomeJogo = nomeJogo, StatusSorteio = statusSorteio }).ToList();
            }

            return listaSorteios;
        }

        public static List<SorteioListagemDTO> ListarTodosSorteiosAbertos()
        {
            List<SorteioListagemDTO> listaSorteios = null;

            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = @"
                    SELECT 
                        usuario.nm_usuario AS NomeUsuario,
                        jogo.cd_jogo AS IdJogo, 
                        jogo.nm_jogo AS NomeJogo, 
                        jogo.nm_generoJogo AS Genero, 
                        sorteio.cd_sorteio AS IdSorteio, 
                        sorteio.dt_dataLimite AS DataLimite, 
                        COUNT(usuario_sorteio.cd_usuario) AS QtdParticipantes 
                    FROM jogo 
                    INNER JOIN sorteio ON jogo.cd_jogo = sorteio.cd_jogo 
                    LEFT JOIN usuario_sorteio ON usuario_sorteio.cd_sorteio = sorteio.cd_sorteio  
                    LEFT JOIN usuario ON usuario.cd_usuario = sorteio.cd_usuario
                    WHERE sorteio.ds_status = 'Aberto'
                    GROUP BY 
                        usuario.nm_usuario,
                        jogo.cd_jogo,  
                        jogo.nm_jogo, 
                        jogo.nm_generoJogo, 
                        sorteio.cd_sorteio, 
                        sorteio.dt_dataLimite
                    ORDER BY sorteio.dt_dataLimite ASC;";

                listaSorteios = conexao.Query<SorteioListagemDTO>(comandoSql).ToList();
            }

            return listaSorteios;
        }

        public static List<SorteioListagemDTO> FiltrarSorteiosAbertos(string genero, string nomeJogo)
        {
            List<SorteioListagemDTO> listaSorteios = null;

            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = @"
                    SELECT 
                        usuario.nm_usuario AS NomeUsuario,
                        jogo.cd_jogo AS IdJogo, 
                        jogo.nm_jogo AS NomeJogo, 
                        jogo.nm_generoJogo AS Genero, 
                        sorteio.cd_sorteio AS IdSorteio, 
                        sorteio.dt_dataLimite AS DataLimite, 
                        COUNT(usuario_sorteio.cd_usuario) AS QtdParticipantes 
                    FROM jogo 
                    INNER JOIN sorteio ON jogo.cd_jogo = sorteio.cd_jogo 
                    LEFT JOIN usuario_sorteio ON usuario_sorteio.cd_sorteio = sorteio.cd_sorteio  
                    LEFT JOIN usuario ON usuario.cd_usuario = sorteio.cd_usuario
                    WHERE sorteio.ds_status = 'Aberto'
                          AND jogo.nm_jogo LIKE '%' + @NomeJogo + '%'
                          AND (@Genero = '' OR jogo.nm_generoJogo = @Genero)
                    GROUP BY 
                        usuario.nm_usuario,
                        jogo.cd_jogo,  
                        jogo.nm_jogo, 
                        jogo.nm_generoJogo, 
                        sorteio.cd_sorteio, 
                        sorteio.dt_dataLimite
                    ORDER BY sorteio.dt_dataLimite ASC;";

                listaSorteios = conexao.Query<SorteioListagemDTO>(comandoSql, new { Genero = genero, NomeJogo = nomeJogo }).ToList();
            }

            return listaSorteios;
        }

        public static List<SorteioListagemDTO> ListarSorteiosGanhos(int idUsuario)
        {
            List<SorteioListagemDTO> listaSorteios = null;

            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = @"
                    SELECT 
                        usuario.nm_usuario AS NomeUsuario,
                        jogo.cd_jogo AS IdJogo, 
                        jogo.nm_jogo AS NomeJogo, 
                        jogo.nm_generoJogo AS Genero, 
                        sorteio.cd_sorteio AS IdSorteio,
                        COUNT(usuario_sorteio.cd_usuario) AS QtdParticipantes 
                    FROM jogo 
                    INNER JOIN sorteio ON jogo.cd_jogo = sorteio.cd_jogo 
                    LEFT JOIN usuario_sorteio ON usuario_sorteio.cd_sorteio = sorteio.cd_sorteio  
                    LEFT JOIN usuario ON usuario.cd_usuario = sorteio.cd_usuario
                    WHERE usuario_sorteio.ic_vencedor = 1 AND usuario_sorteio.cd_usuario = @IdUsuario
                    GROUP BY 
                        usuario.nm_usuario,
                        jogo.cd_jogo,  
                        jogo.nm_jogo, 
                        jogo.nm_generoJogo, 
                        sorteio.cd_sorteio;";

                listaSorteios = conexao.Query<SorteioListagemDTO>(comandoSql, new { IdUsuario = idUsuario }).ToList();
            }

            return listaSorteios;
        }

        public static void Sorteado(int bilhete, int idSorteio)
        {
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = @"UPDATE usuario_sorteio SET ic_vencedor = 1 WHERE cd_bilhete = @Bilhete AND cd_sorteio = @IdSorteio; 
                                      UPDATE sorteio SET ds_status = 'Fechado' WHERE cd_sorteio = @IdSorteio;";

                conexao.Execute(comandoSql, new { Bilhete = bilhete, IdSorteio = idSorteio });                
            }
        }

        public static void Editar(string nome, string genero, int idSorteio, DateTime data)
        {
            int jogoBuscado = BuscarJogo(nome);
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoSql = "UPDATE sorteio SET dt_dataLimite = @DataLimite, cd_jogo = @IdJogo WHERE cd_sorteio = @IdSorteio;";

                if(jogoBuscado == 0)
                    jogoBuscado = conexao.QuerySingle<int>("INSERT INTO jogo(nm_jogo, nm_generoJogo) VALUES (@Nome, @Genero); SELECT SCOPE_IDENTITY();", new { Nome = nome, Genero = genero });

                conexao.Execute(comandoSql, new { DataLimite = data, IdJogo = jogoBuscado, IdSorteio = idSorteio });
            }
        }

        public static void Apagar(int idSorteio)
        {            
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                conexao.Execute("DELETE FROM usuario_sorteio WHERE cd_sorteio = @IdSorteio; DELETE FROM sorteio WHERE cd_sorteio = @IdSorteio;", new { IdSorteio = idSorteio });
            }               
        }

        public static void Participar(int idUsuario, int idSorteio, int idBilhete)
        {
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                conexao.Execute("INSERT INTO usuario_sorteio(cd_usuario, cd_sorteio , cd_bilhete) VALUES (@IdUsuario, @IdSorteio, @IdBilhete);", new { IdUsuario = idUsuario, IdSorteio = idSorteio, IdBilhete = idBilhete});
            }
        }

        public static int BuscarJogo(string nomeJogo)
        {
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                return conexao.QueryFirstOrDefault<int>("SELECT cd_jogo FROM jogo WHERE nm_jogo = @NomeJogo", new { NomeJogo = nomeJogo });
            }
        }

        public static List<int> BuscarParticipantes(int idSorteio)
        {
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                return conexao.Query<int>("SELECT cd_bilhete FROM usuario_sorteio WHERE cd_sorteio = @IdSorteio", new { IdSorteio = idSorteio }).ToList();
            }
        }

        public static Usuario BuscarVencedor(int idSorteio)
        {
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                string comandoBusca = @"
                    SELECT 
                        usuario.cd_usuario AS IdUsuario, 
                        nm_usuario AS Nome, 
                        nm_email AS Email, 
                        cd_senha AS Senha, 
                        cd_telefone AS Telefone, 
                        ic_admin AS Admin, 
                        cd_cep AS Cep 
                    FROM usuario 
                    INNER JOIN usuario_sorteio ON usuario.cd_usuario = usuario_sorteio.cd_usuario
                    WHERE cd_sorteio = @IdSorteio AND ic_vencedor = 1;";

                return conexao.QuerySingle<Usuario>(comandoBusca, new { IdSorteio = idSorteio });
            }
        }

        public static bool VerificarParticipacao(int idUsuario, int idSorteio)
        {
            int Usuario;
            using (SqlConnection conexao = new SqlConnection(stringDeConexao))
            {
                Usuario = conexao.QueryFirstOrDefault<int>("SELECT cd_usuario FROM usuario_sorteio WHERE cd_usuario = @IdUsuario AND cd_sorteio = @IdSorteio", new { IdUsuario = idUsuario, IdSorteio = idSorteio });
            }

            //if (Usuario == 0)
            //    return false;
            //else
            //    return true;

            return Usuario != 0;
        }

    }
}
