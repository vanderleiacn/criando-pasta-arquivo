using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CriandoUmaPasta      // criando uma pasta e um arquivo dentro da pasta 
{
    public partial class Form1 : Form
    {   //variavel
        string caminhoArquivo = @"C:\configuracao\"; //nome da pasta 
        string nomeArquivo = @"config.data"; //nome do arquivo 

        public Form1()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //criar pastas
            if (!Directory.Exists(caminhoArquivo))
            {
                Directory.CreateDirectory(caminhoArquivo);// cria
                // StreamWriter grava
                StreamWriter arquivo = new StreamWriter(caminhoArquivo + nomeArquivo, false,Encoding.Default); //arquivo é o nome da instancia
                arquivo.WriteLine(txtNome.Text); 
                arquivo.WriteLine(dt.Value.ToShortDateString());

                MessageBox.Show("Criado com sucesso");
            }
            else
            {
                MessageBox.Show("Diretório existente");
            }
            Application.Exit();
        }
    }
}
