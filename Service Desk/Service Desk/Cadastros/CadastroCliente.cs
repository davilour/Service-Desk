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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            
        }


        ClassConexao con = new ClassConexao(); //instanciando a classe
        public int codigo; //daclaro o codigo
        //public int codPerfil;
        ClassUsuario usu = new ClassUsuario();


        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text, cpf = mtbCPF.Text, tele = mtbTelefone.Text, Endereco = txtEndereco.Text;
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
                if(Endereco == "")
                {
                    MessageBox.Show("Campo ENDEREÇO está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                try
                {
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                        string sql = "insert into tb_cliente(nome,cpf,telefone,endereco) values" + "('" + txtNome.Text + "','" + mtbCPF.Text + "','" + mtbTelefone.Text + "','" + txtEndereco.Text + "')";
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

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        
    }
}
