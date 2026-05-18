using SistemaSorteio.DAL;
using SistemaSorteio.Model;
using SistemaSorteio.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SistemaSorteio.BLL
{
    public class SorteioBLL
    {
        public static void ValidaSorteio(string nome, string genero, DateTime data)
        {
            //NOME
            Erro.setErro(false);
            if (string.IsNullOrWhiteSpace(nome))
            {
                Erro.setErro("O nome do jogo é de preenchimento obrigatório");
                return;
            }
            // \p{L} == Qualquer letra de qualquer idioma
            // \s == espaço em branco
            else if (!Regex.IsMatch(nome, "^[\\p{L}0-9\\s\\-:._+]+$"))
            {
                Erro.setErro("digite um nome de jogo válido");
                return;
            }
            else if (nome.Length > 90)
            {
                Erro.setErro("O nome do jogo não pode ter mais de 90 caracteres.");
                return;
            }

            //GENERO
            if (string.IsNullOrWhiteSpace(genero))
            {
                Erro.setErro("Escolha um gênero de jogo");
                return;
            }

            //DATA LIMITE
            if (data.Date < DateTime.Now.Date)
            {
                Erro.setErro("Selecione uma data futura");
                return;
            }
        }

        public static bool CadastrarSorteio(string nome, string genero, int idUsuario, DateTime data)
        {
            ValidaSorteio(nome, genero, data);

            if (Erro.getErro())
            {
                return false;
            }

            SorteioDAL.Salvar(nome, genero, idUsuario, data);
            return true;
        }

        public static List<MeusSorteiosDTO> ListarMeusSorteios(int idUsuario)
        {
            return SorteioDAL.ListarMeusSorteios(idUsuario);
        }

        public static List<MeusSorteiosDTO> FiltrarListaMeusSorteios(int idUsuario, string genero, string nomeJogo, string statusSorteio)
        {
            return SorteioDAL.FiltrarMeusSorteios(idUsuario, genero, nomeJogo, statusSorteio);
        }

        public static List<SorteioListagemDTO> FiltrarListaGeralDeSorteiosAbertos(string genero, string nomeJogo)
        {
            return SorteioDAL.FiltrarSorteiosAbertos(genero, nomeJogo);
        }

        public static List<SorteioListagemDTO> ListarTodosSorteios()
        {
            return SorteioDAL.ListarTodosSorteiosAbertos();
        }

        public static bool EditarSorteio(string nome, string genero, int idSorteio, DateTime data)
        {
            ValidaSorteio(nome, genero, data);

            if (Erro.getErro())
            {
                return false;
            }

            SorteioDAL.Editar(nome, genero, idSorteio, data);
            return true;
        }

        public static void ApagarSorteio(int idSorteio)
        {
            SorteioDAL.Apagar(idSorteio);
        }

        public static void ParticiparSorteio(int idUsuario, int idSorteio, int idBilhete)
        {
            SorteioDAL.Participar(idUsuario, idSorteio, idBilhete);
        }

        public static bool VerificarParticipacaoSorteio(int idUsuario, int idSorteio)
        {
            return SorteioDAL.VerificarParticipacao(idUsuario, idSorteio);
        }

        public static List<SorteioListagemDTO> ListarSorteiosQueVenceu(int idUsuario)
        {
            return SorteioDAL.ListarSorteiosGanhos(idUsuario);
        }

        public static Usuario SortearJogo(int idSorteio)
        {
            List<int> participantes = SorteioDAL.BuscarParticipantes(idSorteio);
            Random sortear = new Random();
            int vencedor = sortear.Next(participantes.Count) + 1;
            SorteioDAL.Sorteado(vencedor, idSorteio);
            return BuscarVencedorSorteio(idSorteio);
        }

        public static Usuario BuscarVencedorSorteio(int idSorteio)
        {
            return SorteioDAL.BuscarVencedor(idSorteio);
        }
    }
}
