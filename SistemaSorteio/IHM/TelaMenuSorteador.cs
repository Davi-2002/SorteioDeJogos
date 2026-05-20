using SistemaSorteio.BLL;
using SistemaSorteio.Model;
using SistemaSorteio.Model.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SistemaSorteio.IHM
{
    public partial class TelaMenuSorteador: Form
    {
        readonly Usuario Conta = null;
        public TelaMenuSorteador(Usuario conta)
        {
            Conta = conta;
            InitializeComponent();
            Text = $"Bem Vindo de volta {Conta.Nome}!";
        }

        private void btn_criarSorteio_Click(object sender, System.EventArgs e)
        {
            TelaSorteio tela = new TelaSorteio(Conta);
            Hide();
            tela.ShowDialog();
            dgv_ListaSorteios.DataSource = SorteioBLL.ListarMeusSorteios(Conta.IdUsuario);
            AtualizarGrid();
            if (!this.IsDisposed)
            {
                Show();
            }
        }

        private void AtualizarGrid()
        {            
            dgv_ListaSorteios.Columns["IdSorteio"].Visible = false;
            dgv_ListaSorteios.Columns["IdJogo"].Visible = false;
            dgv_ListaSorteios.Columns["Vencedor"].Visible = false;

            if (!dgv_ListaSorteios.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnSortear = new DataGridViewButtonColumn();
                btnSortear.Name = "Sortear";
                btnSortear.HeaderText = "";
                btnSortear.Text = "Sortear";
                btnSortear.UseColumnTextForButtonValue = true;

                //estilo
                btnSortear.FlatStyle = FlatStyle.Flat;
                btnSortear.DefaultCellStyle.BackColor = Color.DodgerBlue;
                btnSortear.DefaultCellStyle.ForeColor = Color.White;

                dgv_ListaSorteios.Columns.Add(btnSortear);

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = ""; // Deixa o cabeçalho vazio para ficar mais limpo
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true; // Avisa o C# para usar o texto acima em todos os botões dessa coluna

                //estilo
                btnEditar.FlatStyle = FlatStyle.Flat;
                btnEditar.DefaultCellStyle.BackColor = Color.Gold;
                btnEditar.DefaultCellStyle.ForeColor = Color.Black;

                dgv_ListaSorteios.Columns.Add(btnEditar);

                DataGridViewButtonColumn btnApagar = new DataGridViewButtonColumn();
                btnApagar.Name = "Apagar";
                btnApagar.HeaderText = "";
                btnApagar.Text = "Apagar";
                btnApagar.UseColumnTextForButtonValue = true;

                //estilo
                btnApagar.FlatStyle = FlatStyle.Flat;
                btnApagar.DefaultCellStyle.BackColor = Color.Crimson;
                btnApagar.DefaultCellStyle.ForeColor = Color.White;

                dgv_ListaSorteios.Columns.Add(btnApagar);

            }

            foreach (DataGridViewRow linha in dgv_ListaSorteios.Rows)
            {
                string statusSorteio = linha.Cells["StatusSorteio"].Value.ToString();
                if (statusSorteio == "Fechado")
                {
                    DataGridViewButtonCell celulaBotaoSortear = (DataGridViewButtonCell)linha.Cells["Sortear"];
                    celulaBotaoSortear.Style.BackColor = Color.GreenYellow;
                    celulaBotaoSortear.UseColumnTextForButtonValue = false;
                    celulaBotaoSortear.Value = "Ver Vencedor";
                    celulaBotaoSortear.Style.ForeColor = Color.Black;

                    DataGridViewButtonCell celulaBotaoEditar = (DataGridViewButtonCell)linha.Cells["Editar"];
                    celulaBotaoEditar.Style.BackColor = Color.Gray;

                    DataGridViewButtonCell celulaBotaoApagar = (DataGridViewButtonCell)linha.Cells["Apagar"];
                    celulaBotaoApagar.Style.BackColor = Color.Gray;
                    celulaBotaoApagar.Style.ForeColor = Color.Black;
                }
            }
        }

        private void dgv_ListaSorteios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Garante que o usuário não clicou no cabeçalho da tabela
            if (e.RowIndex >= 0)
            {
                int idSorteio = Convert.ToInt32(dgv_ListaSorteios.Rows[e.RowIndex].Cells["IdSorteio"].Value);
                
                string nomeColuna = dgv_ListaSorteios.Columns[e.ColumnIndex].Name;

                switch(nomeColuna)
                {
                    case "Sortear":
                        SortearUsuario(idSorteio, e);
                        break;
                    case "Apagar":
                        ConfirmarRemocao(idSorteio, e);
                        break;
                    case "Editar":
                        EditarSorteio(e);
                        break;
                }
            }
        }

        private void SortearUsuario(int idSorteio, DataGridViewCellEventArgs e)
        {
            int participantes = Convert.ToInt32(dgv_ListaSorteios.Rows[e.RowIndex].Cells["QtdParticipantes"].Value);
            int vencedorBool = Convert.ToInt32(dgv_ListaSorteios.Rows[e.RowIndex].Cells["Vencedor"].Value);
            string statusSorteio = dgv_ListaSorteios.Rows[e.RowIndex].Cells["StatusSorteio"].Value.ToString();
            if (statusSorteio != "Fechado")
            {
                if (participantes != 0)
                {
                    string nomeJogo = dgv_ListaSorteios.Rows[e.RowIndex].Cells["NomeJogo"].Value.ToString();
                    DialogResult confirmacao = MessageBox.Show($"Deseja mesmo sortear o jogo: \r\n\"{nomeJogo.ToUpper()}\"?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == confirmacao)
                    {
                        Usuario vencedor = SorteioBLL.SortearJogo(idSorteio);
                        MessageBox.Show($"\"{vencedor.Nome}\" É O VENCEDOR!\n" +
                                        $"<------------------------------->\n" +
                                        $"Dados deste usuário:\n\n" +
                                        $"Email: {vencedor.Email}\n\n" +
                                        $"Telefone: {vencedor.Telefone}\n\n" +
                                        $"CEP: {vencedor.Cep}");
                        dgv_ListaSorteios.DataSource = SorteioBLL.ListarMeusSorteios(Conta.IdUsuario);
                        AtualizarGrid();
                    }
                }
                else
                    MessageBox.Show("Você não pode sortear um jogo sem participantes...");
            }
            else
            {
                if (participantes != 0 && vencedorBool == 1)
                {
                    Usuario vencedor = SorteioBLL.BuscarVencedorSorteio(idSorteio);
                    MessageBox.Show($"VENCEDOR: \"{vencedor.Nome}\"\n" +
                                    $"<------------------------------->\n" +
                                    $"Dados deste usuário:\n\n" +
                                    $"Email: {vencedor.Email}\n\n" +
                                    $"Telefone: {vencedor.Telefone}\n\n" +
                                    $"CEP: {vencedor.Cep}");
                }
                else
                {
                    MessageBox.Show("O usuário vencendor provavelmente apagou a conta.\r\nNão é mais possível ver seus dados.");
                }
            }
        }

        private void ConfirmarRemocao(int id, DataGridViewCellEventArgs e)
        {
            string statusSorteio = dgv_ListaSorteios.Rows[e.RowIndex].Cells["StatusSorteio"].Value.ToString();
            if (statusSorteio != "Fechado")
            { 
                string nomeJogo = dgv_ListaSorteios.Rows[e.RowIndex].Cells["NomeJogo"].Value.ToString();
                DialogResult confirmacao = MessageBox.Show($"Deseja mesmo apagar o sorteio do jogo: \r\n\"{nomeJogo.ToUpper()}\"?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == confirmacao)
                {
                    
                    SorteioBLL.ApagarSorteio(id);
                    MessageBox.Show("Sorteio removido com sucesso!");
                    dgv_ListaSorteios.DataSource = SorteioBLL.ListarMeusSorteios(Conta.IdUsuario);
                    AtualizarGrid();
                }
            }
        }

        private void EditarSorteio(DataGridViewCellEventArgs e)
        {
            string statusSorteio = dgv_ListaSorteios.Rows[e.RowIndex].Cells["StatusSorteio"].Value.ToString();
            if (statusSorteio != "Fechado")
            { 
                MeusSorteiosDTO sorteioParaEditar = new MeusSorteiosDTO
                {
                    NomeJogo = dgv_ListaSorteios.Rows[e.RowIndex].Cells["NomeJogo"].Value.ToString(),
                    Genero = dgv_ListaSorteios.Rows[e.RowIndex].Cells["Genero"].Value.ToString(),
                    DataLimite = Convert.ToDateTime(dgv_ListaSorteios.Rows[e.RowIndex].Cells["DataLimite"].Value),
                    IdSorteio = Convert.ToInt32(dgv_ListaSorteios.Rows[e.RowIndex].Cells["IdSorteio"].Value),
                    IdJogo = Convert.ToInt32(dgv_ListaSorteios.Rows[e.RowIndex].Cells["IdJogo"].Value)
                };

                TelaSorteio tela = new TelaSorteio(Conta, sorteioParaEditar);
                Hide();
                tela.ShowDialog();
                dgv_ListaSorteios.DataSource = SorteioBLL.ListarMeusSorteios(Conta.IdUsuario);
                AtualizarGrid();
                if (!this.IsDisposed)
                {
                    Show();
                }
            }
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

        private void TelaMenuSorteador_Load(object sender, EventArgs e)
        {
            dgv_ListaSorteios.DataSource = SorteioBLL.ListarMeusSorteios(Conta.IdUsuario);
            AtualizarGrid();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_ListaSorteios.DataSource = SorteioBLL.FiltrarListaMeusSorteios(Conta.IdUsuario, cb_Genero.Text, tb_nomeJogo.Text, cb_status.Text);
            AtualizarGrid();
        }
    }
}
