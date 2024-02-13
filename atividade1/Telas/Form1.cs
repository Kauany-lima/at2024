using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade1
{
   
    public partial class Form1 : Form
    {
        List<Cl> classe = new List<Cl>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cl cl = new Cl();
            bool val = Valida.Validacao(tx_cpf.Text);
            cl.cnpj = Convert.ToBoolean(tx_cnpj.Text);
            cl.razaosocial = tx_razao.Text;
            cl.nomefan = tx_nomefan.Text;
            cl.situacao = tx_sit.Text;
            cl.data = tx_data.Value;
            cl.capsocial = Convert.ToDouble(tx_cap.Text);
            cl.telefone = tx_cap.Text;
            cl.endereco = tx_est.Text;
            cl.cidade = tx_cid.Text;
            cl.bairro = tx_ba.Text;
            cl.rua = tx_rua.Text;
            cl.numero = tx_num.Text;
            cl.naturezajur = tx_natur.Text;
            cl.nomeprop = tx_nomeprop.Text;

            Form2 form2 = new Form2();

       
            form2.Refresh();
            form2.dataGridView1.DataSource = classe;
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
