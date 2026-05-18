using System;
using System.Windows.Forms;

namespace SistemaSorteio.IHM
{
    public partial class TelaInicial: Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro tela = new TelaCadastro();
            Hide();
            tela.ShowDialog();
            if (!this.IsDisposed)
            {
                Show();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            TelaLogin tela = new TelaLogin();
            Hide();
            tela.ShowDialog();
            if (!this.IsDisposed)
            {
                Show();
            }
        }
    }
}
