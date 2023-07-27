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
    public partial class frmPrincipal : Form
        {
        public frmPrincipal()
            {
            InitializeComponent();
            }



        private void linkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            System.Diagnostics.Process.Start("https://www.corinthians.com.br");
            }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Escape)
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
                    // encerra a aplicação definitivamente
                    Application.Exit();
                    }

                }
            }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
            {
            Application.Exit();
            }

        private void btnGerenciar_Click(object sender, EventArgs e)
            {
            // Instanciamos o formulário frmClube
            frmClube frmCadClube = new frmClube();

            // para apresentar o form na tela
            frmCadClube.ShowDialog();
            }

        private void btnCadastroJogador_Click(object sender, EventArgs e)
            {
            // para abrir o formulario instanciamos o formulario
            frmJogador telaJogador = new frmJogador();

            // para apresentar o form na tela, usamos o show dialog
            telaJogador.ShowDialog();
            }
        }
    }
