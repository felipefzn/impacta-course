using GestaoVarzea.Models;
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
    public partial class frmJogador : Form
        {
        public frmJogador()
            {
            InitializeComponent();
            }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
            {
            // como permitir apenas números e vírgula dentro de um TextBox.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ',') && (e.KeyChar != '.'))
                {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula");
                }

            //if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //    {
            //    e.Handled = true;
            //    MessageBox.Show("Este Campo aceita somente uma virgula");
            //    }
            //}
            }

        private void btnLimpar_Click(object sender, EventArgs e)
            {
            // forma orientada utilizando objetos
            foreach (Control ctl in this.Controls)
                {
                // a variavel ctl recebe cada controle a cada loop
                // do foreach
                if (ctl is TextBox)
                    {
                    ctl.Text = string.Empty;
                    }
                else if (ctl is MaskedTextBox)
                    {
                    ctl.Text = string.Empty;
                    }
                else if (ctl is DateTimePicker)
                    {
                    ctl.Text = DateTime.Now.ToShortDateString();
                    }
                else if (ctl is ComboBox)
                    {
                    ctl.TabIndex = 0;
                    ctl.Text = "";

                    }
                }
            }

        private void btnSalvar_Click(object sender, EventArgs e)
            {
            try
                {
                Jogador jogador = new Jogador();

                jogador.Nome = txtNome.Text;
                jogador.Cpf = mskCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Trim();
                jogador.Telefone = Convert.ToInt32(mskTelefone);
                jogador.DataNascimento = dtNascimento.Value;
                jogador.Posicao = cbPosicao.Text;
                jogador.Registro = Convert.ToInt32(txtRegistro.Text.Trim());
                jogador.DataContratacao = dtContratacao.Value;
                jogador.DataTerminoContrato = dtDemissao.Value;
                jogador.Salario = Convert.ToDecimal(txtSalario.Text);

                //chama o metodo salvarjogador para salvar no bd, e usa a var jogador como parametro
                jogador.SalvarJogador(jogador);
                

                }
            catch (Exception ex)
                {
                MessageBox.Show(
                    $"Ocorreu um erro: " +
                    "Gestão da Varzea",
                    $"\n {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
