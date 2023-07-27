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
using LabDados;
using LabModels;

namespace Lab.WinForms.UI
{
    public partial class Principal : Form
    {
        

        private bool VerificarEspecial { get; set; }
        public ContaCorrente[] Conta { get; private set; }

        public Principal()
        {
            InitializeComponent();

            sexoComboBox.Items.Add(Sexo.Masculino);
            sexoComboBox.Items.Add(Sexo.Feminino);

            cboOperacao.Items.Add(Operacoes.Deposito);
            cboOperacao.Items.Add(Operacoes.Saque);
            cboOperacao.SelectedIndex = 0;

            ClientesDao = new ClientesDao();
            ContasDao = new ContasDao();
            clienteComboBox.DataSource = ClientesDao.Listar();
            cboConta.DataSource = ContasDao.Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
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

                // para verificar se o combobox esta selecionado
                // geralmente se não esta selecionado, esta com -1
                if (sexoComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione o Sexo");
                    return; // para sair da execução atual
                }

                Cliente cliente;

                if (cpfTextBox.Text.Trim().Length == 11)
                {
                    // obtem os dados do cliente
                     cliente = new ClientePF(
                            cpfTextBox.Text,
                            nomeTextBox.Text,
                            (Sexo)sexoComboBox.SelectedItem,
                            int.Parse(idadeTextBox.Text),
                            endereco
                        );

                }
                else if (cpfTextBox.Text.Trim().Length == 14)
                {
                    // obtem os dados do cliente
                     cliente = new ClientePJ(
                            cpfTextBox.Text,
                            nomeTextBox.Text,
                            (Sexo)sexoComboBox.SelectedItem,
                            int.Parse(idadeTextBox.Text),
                            endereco
                        );
                }
                else
                {
                    throw new Exception("Documento Inválido");
                }

                // chamar o objeto DAo para fazer a inclusão do cliente na base de dados 
                ClientesDao clientesDao = new ClientesDao();

                clientesDao.Incluir(cliente);

                // preencher o combobox com os dados do cliente
                clienteComboBox.DataSource = clientesDao.Listar();

                MessageBox.Show("Cliente incluido com sucesso", "Gestão de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.StackTrace,
                    "Impacta - Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void especialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var radio = sender as RadioButton;
                VerificarEspecial = (radio == especialRadioButton);
                limiteLabel.Enabled = VerificarEspecial;
                limiteTextBox.Enabled = VerificarEspecial;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.StackTrace,
                    "Impacta - Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void incluirContaButton_Click(object sender, EventArgs e)
        {
            Conta conta;            

            // obtem o cliente selecionado no combobox
            var Cliente = (Cliente)clienteComboBox.SelectedItem;
            int banco = int.Parse(bancoTextBox.Text);
            string agencia = txtAgencia.Text;
            string numConta = txtConta.Text;

            if (VerificarEspecial)
            {
                conta = new ContaEspecial(banco, agencia, numConta);

                ((ContaEspecial)conta).Limite = double.Parse(limiteTextBox.Text);
            }
            else
            {
                Conta = new ContaCorrente[banco, agencia, numConta];
            }
        }
    }
}
