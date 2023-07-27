using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lab.Models;

namespace Lab.WinForms.UI
    {
    public partial class Principal : Form
        {
        private bool VerificarEspecial { get; set; }

        public Principal()
            {
            InitializeComponent();

            sexoComboBox.Items.Add(Sexo.Masculino);
            sexoComboBox.Items.Add(Sexo.Feminino);
            }

        private void btnSalvar_Click(object sender, EventArgs e)
            {
            // para incluir o nosso cliente, precisamos criar os objetos
            // para receber os valores capturados na tela
            // criar  objeto ENDERECO
            Endereco endereco = new Endereco()
                {
                Logradouro = ruaTextBox.Text,
                Numero = int.Parse(numeroTextBox.Text),
                Cidade = cidadeTextBox.Text,
                Cep = cepTextBox.Text
                };
           
            if (cpfTextBox.Text.Trim().Length == 11)
                {
                Cliente cliente = new ClientePF(
                        cpfTextBox.Text,
                        nomeTextBox.Text,
                        (Sexo)sexoComboBox.SelectedItem,
                        int.Parse(idadeTextBox.Text)
                    );
                }
            else if (cpfTextBox.Text.Trim().Length == 14)
                {
                // obtem os dados do cliente
                Cliente cliente = new ClientePJ(
                        cpfTextBox.Text,
                        nomeTextBox.Text,
                        (Sexo)sexoComboBox.SelectedItem,
                        int.Parse(idadeTextBox.Text),
                        endereco

                    );
                }
            else
                {
                throw new Exception("Documento Invalido");
                }



            }

        private void especialRadioButton_CheckedChanged(object sender, EventArgs e)
            {
            var radio = sender as RadioButton;
            VerificarEspecial = (radio == especialRadioButton);
            limiteLabel.Enabled = VerificarEspecial;
            limiteTextBox.Enabled = VerificarEspecial;
            }

        private void label15_Click(object sender, EventArgs e)
            {

            }

        private void label16_Click(object sender, EventArgs e)
            {

            }
        }
    }
