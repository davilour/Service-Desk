using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Service_Desk
{
    public partial class CadastroTec : Form
    {

        ClassConexao con = new ClassConexao();

        public CadastroTec()
        {
            InitializeComponent();
        }

        public int codigo;
        ClassUsuario usu = new ClassUsuario();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            

            string nome = txtNome.Text, cpf = mtbCPF.Text, tele = mtbTelefone.Text;
            if (nome == "" || mtbCPF.MaskFull == false || mtbTelefone.MaskFull == false)
            {
                if (nome == "")
                {
                    MessageBox.Show("Campo NOME está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (mtbCPF.MaskFull == false)
                {
                    MessageBox.Show("Campo CPF está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (mtbTelefone.MaskFull == false)
                {
                    MessageBox.Show("Campo TELEFONE está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                try
                {
                    
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                    string sql = "insert into tb_tecnico(nome,cpf,telefone) values" + "('" + txtNome.Text + "','" + mtbCPF.Text + "','" + mtbTelefone.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Cadastro realizado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                finally
                {
                    con.desconectar();
                }
            }

                

            
        }

        private void iconFoto_Click(object sender, EventArgs e)
        {

        }

        private void mtbTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
