namespace Service_Desk
{
    partial class Atendimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtvCliente = new System.Windows.Forms.DataGridView();
            this.chkPresencial = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHist = new System.Windows.Forms.RichTextBox();
            this.dtvTec = new System.Windows.Forms.DataGridView();
            this.labeltec = new System.Windows.Forms.Label();
            this.labeldata = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboSubCategoria = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboOperacao = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.labeleq = new System.Windows.Forms.Label();
            this.txtEquip = new System.Windows.Forms.RichTextBox();
            this.cboUrgencia = new System.Windows.Forms.ComboBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTec)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Urgencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(585, 489);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 42;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tipo";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(600, 221);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 40;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(93, 76);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(399, 20);
            this.txtPesquisar.TabIndex = 31;
            // 
            // dtvCliente
            // 
            this.dtvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCliente.Location = new System.Drawing.Point(12, 103);
            this.dtvCliente.Name = "dtvCliente";
            this.dtvCliente.Size = new System.Drawing.Size(480, 604);
            this.dtvCliente.TabIndex = 30;
            this.dtvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvCliente_CellContentClick);
            this.dtvCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvCliente_CellContentDoubleClick);
            // 
            // chkPresencial
            // 
            this.chkPresencial.AutoSize = true;
            this.chkPresencial.Location = new System.Drawing.Point(526, 544);
            this.chkPresencial.Name = "chkPresencial";
            this.chkPresencial.Size = new System.Drawing.Size(142, 17);
            this.chkPresencial.TabIndex = 29;
            this.chkPresencial.Text = "Atendimento presencial?";
            this.chkPresencial.UseVisualStyleBackColor = true;
            this.chkPresencial.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1248, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 28;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(527, 93);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(285, 78);
            this.txtDesc.TabIndex = 49;
            this.txtDesc.Text = "";
            this.txtDesc.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Descrição do problema";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Procedimento realizado";
            // 
            // txtHist
            // 
            this.txtHist.Location = new System.Drawing.Point(526, 396);
            this.txtHist.Name = "txtHist";
            this.txtHist.Size = new System.Drawing.Size(205, 55);
            this.txtHist.TabIndex = 51;
            this.txtHist.Text = "";
            // 
            // dtvTec
            // 
            this.dtvTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvTec.Location = new System.Drawing.Point(903, 93);
            this.dtvTec.Name = "dtvTec";
            this.dtvTec.Size = new System.Drawing.Size(444, 149);
            this.dtvTec.TabIndex = 53;
            this.dtvTec.Visible = false;
            this.dtvTec.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvTec_CellContentDoubleClick);
            // 
            // labeltec
            // 
            this.labeltec.AutoSize = true;
            this.labeltec.Location = new System.Drawing.Point(900, 77);
            this.labeltec.Name = "labeltec";
            this.labeltec.Size = new System.Drawing.Size(108, 13);
            this.labeltec.TabIndex = 55;
            this.labeltec.Text = "Técinicos disponiveis";
            this.labeltec.Visible = false;
            // 
            // labeldata
            // 
            this.labeldata.AutoSize = true;
            this.labeldata.Location = new System.Drawing.Point(900, 383);
            this.labeldata.Name = "labeldata";
            this.labeldata.Size = new System.Drawing.Size(157, 13);
            this.labeldata.TabIndex = 56;
            this.labeldata.Text = "Data de atendimento presencial";
            this.labeldata.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Categoria";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(600, 248);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 57;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(523, 276);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Sub categoria";
            // 
            // cboSubCategoria
            // 
            this.cboSubCategoria.FormattingEnabled = true;
            this.cboSubCategoria.Location = new System.Drawing.Point(600, 275);
            this.cboSubCategoria.Name = "cboSubCategoria";
            this.cboSubCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboSubCategoria.TabIndex = 59;
            this.cboSubCategoria.SelectedIndexChanged += new System.EventHandler(this.cboSubCategoria_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(525, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "Operação";
            // 
            // cboOperacao
            // 
            this.cboOperacao.FormattingEnabled = true;
            this.cboOperacao.Location = new System.Drawing.Point(600, 302);
            this.cboOperacao.Name = "cboOperacao";
            this.cboOperacao.Size = new System.Drawing.Size(121, 21);
            this.cboOperacao.TabIndex = 61;
            this.cboOperacao.SelectedIndexChanged += new System.EventHandler(this.cboOperacao_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(524, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "Histórico:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(737, 418);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "Hora";
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(773, 415);
            this.mtbHora.Mask = "00:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(33, 20);
            this.mtbHora.TabIndex = 65;
            // 
            // labeleq
            // 
            this.labeleq.AutoSize = true;
            this.labeleq.Location = new System.Drawing.Point(900, 267);
            this.labeleq.Name = "labeleq";
            this.labeleq.Size = new System.Drawing.Size(74, 13);
            this.labeleq.TabIndex = 83;
            this.labeleq.Text = "Equipamentos";
            this.labeleq.Visible = false;
            // 
            // txtEquip
            // 
            this.txtEquip.Location = new System.Drawing.Point(903, 283);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(444, 78);
            this.txtEquip.TabIndex = 84;
            this.txtEquip.Text = "";
            this.txtEquip.Visible = false;
            // 
            // cboUrgencia
            // 
            this.cboUrgencia.FormattingEnabled = true;
            this.cboUrgencia.Location = new System.Drawing.Point(600, 195);
            this.cboUrgencia.Name = "cboUrgencia";
            this.cboUrgencia.Size = new System.Drawing.Size(121, 21);
            this.cboUrgencia.TabIndex = 85;
            this.cboUrgencia.SelectedIndexChanged += new System.EventHandler(this.cboUrgencia_SelectedIndexChanged);
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(903, 411);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(71, 20);
            this.mtbData.TabIndex = 86;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            this.mtbData.Visible = false;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 758);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.cboUrgencia);
            this.Controls.Add(this.txtEquip);
            this.Controls.Add(this.labeleq);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboOperacao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cboSubCategoria);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.labeldata);
            this.Controls.Add(this.labeltec);
            this.Controls.Add(this.dtvTec);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dtvCliente);
            this.Controls.Add(this.chkPresencial);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.Atendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dtvCliente;
        private System.Windows.Forms.CheckBox chkPresencial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtHist;
        private System.Windows.Forms.DataGridView dtvTec;
        private System.Windows.Forms.Label labeltec;
        private System.Windows.Forms.Label labeldata;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboSubCategoria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboOperacao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.Label labeleq;
        private System.Windows.Forms.RichTextBox txtEquip;
        private System.Windows.Forms.ComboBox cboUrgencia;
        private System.Windows.Forms.MaskedTextBox mtbData;
    }
}