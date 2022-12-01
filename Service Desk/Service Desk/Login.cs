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
    public partial class Login : Form
    {
        ClassUsuario usu = new ClassUsuario();//chamo classe usuario
        ClassConexao con = new ClassConexao();//chamo a classe conexao
        public int codigoid;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Text = "";
                txtCPF.ForeColor = Color.Black;
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "CPF";
                txtCPF.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.Black;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        public void LerId()
        {
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao

            MySqlConnection conexao2 = con.getConexao();
            conexao2.Open();
           
            string consulta_id = "select id_atendente from tb_atendente where cpf=@cpf";

            MySqlCommand comando2 = new MySqlCommand(consulta_id, conexao2);
            comando2.Parameters.AddWithValue("@cpf", txtCPF.Text);
            MySqlDataReader registro2 = comando2.ExecuteReader();//executa a consulta
            registro2.Read();
            this.codigoid = Convert.ToInt32(registro2["id_atendente"]);
            
            MessageBox.Show("id atendente: " + this.codigoid);
            conexao2.Close();
        }



        private void btnAvancar_Click(object sender, EventArgs e)
        {


            String logar = "SELECT * FROM tb_atendente where cpf=@cpf AND senha=@senha";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
            comando.Parameters.AddWithValue("@senha", usu.getMD5hash(txtSenha.Text));
            MySqlDataReader registro = comando.ExecuteReader();//executa a consulta

            if (registro.HasRows)
            {
                registro.Read();
                usu.cpf = Convert.ToString(registro["cpf"]);
                usu.senha = Convert.ToString(registro["senha"]);
                usu.logado = true;
                conexao.Close();


                LerId();  


                Menu principal = new Menu(this.codigoid);
                principal.ShowDialog();
                

            }
            else
            {
                IconAlerta.Visible = true;
                lblAlerta.Visible = true;
                lblAlerta.Text = "CPF ou SENHA errados";
            }

            CustomLogin();

        }

        private void CustomLogin()
        {
            if (txtCPF.Text == "CPF" && txtSenha.Text == "SENHA")
            {
                IconAlerta.Visible = true;
                lblAlerta.Visible = true;
                lblAlerta.Text = "Campo CPF e SENHA esta em branco";
            }

            if (txtCPF.Text == "CPF" || txtSenha.Text == "SENHA")
            {
                IconAlerta.Visible = true;
                lblAlerta.Visible = true;

                if (txtSenha.Text == "SENHA")
                {
                    lblAlerta.Text = "Campo SENHA esta em branco";
                }

                if (txtCPF.Text == "CPF")
                {
                    lblAlerta.Text = "Campo CPF esta em branco";
                } 
            }
        }
    }
}
