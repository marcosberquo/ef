using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtStrCon.Text = "Server=desktop\\SQLEXPRESS;Database=EF_teste;Trusted_Connection=True;";
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
           

        //}

        private void bntTestar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Conexao.Testar(txtStrCon.Text.Trim()))
            {
                //MessageBox.Show("Conexão OK");
                ObterTabelas();
            }
            else
            {
                MessageBox.Show("Falha ao conectar");
            }

            Cursor.Current = Cursors.Default;
        }

        private void ObterTabelas()
        {
            List<string> tabelas = Conexao.GetTabelas(txtStrCon.Text.Trim());

            chkListTabelas.Items.Clear();
            foreach (string tab in tabelas)
            {
                chkListTabelas.Items.Add(tab);
            }
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPastaDestino.Text = folderBrowserDialog1.SelectedPath;

        }


    }
}
