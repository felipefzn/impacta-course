using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVarzea
    {


    public partial class frmLogin : Form
        {

        Dictionary<string, string> usuarioSenha;

        public frmLogin()
            {
            InitializeComponent();

            //inicializa dicionario com chave valor
            usuarioSenha = new Dictionary<string, string>();
            usuarioSenha.Add("marcio", "1234");
            usuarioSenha.Add("chaves", "kiko123");
            usuarioSenha.Add("madruga", "1971");

            }

        private void btnLogin_Click(object sender, EventArgs e)
            {
            if (txtUsuario.Text.Trim() == string.Empty || txtSenha.Text.Trim() == string.Empty)
                {
                MessageBox.Show("O campo 'Usuario' e 'Senha' devem ser preenchidos");
                }
             
            if (usuarioSenha.ContainsKey(txtUsuario.Text.Trim()) && usuarioSenha.ContainsValue(txtSenha.Text.Trim()))
                {

                // se o usuario e senha válidos, então abre o form principal e esconde o forma login
                new frmPrincipal().Show();
                // esconde
                this.Hide();

                }
            else
                {
                MessageBox.Show("Usuario ou senha inválido");
                return;
                }
            }


        private void btnCancelar_Click(object sender, EventArgs e)
            {
            if (
                    MessageBox.Show(
                        "Você quer sair da aplicação?",
                        "Gestão do Corinthians",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2 // hit enter == no !
                        )
                    == DialogResult.Yes
                    )
                {
                Application.Exit();
                }
            
            }
        }
    }
