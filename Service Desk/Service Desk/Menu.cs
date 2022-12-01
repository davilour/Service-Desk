using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Desk
{
    public partial class Menu : Form
    {

        public int codigoid;
        public Menu(int codigoid)
        {
            InitializeComponent();
            this.codigoid = codigoid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atendimento go = new Atendimento(this.codigoid);
            go.MdiParent = this;
            go.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CadastroCliente go = new CadastroCliente();
            go.MdiParent = this;
            go.Show();
          

        }

        private void atendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadastroAtendente go = new CadastroAtendente();
            go.MdiParent = this;
            go.Show();

        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTec go = new CadastroTec();
            go.MdiParent = this;
            go.Show();

        }
    }
}
