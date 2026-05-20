using SistemaSorteio.BLL;
using SistemaSorteio.Model;
using System;
using System.Windows.Forms;

namespace SistemaSorteio.IHM
{
    public partial class TelaLogin: Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Usuario usuarioLogado = UsuarioBLL.FazerLogin(tb_usuario.Text, tb_senha.Text);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else if (usuarioLogado != null)
            {
                if (usuarioLogado.Admin)
                {
                    TelaMenuSorteador tela = new TelaMenuSorteador(usuarioLogado);
                    Hide();
                    Close();
                    tela.ShowDialog();
                    if (!this.IsDisposed)
                    {
                        Show();
                    }
                }
                else
                {
                    TelaMenuParticipante tela = new TelaMenuParticipante(usuarioLogado);
                    Hide();
                    Close();
                    tela.ShowDialog();
                    if (!this.IsDisposed)
                    {
                        Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("O nome de usuário ou a senha está incorreta");
            }
        }

        private void lb_SenhaOCulta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tb_senha.UseSystemPasswordChar = !tb_senha.UseSystemPasswordChar;
            if (tb_senha.UseSystemPasswordChar)
                lb_SenhaOCulta.Text = "Ocultar";
            else
                lb_SenhaOCulta.Text = "Mostrar";
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            tb_senha.UseSystemPasswordChar = true;
        }
    }
}
