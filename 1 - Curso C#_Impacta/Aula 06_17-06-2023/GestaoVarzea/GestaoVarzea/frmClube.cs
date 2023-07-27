using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVarzea
    {
    public partial class frmClube : Form
        {
         // o metodo contrustor ele é executado antes do form ser
         // apresentado para o usuário
        public frmClube()
            {
            InitializeComponent();

            Random rnd = new Random();
            lblId.Text = rnd.Next().ToString();
            }

        private void timer1_Tick(object sender, EventArgs e)
            {
            tssDataHora.Text = DateTime.Now.ToString();
            }

        private void txtNome_Validating(object sender, CancelEventArgs e)
            {
            //erro provider set error, vc passar o campo que quer que apareça o erro, e depois o erro que você qquer
            if (txtNome.Text.Trim() == string.Empty)
                {
                errorProvider1.SetError(txtNome, "Informe o nome");
                }
            else
                {
                errorProvider1.SetError(txtNome, string.Empty);
                }
            }

        private void txtEndereco_Validating(object sender, CancelEventArgs e)
            {
            if (txtNome.Text.Trim() == string.Empty)
                {
                errorProvider1.SetError(txtEndereco, "Informe o endereco");
                }
            else
                {
                errorProvider1.SetError(txtEndereco, string.Empty);
                }
            }

        private void mskCnpj_Validating(object sender, CancelEventArgs e)
            {
            //o replace ta tirando o primeiro parametro, e trocando pelo. Exemplo embaixo, ta tirando o - e colocando vazio
            var cnpj = mskCnpj.Text.Replace(".", string.Empty)
                .Replace("/", "").Replace("-", "");

            if (String.IsNullOrEmpty(cnpj))
                {
                errorProvider1.SetError(mskCnpj, "Informe o CNPJ");
                }
            else
                {
                errorProvider1.SetError(mskCnpj, string.Empty);
                }
            }

        private void txtPresidente_Validating(object sender, CancelEventArgs e)
            {
            if (String.IsNullOrEmpty(txtPresidente.Text.Trim()))
                {
                errorProvider1.SetError(txtPresidente, "Informe o Presidente");
                }
            else
                {
                errorProvider1.SetError(txtPresidente, string.Empty);
                }
            }

        private void mskTelefone_Validating(object sender, CancelEventArgs e)
            {
            if (String.IsNullOrWhiteSpace(mskTelefone.Text
                .Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace("-", string.Empty)
                .Replace(" ", string.Empty)
                .Trim()))
                {
                errorProvider1.SetError(mskTelefone, "Informe o Telefone");
                }
            else
                {
                errorProvider1.SetError(mskTelefone, "");
                }
            }

        private void btnSalvar_Click(object sender, EventArgs e)
            {
            //objeto que estou instanciando, validações, conexão com banco de dados. Tudo aqui que pode falhar eu coloco no try
            try
                {
                if (GravarArquivo())
                    {
                    MessageBox.Show(
                        $"Cadastro Realizado com sucesso",
                        "Gestão do Corinthians",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                else
                    {
                    MessageBox.Show(
                        $"Houve um erro ao gravar o arquivo, verifique,",
                        "Gestão do Corinthians",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            catch (Exception ex)
                {
                MessageBox.Show(
                    $"Ocorreu um erro: " +
                    "Gestão da Varzea",
                    $"\n {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            //opcional
            finally
                {

                }
            }

        private bool GravarArquivo()
            {
            // SERÁ UTILIZADO PARA CABEÇALHO DO ARQUIVO DELIMITADO POR PONTO E VIRGULA
            string titulo = @"ID;Nome;FUNDACAO;ENDERECO;CNPJ;PRESIDENTE;TELEFONE";

            // VAMOS DEFINIR O REGISTRO QUE SERÁ GRAVADO EM NOSSO ARQUIVO
            string registro = $"{lblId.Text};{txtNome.Text};{dtFundacao.Text};{txtEndereco.Text};{mskCnpj.Text};{txtPresidente.Text}" +
                $"{mskTelefone.Text}";

            // CRIAR UMA FLAG PARA VERIFICAR SE O ARQUIVO EXISTE 
            // USAMOS A CLASSE FILE PARA VERIFICAR SE O ARQUIVO EXISTE, ELA RETORNA TRUE EM CASO POSITIVO, E FALSE EM CASO NEGATIVO
            var path = @"D:\1 - Curso C#_Impacta\Aula 06_17-06-2023\clubes.txt";
            bool flag = File.Exists(path);

            // VAMOS CRIAR UM OBJETO PARA GRAVAR O NOSSO ARQUIVO
            // ESTE OBJETO RECEBE 2 PARAMETROS: CAMINHO DO ARQUIVO E FLAG TRUE/FALSE
            // QUE SERVE PARA INDICAR SE O ARQUIVO PODE SER CONCATENADO
            StreamWriter gravadorDeArquivo = new StreamWriter(path, true);

            // SE O ARQUIVO NÃO EXISTIR, CRIA O ARQUIVO e
            // ESCREVE O TÍTULO NA PRIMEIRA LINHA
            if (!flag)
                {
                gravadorDeArquivo.WriteLine(titulo);
                }

            // ESCREVE NO ARQUIVO O REGISTRO CAPTURADO NA TELA
            gravadorDeArquivo.WriteLine(registro);

            // SEMPRE QUE USAR ESSE OBJETO, NUNCA ESQUECER DE CHAMAR O CLOSE()
            // SENÃO O ARQUIVO PERMANECE EM USO
            gravadorDeArquivo.Close();

            // RETORNA VERDADEIRO POIS O FLUXO DE GRAVAÇÃO FOI REALIZADO POR COMPLETO
            return true;




            }

        

        private void btnLeitura_Click(object sender, EventArgs e)
            {
            try
                {
                //Definir a barra ~de titulo do Dialog
                openFileDialog1.Title = "Abrir Arquivo";

                //Limpa o path padrão que aparece
                openFileDialog1.FileName = string.Empty;

                //inicia com a leitura no diretório indicado
                openFileDialog1.InitialDirectory = @"D:\";

                //Exibir apenas arquivos extensão .txt
                openFileDialog1.Filter = "Arquivos TXT|*.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                    // Definir o objeto de leitura do arquivo
                    StreamReader leitor = new StreamReader(openFileDialog1.FileName);

                    // Descarregar o conteudo
                    txtResultado.Text = leitor.ReadToEnd();                                                                      
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(
                    $"Houve um erro ao ler o aquivo, verifique: \n {ex.Message}" +
                    "Gestão da Varzea",
                    $"\n {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
                }
            }

        private void btnLimpar_Click(object sender, EventArgs e)
            {

            }
        }
    }
