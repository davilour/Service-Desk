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
    public partial class CadastroAtendente : Form
    {

        ClassConexao con = new ClassConexao(); //instanciando a classe
        public int codigo; //daclaro o codigo
        public int codPerfil;
        ClassUsuario usu = new ClassUsuario();

        public CadastroAtendente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text, cpf = mtbCPF.Text, Senha = txtSenha.Text;
            if (nome == "" || mtbCPF.MaskFull == false )
            {
                if (nome == "")
                {
                    MessageBox.Show("Campo NOME está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (mtbCPF.MaskFull == false)
                {
                    MessageBox.Show("Campo CPF está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                if (Senha == "")
                {
                    MessageBox.Show("Campo SENHA está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                try
                {
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                    string sql = "insert into tb_atendente(nome,cpf,senha) values" + "('" + txtNome.Text + "','" + mtbCPF.Text + "','" + usu.getMD5hash(txtSenha.Text) + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    comando.Parameters.AddWithValue("@senha", txtSenha.Text);
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

        private void CadastroAtendente_Load(object sender, EventArgs e)
        {

        }
    }
}
