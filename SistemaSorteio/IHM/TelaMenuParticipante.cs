using SistemaSorteio.BLL;
using SistemaSorteio.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaSorteio.IHM
{
    public partial class TelaMenuParticipante: Form
    {
        readonly Usuario Conta = null;
        public TelaMenuParticipante(Usuario conta)
        {
            Conta = conta;
            InitializeComponent();
            Text = $"Bem Vindo de volta {Conta.Nome}!";
        }

        private void btn_editarUsuario_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro(Conta);
            Hide();
            tela.ShowDialog();
            if (!this.IsDisposed)
            {
                Show();
            }
            Text = $"Bem Vindo de volta {Conta.Nome}!";
        }

        private void AtualizarGrid()
        {
            dgv_ListaSorteios.Columns["IdSorteio"].Visible = false;
            dgv_ListaSorteios.Columns["IdJogo"].Visible = false;

            if (!dgv_ListaSorteios.Columns.Contains("Participar"))
            {
                DataGridViewButtonColumn btnSortear = new DataGridViewButtonColumn();
                btnSortear.Name = "Participar";
                btnSortear.HeaderText = "";
                btnSortear.Text = "Entrar";
                btnSortear.UseColumnTextForButtonValue = true;

                //estilo
                btnSortear.FlatStyle = FlatStyle.Flat;
                btnSortear.DefaultCellStyle.BackColor = Color.DodgerBlue;
                btnSortear.DefaultCellStyle.ForeColor = Color.White;

                dgv_ListaSorteios.Columns.Add(btnSortear);
            }

            foreach (DataGridViewRow linha in dgv_ListaSorteios.Rows)
            {
                int idSorteio = Convert.ToInt32(linha.Cells["IdSorteio"].Value);
                if (SorteioBLL.VerificarParticipacaoSorteio(Conta.IdUsuario, idSorteio))
                {
                    DataGridViewButtonCell celulaBotao = (DataGridViewButtonCell)linha.Cells["Participar"];
                    celulaBotao.Style.BackColor = Color.Gray;
                    celulaBotao.UseColumnTextForButtonValue = false;
                    celulaBotao.Value = "Inscrito";
                }
            }
        }

        private void dgv_ListaSorteios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Garante que o usuário não clicou no cabeçalho da tabela
            if (e.RowIndex >= 0)
            {
                string nomeJogo = dgv_ListaSorteios.Rows[e.RowIndex].Cells["NomeJogo"].Value.ToString();
                int idSorteio = Convert.ToInt32(dgv_ListaSorteios.Rows[e.RowIndex].Cells["IdSorteio"].Value);
                int participantes = Convert.ToInt32(dgv_ListaSorteios.Rows[e.RowIndex].Cells["QtdParticipantes"].Value);
                DateTime dataLimite = Convert.ToDateTime(dgv_ListaSorteios.Rows[e.RowIndex].Cells["DataLimite"].Value);
                string nomeColuna = dgv_ListaSorteios.Columns[e.ColumnIndex].Name;

                if (SorteioBLL.VerificarParticipacaoSorteio(Conta.IdUsuario, idSorteio)) return;
                
                if (nomeColuna == "Participar")
                {
                    if (participantes > 2147483640)
                    {
                        MessageBox.Show("Você não pode mais participar desse sorteio pois já atingiu o limite máximo de participantes");
                        return;
                    }
                    else if(dataLimite < DateTime.Now.Date)
                    {
                        MessageBox.Show("Você não pode mais participar pois já passou da data deste sorteio");
                        return;
                    }
                    else
                    {
                        DialogResult confirmacao = MessageBox.Show($"Deseja participar do sorteio para o jogo: \r\n\"{nomeJogo.ToUpper()}\"?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (DialogResult.Yes == confirmacao)
                        {
                            participantes++;
                            SorteioBLL.ParticiparSorteio(Conta.IdUsuario, idSorteio, participantes);
                            dgv_ListaSorteios.DataSource = SorteioBLL.FiltrarListaGeralDeSorteiosAbertos(cb_Genero.Text, tb_nomeJogo.Text);
                            AtualizarGrid();
                        }
                    }

                }
            }
        }

        private void TelaMenuParticipante_Load(object sender, EventArgs e)
        {
            dgv_ListaSorteios.DataSource = SorteioBLL.ListarTodosSorteios();
            AtualizarGrid();
        }

        private void btn_SorteiosGanhos_Click(object sender, EventArgs e)
        {
            TelaSorteiosGanhos tela = new TelaSorteiosGanhos(Conta);
            Hide();
            tela.ShowDialog();
            if (!this.IsDisposed)
            {
                Show();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_ListaSorteios.DataSource = SorteioBLL.FiltrarListaGeralDeSorteiosAbertos(cb_Genero.Text, tb_nomeJogo.Text);
            AtualizarGrid();
        }
    }
}
