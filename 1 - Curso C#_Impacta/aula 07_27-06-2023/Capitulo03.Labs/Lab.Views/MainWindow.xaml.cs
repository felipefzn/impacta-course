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

namespace Lab.Views
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

            sexoComboBox.Items.Add(Sexo.Masculino);
            sexoComboBox.Items.Add(Sexo.Feminino);

        }

        // criar um evento click do botão para incluir um cliente
        private void IncluirCliente_Click(object sender, RoutedEventArgs e)
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


            //// obtem os dados do cliente
            //Cliente cliente = new Cliente(
            //        cpfTextBox.Text,
            //        nomeTextBox.Text,
            //        (Sexo)sexoComboBox.SelectedItem,
            //        int.Parse(idadeTextBox.Text)
            //    );


            MessageBox.Show("Cliente: \n" + cliente.Exibir());

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
