using SistemaSorteio.BLL;
using SistemaSorteio.Model;
using SistemaSorteio.Model.DTO;
using System.Windows.Forms;

namespace SistemaSorteio.IHM
{  
    public partial class TelaSorteio: Form
    {
        readonly Usuario Conta = null;
        readonly MeusSorteiosDTO SorteioParaEditar = null;
        public TelaSorteio(Usuario conta)
        {
            Conta = conta;
            InitializeComponent();
            l_tituloTela.Text = "Criar Sorteio";
        }

        public TelaSorteio(Usuario conta, MeusSorteiosDTO sorteioParaEditar)
        {
            Conta = conta;
            SorteioParaEditar = sorteioParaEditar;            
            InitializeComponent();
            l_tituloTela.Text = "Editar Sorteio";
            tb_nomeJogo.Text = sorteioParaEditar.NomeJogo;
            cb_Genero.Text = sorteioParaEditar.Genero;
            dtp_dataLimite.Value = sorteioParaEditar.DataLimite;
        }

        private void btn_salvarSorteio_Click(object sender, System.EventArgs e)
        {
            string mensagem = "Novo sorteio criado!";
            if (SorteioParaEditar != null)
            {
                SorteioBLL.EditarSorteio(tb_nomeJogo.Text, cb_Genero.Text, SorteioParaEditar.IdSorteio, dtp_dataLimite.Value);
                mensagem = "Sorteio editado com sucesso!";
            }
            else
                SorteioBLL.CadastrarSorteio(tb_nomeJogo.Text, cb_Genero.Text, Conta.IdUsuario, dtp_dataLimite.Value);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show(mensagem);
                Close();
            }           
        }
    }
}
