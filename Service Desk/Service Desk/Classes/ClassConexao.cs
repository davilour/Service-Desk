using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Cria um alerta para o usuario
using MySql.Data.MySqlClient; //Biblioteca mysql
using System.Data;
using System.Security;

namespace Service_Desk
{
    class ClassConexao
    {
        // Variaveis de conexao
        static private string servidor = "localhost"; // caminho do servidor
        static private string bancodedados = "db_projeto"; // nome do banco
        static private string usuario = "root"; // nome padrão
        static private string senha = ""; //


        static public string StrCon = "server=" + servidor + ";database=" + bancodedados + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection getConexao()
        {
            MySqlConnection conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                getConexao().Open();//abrir a conexao bd
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result; //retorna a conexão
        }


        public void desconectar()
        {

            getConexao().Close();
        }
        public DataTable Geturg()
        {

            MySqlConnection conexao = getConexao();
            string SQL = "select * from tb_urgencia";

            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_urgencia = new DataTable();
            dados.Fill(tb_urgencia);
            return tb_urgencia;

            
        }

        public DataTable Gettipo()
        {

            MySqlConnection conexao = getConexao();
            string SQL = "select * from tb_tipo_atendimento";

            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_tipo_atendimento = new DataTable();
            dados.Fill(tb_tipo_atendimento);
            return tb_tipo_atendimento;


        }

        public DataTable Getcat()
        {

            MySqlConnection conexao = getConexao();
            string SQL = "select * from tb_categoria";

            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_categoria = new DataTable();
            dados.Fill(tb_categoria);
            return tb_categoria;


        }

        public DataTable Getsubcat()
        {

            MySqlConnection conexao = getConexao();
            string SQL = "select * from tb_sub_categoria";

            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_sub_categoria = new DataTable();
            dados.Fill(tb_sub_categoria);
            return tb_sub_categoria;


        }

        public DataTable Getop()
        {

            MySqlConnection conexao = getConexao();
            string SQL = "select * from tb_operacao";

            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_operacao = new DataTable();
            dados.Fill(tb_operacao);
            return tb_operacao;


        }

        public DataTable GetStatus()
        {

            MySqlConnection conexao = getConexao();
            string SQL = "select * from tb_situacao";

            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_situacao = new DataTable();
            dados.Fill(tb_situacao);
            return tb_situacao;


        }



    }
}