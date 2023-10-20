
namespace MariaVaiComAsOutras
{
    partial class frmPassagens
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
            this.gpbDestinos = new System.Windows.Forms.GroupBox();
            this.ltbDestinos = new System.Windows.Forms.ListBox();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gpbDestinos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDestinos
            // 
            this.gpbDestinos.Controls.Add(this.txtDescricao);
            this.gpbDestinos.Controls.Add(this.lblDescricao);
            this.gpbDestinos.Controls.Add(this.btnPesquisar);
            this.gpbDestinos.Controls.Add(this.ltbDestinos);
            this.gpbDestinos.Controls.Add(this.lblInstrucao);
            this.gpbDestinos.Controls.Add(this.rdbInternacional);
            this.gpbDestinos.Controls.Add(this.rdbNacional);
            this.gpbDestinos.Controls.Add(this.lblData);
            this.gpbDestinos.Controls.Add(this.dtpData);
            this.gpbDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDestinos.Location = new System.Drawing.Point(35, 51);
            this.gpbDestinos.Name = "gpbDestinos";
            this.gpbDestinos.Size = new System.Drawing.Size(731, 349);
            this.gpbDestinos.TabIndex = 1;
            this.gpbDestinos.TabStop = false;
            this.gpbDestinos.Text = "Destinos";
            // 
            // ltbDestinos
            // 
            this.ltbDestinos.FormattingEnabled = true;
            this.ltbDestinos.ItemHeight = 18;
            this.ltbDestinos.Location = new System.Drawing.Point(70, 249);
            this.ltbDestinos.Name = "ltbDestinos";
            this.ltbDestinos.Size = new System.Drawing.Size(590, 94);
            this.ltbDestinos.TabIndex = 6;
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.Location = new System.Drawing.Point(187, 39);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(350, 18);
            this.lblInstrucao.TabIndex = 1;
            this.lblInstrucao.Text = "Escolha um destino nacional ou internacional";
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInternacional.Location = new System.Drawing.Point(325, 69);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(122, 22);
            this.rdbInternacional.TabIndex = 5;
            this.rdbInternacional.TabStop = true;
            this.rdbInternacional.Text = "Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNacional.Location = new System.Drawing.Point(135, 70);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(92, 22);
            this.rdbNacional.TabIndex = 4;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            this.rdbNacional.CheckedChanged += new System.EventHandler(this.rdbNacional_CheckedChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(81, 173);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(161, 18);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Selecione uma data:";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Location = new System.Drawing.Point(275, 167);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(308, 24);
            this.dtpData.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(691, 426);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(577, 69);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(119, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(157, 123);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(85, 18);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descricao";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(335, 117);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 24);
            this.txtDescricao.TabIndex = 9;
            // 
            // frmPassagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbDestinos);
            this.Name = "frmPassagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPassagens";
            this.Load += new System.EventHandler(this.frmPassagens_Load);
            this.gpbDestinos.ResumeLayout(false);
            this.gpbDestinos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDestinos;
        private System.Windows.Forms.ListBox ltbDestinos;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
    }
}