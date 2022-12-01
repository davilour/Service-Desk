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


    public partial class Atendimento : Form
    {
        public int codurg;
        public int codtipo;
        public int codcat;
        public int codsubcat;
        public int codop;
        public int codstatus;
        public int codigocli;
        public int codigotec;
        public int codigoid;
        ClassConexao con = new ClassConexao();
        
        public Atendimento(int codigoid)
        {
            InitializeComponent();
            this.codigoid = codigoid;
        }

        private void Atendimento_Load(object sender, EventArgs e)
        {
            cboUrgencia.DataSource = con.Geturg(); //popula as info do perfil da tabela
            cboUrgencia.DisplayMember = "urgencia"; //mostra descrição do campo
            cboUrgencia.ValueMember = "id_urgencia"; //pega o codigo do campo

            cboTipo.DataSource = con.Gettipo(); //popula as info do perfil da tabela
            cboTipo.DisplayMember = "tipo"; //mostra descrição do campo
            cboTipo.ValueMember = "id_tipo_atendimento"; //pega o codigo do campo

            cboCategoria.DataSource = con.Getcat(); //popula as info do perfil da tabela
            cboCategoria.DisplayMember = "categoria"; //mostra descrição do campo
            cboCategoria.ValueMember = "id_categoria"; //pega o codigo do campo

            cboSubCategoria.DataSource = con.Getsubcat(); //popula as info do perfil da tabela
            cboSubCategoria.DisplayMember = "subcategoria"; //mostra descrição do campo
            cboSubCategoria.ValueMember = "id_subcategoria"; //pega o codigo do campo

            cboOperacao.DataSource = con.Getop(); //popula as info do perfil da tabela
            cboOperacao.DisplayMember = "operacao"; //mostra descrição do campo
            cboOperacao.ValueMember = "id_operacao"; //pega o codigo do campo

            cboStatus.DataSource = con.GetStatus(); //popula as info do perfil da tabela
            cboStatus.DisplayMember = "condicao"; //mostra descrição do campo
            cboStatus.ValueMember = "id_situacao"; //pega o codigo do campo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //instancia de conexão
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            if (txtPesquisar.Text == "") //Campo vazio lista tudo
            {
                consulta = "SELECT * from tb_cliente";
            }
            else //Se tiver informação lista
            {
                consulta = "SELECT * from tb_cliente where nome ='" + txtPesquisar.Text + "'";
            }
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtCliente = new DataTable();

            dados.Fill(dtCliente);//manipulação dos dados
            dtvCliente.DataSource = dtCliente;//chamo o caminho dos dados
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
           private void cboUrgencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            codurg = Convert.ToInt32(((DataRowView)cboUrgencia.SelectedItem)["id_urgencia"]);
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            codtipo = Convert.ToInt32(((DataRowView)cboTipo.SelectedItem)["id_tipo_atendimento"]);
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            codcat = Convert.ToInt32(((DataRowView)cboCategoria.SelectedItem)["id_categoria"]);
        }

        private void cboSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            codsubcat = Convert.ToInt32(((DataRowView)cboSubCategoria.SelectedItem)["id_subcategoria"]);
        }

        private void cboOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            codop = Convert.ToInt32(((DataRowView)cboOperacao.SelectedItem)["id_operacao"]);
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            codstatus = Convert.ToInt32(((DataRowView)cboStatus.SelectedItem)["id_situacao"]);
        }

        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkPresencial.Checked == true)
            {

                   

                labeltec.Visible = true;
                dtvTec.Visible = true;
                labeleq.Visible = true;
                txtEquip.Visible = true;
                labeldata.Visible = true;
                mtbData.Visible = true;

                ClassConexao con = new ClassConexao();
                //obtive a conexao
                MySqlConnection conexao = con.getConexao();
                String consulta;

                consulta = "SELECT * from tb_tecnico";

                //Monta meu comando sql
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();//Abro minha conexao
                               //monto a tabela de dados
                MySqlDataAdapter dados = new MySqlDataAdapter(commando);
                //Crio uma nova tabela de dados
                DataTable dtTec = new DataTable();

                dados.Fill(dtTec);//manipulação dos dados
                dtvTec.DataSource = dtTec;//chamo o caminho dos dados
            }
            if (chkPresencial.Checked == false)
            {
                labeltec.Visible = false;
                dtvTec.Visible = false;
                labeleq.Visible = false;
                txtEquip.Visible = false;
                labeldata.Visible = false;
                mtbData.Visible = false;
                txtEquip.Text = "";

            }
            
        }

        private void dtvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtvCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                this.codigocli = Convert.ToInt32(dtvCliente.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("Código Cliente: " + this.codigocli);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassUsuario usu = new ClassUsuario();
            MessageBox.Show("usu: " + this.codigoid);

            string presencial;
            if (chkPresencial.Checked == true)
            {
                presencial = "Sim";
            }
            else
            {
               presencial = "Não";
                codigotec = 1;
            }

            try
            {
                ClassConexao con = new ClassConexao();
                int id = 1;
                MySqlConnection conexao = con.getConexao();
                //para a segurança dos dados
                string sql = "insert into tb_atendimento(id_atendente,id_cliente,id_tecnico,id_categoria,id_subcategoria,id_operacao,id_situacao,id_urgencia,id_tipo_atendimento,descricao,presencial,hist,hora,dia) values" + "(" + id + "," + codigocli + "," + codigotec + "," + codcat + "," + codsubcat + "," + codop + "," + codstatus + "," + codurg + "," + codtipo + ",'" + txtDesc.Text + "','" + presencial + "','" +txtHist.Text + "','" + Convert.ToDateTime(mtbHora.Text)+ "','" + mtbData.Text + "')";
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

        private void dtvTec_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                this.codigotec = Convert.ToInt32(dtvCliente.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("Código Técnico: " + this.codigotec);

            }
        }
    }
}
