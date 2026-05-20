using SistemaSorteio.BLL;
using SistemaSorteio.Model;
using SistemaSorteio.Service;
using System;
using System.Windows.Forms;

namespace SistemaSorteio.IHM
{
    public partial class TelaCadastro: Form
    {
        Usuario Conta = null;
        Endereco cadastroEndereco = new Endereco();
        public TelaCadastro()
        {
            InitializeComponent();        
            l_titulo.Text = "CADASTRO";
            btn_Cadastrar.Text = "Cadastrar";
        }

        public TelaCadastro(Usuario conta)
        {
            Conta = conta;
            InitializeComponent();
            this.Text = "Edição";
            l_titulo.Text = "EDITAR CONTA";
            btn_Cadastrar.Text = "Salvar";
            l_pergunta.Visible = false;
            rb_participante.Visible = false;
            rb_Sorteador.Visible = false;

            btn_apagar.Visible = true;
            l_tipoConta.Visible = true;
            if(Conta.Admin)
                l_tipoConta.Text += "Sorteador";
            else
                l_tipoConta.Text += "Participante";

            tb_usuario.Text = Conta.Nome;
            tb_email.Text = Conta.Email;
            tb_telefone.Text = Conta.Telefone;
            tb_cep.Text = Conta.Cep;
            tb_numero.Text = Conta.Numero;
            tb_complemento.Text = Conta.Complemento;
        }


        private async void tb_cep_TextChanged(object sender, EventArgs e)
        {
            if (tb_cep.Text.Length == 9 && tb_cep.MaskCompleted)
            {
                cadastroEndereco = await CepService.Buscar(tb_cep.Text);
                tb_rua.Text = cadastroEndereco.Rua;
                tb_bairro.Text = cadastroEndereco.Bairro;
                tb_cidade.Text = cadastroEndereco.Cidade;
                tb_estado.Text = cadastroEndereco.Estado;
            }
            else
            {
                tb_rua.Text = string.Empty;
                tb_bairro.Text = string.Empty;
                tb_cidade.Text = string.Empty;
                tb_estado.Text = string.Empty;
            }
        }

        private void tb_cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            CadastroBLL.ValidaTextoCep(e);
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (Conta == null)
            {
                string texto = "Usuário cadastrado com sucesso!";
                bool admin = rb_Sorteador.Checked;
                Usuario novoUsuario = new Usuario(tb_usuario.Text, tb_email.Text, tb_senha.Text, tb_telefone.Text, admin, tb_cep.Text, tb_numero.Text, tb_complemento.Text);

                bool sucesso = CadastroBLL.CadastrarUsuario(novoUsuario, cadastroEndereco);

                if (sucesso)
                {
                    if (novoUsuario.Admin)
                    {
                        MessageBox.Show(texto);
                        TelaMenuSorteador tela = new TelaMenuSorteador(novoUsuario);
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
                        MessageBox.Show(texto);
                        TelaMenuParticipante tela = new TelaMenuParticipante(novoUsuario);
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
                    MessageBox.Show(Erro.getMens());
                }
            }
            else
            {
                Usuario editarUsuario = new Usuario(tb_usuario.Text, tb_email.Text, tb_senha.Text, tb_telefone.Text, Conta.Admin, tb_cep.Text, tb_numero.Text, tb_complemento.Text);
                editarUsuario.IdUsuario = Conta.IdUsuario;

                bool sucesso = UsuarioBLL.EditarUsuario(editarUsuario, cadastroEndereco);

                if (sucesso)
                {
                    MessageBox.Show("Usuário editado com sucesso!");
                    Conta.Nome = tb_usuario.Text;
                    Conta.Email = tb_email.Text;           
                    Conta.Telefone = tb_telefone.Text;
                    Conta.Cep = tb_cep.Text;
                    Conta.Numero = tb_numero.Text;
                    Conta.Complemento = tb_complemento.Text;

                    if (!string.IsNullOrWhiteSpace(editarUsuario.Senha))
                    {
                        Conta.Senha = editarUsuario.Senha;
                    }
                }
                else
                {
                    MessageBox.Show(Erro.getMens());
                }
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show($"Deseja mesmo apagar sua conta?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == confirmacao)
            {
                UsuarioBLL.ApagarUsuario(Conta.IdUsuario);
                Application.Restart();
            }
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            tb_senha.UseSystemPasswordChar = true;
        }

        private void lb_SenhaOCultta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tb_senha.UseSystemPasswordChar = !tb_senha.UseSystemPasswordChar;
            if(tb_senha.UseSystemPasswordChar)
                lb_SenhaOCultta.Text = "Ocultar";
            else
                lb_SenhaOCultta.Text = "Mostrar";
        }
    }
}
