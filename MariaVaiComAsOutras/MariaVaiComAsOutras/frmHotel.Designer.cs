
namespace MariaVaiComAsOutras
{
    partial class frmHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotel));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbDestinos = new System.Windows.Forms.GroupBox();
            this.rdbResort = new System.Windows.Forms.RadioButton();
            this.rdbTresEst = new System.Windows.Forms.RadioButton();
            this.rdbQuatroEst = new System.Windows.Forms.RadioButton();
            this.lblQtDePessoas = new System.Windows.Forms.Label();
            this.cbbQtPessoas = new System.Windows.Forms.ComboBox();
            this.ltbDestinos = new System.Windows.Forms.ListBox();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.gpbDestinos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(691, 401);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbDestinos
            // 
            this.gpbDestinos.Controls.Add(this.rdbResort);
            this.gpbDestinos.Controls.Add(this.rdbTresEst);
            this.gpbDestinos.Controls.Add(this.rdbQuatroEst);
            this.gpbDestinos.Controls.Add(this.lblQtDePessoas);
            this.gpbDestinos.Controls.Add(this.cbbQtPessoas);
            this.gpbDestinos.Controls.Add(this.ltbDestinos);
            this.gpbDestinos.Controls.Add(this.lblInstrucao);
            this.gpbDestinos.Controls.Add(this.rdbInternacional);
            this.gpbDestinos.Controls.Add(this.rdbNacional);
            this.gpbDestinos.Controls.Add(this.lblData);
            this.gpbDestinos.Controls.Add(this.dtpData);
            this.gpbDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDestinos.Location = new System.Drawing.Point(35, 26);
            this.gpbDestinos.Name = "gpbDestinos";
            this.gpbDestinos.Size = new System.Drawing.Size(731, 349);
            this.gpbDestinos.TabIndex = 3;
            this.gpbDestinos.TabStop = false;
            this.gpbDestinos.Text = "Destinos";
            // 
            // rdbResort
            // 
            this.rdbResort.AutoSize = true;
            this.rdbResort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResort.Location = new System.Drawing.Point(488, 211);
            this.rdbResort.Name = "rdbResort";
            this.rdbResort.Size = new System.Drawing.Size(77, 22);
            this.rdbResort.TabIndex = 11;
            this.rdbResort.TabStop = true;
            this.rdbResort.Text = "Resort";
            this.rdbResort.UseVisualStyleBackColor = true;
            // 
            // rdbTresEst
            // 
            this.rdbTresEst.AutoSize = true;
            this.rdbTresEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTresEst.Location = new System.Drawing.Point(319, 211);
            this.rdbTresEst.Name = "rdbTresEst";
            this.rdbTresEst.Size = new System.Drawing.Size(127, 22);
            this.rdbTresEst.TabIndex = 10;
            this.rdbTresEst.TabStop = true;
            this.rdbTresEst.Text = "Três Estrelas";
            this.rdbTresEst.UseVisualStyleBackColor = true;
            // 
            // rdbQuatroEst
            // 
            this.rdbQuatroEst.AutoSize = true;
            this.rdbQuatroEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuatroEst.Location = new System.Drawing.Point(94, 211);
            this.rdbQuatroEst.Name = "rdbQuatroEst";
            this.rdbQuatroEst.Size = new System.Drawing.Size(145, 22);
            this.rdbQuatroEst.TabIndex = 9;
            this.rdbQuatroEst.TabStop = true;
            this.rdbQuatroEst.Text = "Quatro Estrelas";
            this.rdbQuatroEst.UseVisualStyleBackColor = true;
            // 
            // lblQtDePessoas
            // 
            this.lblQtDePessoas.AutoSize = true;
            this.lblQtDePessoas.Location = new System.Drawing.Point(393, 162);
            this.lblQtDePessoas.Name = "lblQtDePessoas";
            this.lblQtDePessoas.Size = new System.Drawing.Size(187, 18);
            this.lblQtDePessoas.TabIndex = 8;
            this.lblQtDePessoas.Text = "Quantidade de Pessoas";
            // 
            // cbbQtPessoas
            // 
            this.cbbQtPessoas.FormattingEnabled = true;
            this.cbbQtPessoas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10+"});
            this.cbbQtPessoas.Location = new System.Drawing.Point(590, 162);
            this.cbbQtPessoas.Name = "cbbQtPessoas";
            this.cbbQtPessoas.Size = new System.Drawing.Size(70, 26);
            this.cbbQtPessoas.TabIndex = 7;
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
            this.rdbInternacional.Location = new System.Drawing.Point(415, 183);
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
            this.rdbNacional.Location = new System.Drawing.Point(170, 183);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(92, 22);
            this.rdbNacional.TabIndex = 4;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(91, 106);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(161, 18);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Selecione uma data:";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Location = new System.Drawing.Point(272, 106);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(308, 24);
            this.dtpData.TabIndex = 3;
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbDestinos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.gpbDestinos.ResumeLayout(false);
            this.gpbDestinos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbDestinos;
        private System.Windows.Forms.Label lblQtDePessoas;
        private System.Windows.Forms.ComboBox cbbQtPessoas;
        private System.Windows.Forms.ListBox ltbDestinos;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.RadioButton rdbResort;
        private System.Windows.Forms.RadioButton rdbTresEst;
        private System.Windows.Forms.RadioButton rdbQuatroEst;
    }
}