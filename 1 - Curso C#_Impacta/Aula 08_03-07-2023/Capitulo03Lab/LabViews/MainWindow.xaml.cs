using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab.Models;
using LabModels;

namespace LabViews
    {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {

        private bool VerificarEspecial { get; set; }


        public MainWindow()
            {
            InitializeComponent();

            // sempre que vc quiser programar algo no CONSTRUTOR, deve ser feito após 
            // o método: InitializeComponent();

            sexoComboBox.Items.Add(Sexo.Feminino);
            sexoComboBox.Items.Add(Sexo.Masculino);
            }

        // criar um evento clcick do botão para incluir um cliente
        private void IncluirCliente_Click(object sender, RoutedEventArgs e)// object ele representa o próprio objeto visual, 
        {
            // para incluir o nosso cliente, precisamos criar os objetos
            // para receber os valores capturados na tela
            // criar o objeto ENDERECO
            Endereco endereco = new Endereco()
            {
                Logradouro = ruaTextBox.Text,
                Numero = int.Parse(numeroTextBox.Text),
                Cidade = cidadeTextBox.Text,
                Cep = cepTextBox.Text
            };

            //Cliente cliente = new Cliente(
            //    cpfTextBox.Text,
            //    nomeTextBox.Text,
            //    (Sexo)sexoComboBox.SelectedItem,
            //    int.Parse(idadeTextBox.Text)

            //    );

            //Endereco end = new Endereco()
            //{
            //    Cep = "1234566",
            //    Cidade = "Santo Andre"
            //};

            //Endereco end2 = new Endereco();
            //end2.Cep = "2342";
            //end2.
            //{
            //_cpf = cpfTextBox.Text,
            //Nome = nomeTextBox.Text,
            //Idade = int.Parse(idadeTextBox.Text),
            //// CAST: Tipo de conversão explicita
            //Sexo = (Sexo)sexoComboBox.SelectedItem,
            //EnderecoResidencial = endereco
            //};

            //MessageBox.Show("Cliente: \n" + cliente.Exibir());

        }

            private void especialRadioButton_Checked(object sender, RoutedEventArgs e)
            {
                var radio = sender as RadioButton;
                VerificarEspecial = (radio == especialRadioButton);
                limiteLabel.IsEnabled = VerificarEspecial;
                limiteTextBox.IsEnabled = VerificarEspecial;
            }

        }
        
    }
        
    

