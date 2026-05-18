using SistemaSorteio.BLL;
using SistemaSorteio.Model;
using System.Windows.Forms;

namespace SistemaSorteio.IHM
{
    public partial class TelaSorteiosGanhos: Form
    {
        readonly Usuario Conta = null;
        public TelaSorteiosGanhos(Usuario conta)
        {
            Conta = conta;
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgv_ListaSorteios.DataSource = SorteioBLL.ListarSorteiosQueVenceu(Conta.IdUsuario);
            dgv_ListaSorteios.Columns["IdSorteio"].Visible = false;
            dgv_ListaSorteios.Columns["IdJogo"].Visible = false;
            dgv_ListaSorteios.Columns["DataLimite"].DefaultCellStyle.Format = "d";

            if (dgv_ListaSorteios.Rows.Count <= 0)
            {
                l_aviso.Text = "Você ainda não ganhou nenhum sorteio";
            }
            else
                l_aviso.Visible = false;
        }
    }
}
