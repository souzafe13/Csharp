
namespace MariaVaiComAsOutras
{
    partial class frmComissao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComissao));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorDaPassagem = new System.Windows.Forms.Label();
            this.txtValorDaPassagem = new System.Windows.Forms.TextBox();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.txtValorDaComissao = new System.Windows.Forms.TextBox();
            this.lblValorDaComissao = new System.Windows.Forms.Label();
            this.txtValorFinalDaPassagem = new System.Windows.Forms.TextBox();
            this.lblValorFinalPassagem = new System.Windows.Forms.Label();
            this.cbbVendedores = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.gpbCalcular = new System.Windows.Forms.GroupBox();
            this.rdbPacNac10 = new System.Windows.Forms.RadioButton();
            this.rdbPacInt20 = new System.Windows.Forms.RadioButton();
            this.rdbPassNac10 = new System.Windows.Forms.RadioButton();
            this.rdbPassInt20 = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbResultado.SuspendLayout();
            this.gpbCalcular.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(327, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 45);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorDaPassagem
            // 
            this.lblValorDaPassagem.AutoSize = true;
            this.lblValorDaPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaPassagem.Location = new System.Drawing.Point(26, 86);
            this.lblValorDaPassagem.Name = "lblValorDaPassagem";
            this.lblValorDaPassagem.Size = new System.Drawing.Size(190, 24);
            this.lblValorDaPassagem.TabIndex = 1;
            this.lblValorDaPassagem.Text = "Valor da Passagem";
            // 
            // txtValorDaPassagem
            // 
            this.txtValorDaPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaPassagem.Location = new System.Drawing.Point(30, 129);
            this.txtValorDaPassagem.Name = "txtValorDaPassagem";
            this.txtValorDaPassagem.Size = new System.Drawing.Size(175, 26);
            this.txtValorDaPassagem.TabIndex = 1;
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidade.Location = new System.Drawing.Point(302, 22);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(119, 24);
            this.lblModalidade.TabIndex = 3;
            this.lblModalidade.Text = "Modalidade";
            // 
            // txtValorDaComissao
            // 
            this.txtValorDaComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaComissao.Location = new System.Drawing.Point(118, 79);
            this.txtValorDaComissao.Name = "txtValorDaComissao";
            this.txtValorDaComissao.Size = new System.Drawing.Size(175, 26);
            this.txtValorDaComissao.TabIndex = 5;
            // 
            // lblValorDaComissao
            // 
            this.lblValorDaComissao.AutoSize = true;
            this.lblValorDaComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaComissao.Location = new System.Drawing.Point(114, 27);
            this.lblValorDaComissao.Name = "lblValorDaComissao";
            this.lblValorDaComissao.Size = new System.Drawing.Size(185, 24);
            this.lblValorDaComissao.TabIndex = 5;
            this.lblValorDaComissao.Text = "Valor da Comissão";
            // 
            // txtValorFinalDaPassagem
            // 
            this.txtValorFinalDaPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinalDaPassagem.Location = new System.Drawing.Point(448, 79);
            this.txtValorFinalDaPassagem.Name = "txtValorFinalDaPassagem";
            this.txtValorFinalDaPassagem.Size = new System.Drawing.Size(182, 26);
            this.txtValorFinalDaPassagem.TabIndex = 6;
            // 
            // lblValorFinalPassagem
            // 
            this.lblValorFinalPassagem.AutoSize = true;
            this.lblValorFinalPassagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinalPassagem.Location = new System.Drawing.Point(424, 27);
            this.lblValorFinalPassagem.Name = "lblValorFinalPassagem";
            this.lblValorFinalPassagem.Size = new System.Drawing.Size(242, 24);
            this.lblValorFinalPassagem.TabIndex = 7;
            this.lblValorFinalPassagem.Text = "Valor Final da Passagem";
            // 
            // cbbVendedores
            // 
            this.cbbVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVendedores.FormattingEnabled = true;
            this.cbbVendedores.Items.AddRange(new object[] {
            "Julia Maria",
            "Fernanda Maria",
            "Rafaela Maria",
            "Laura Maria",
            "Renata Maria",
            "Emanoela Aparecida"});
            this.cbbVendedores.Location = new System.Drawing.Point(518, 129);
            this.cbbVendedores.Name = "cbbVendedores";
            this.cbbVendedores.Size = new System.Drawing.Size(182, 28);
            this.cbbVendedores.TabIndex = 3;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(563, 86);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(103, 24);
            this.lblVendedor.TabIndex = 9;
            this.lblVendedor.Text = "Vendedor";
            // 
            // gpbResultado
            // 
            this.gpbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.gpbResultado.Controls.Add(this.lblValorFinalPassagem);
            this.gpbResultado.Controls.Add(this.txtValorFinalDaPassagem);
            this.gpbResultado.Controls.Add(this.txtValorDaComissao);
            this.gpbResultado.Controls.Add(this.lblValorDaComissao);
            this.gpbResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(29, 298);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(740, 128);
            this.gpbResultado.TabIndex = 11;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // gpbCalcular
            // 
            this.gpbCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.gpbCalcular.Controls.Add(this.rdbPacNac10);
            this.gpbCalcular.Controls.Add(this.rdbPacInt20);
            this.gpbCalcular.Controls.Add(this.rdbPassNac10);
            this.gpbCalcular.Controls.Add(this.rdbPassInt20);
            this.gpbCalcular.Controls.Add(this.lblVendedor);
            this.gpbCalcular.Controls.Add(this.cbbVendedores);
            this.gpbCalcular.Controls.Add(this.lblValorDaPassagem);
            this.gpbCalcular.Controls.Add(this.txtValorDaPassagem);
            this.gpbCalcular.Controls.Add(this.lblModalidade);
            this.gpbCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCalcular.Location = new System.Drawing.Point(29, 23);
            this.gpbCalcular.Name = "gpbCalcular";
            this.gpbCalcular.Size = new System.Drawing.Size(740, 224);
            this.gpbCalcular.TabIndex = 1;
            this.gpbCalcular.TabStop = false;
            this.gpbCalcular.Text = "Calcular Comissão";
            // 
            // rdbPacNac10
            // 
            this.rdbPacNac10.AutoSize = true;
            this.rdbPacNac10.Location = new System.Drawing.Point(243, 165);
            this.rdbPacNac10.Name = "rdbPacNac10";
            this.rdbPacNac10.Size = new System.Drawing.Size(178, 24);
            this.rdbPacNac10.TabIndex = 13;
            this.rdbPacNac10.TabStop = true;
            this.rdbPacNac10.Text = "Pacote Nacional 10%";
            this.rdbPacNac10.UseVisualStyleBackColor = true;
            // 
            // rdbPacInt20
            // 
            this.rdbPacInt20.AutoSize = true;
            this.rdbPacInt20.Location = new System.Drawing.Point(243, 129);
            this.rdbPacInt20.Name = "rdbPacInt20";
            this.rdbPacInt20.Size = new System.Drawing.Size(209, 24);
            this.rdbPacInt20.TabIndex = 12;
            this.rdbPacInt20.TabStop = true;
            this.rdbPacInt20.Text = "Pacote Internacional 20%";
            this.rdbPacInt20.UseVisualStyleBackColor = true;
            // 
            // rdbPassNac10
            // 
            this.rdbPassNac10.AutoSize = true;
            this.rdbPassNac10.Location = new System.Drawing.Point(243, 96);
            this.rdbPassNac10.Name = "rdbPassNac10";
            this.rdbPassNac10.Size = new System.Drawing.Size(203, 24);
            this.rdbPassNac10.TabIndex = 11;
            this.rdbPassNac10.TabStop = true;
            this.rdbPassNac10.Text = "Passagem Nacional 10%";
            this.rdbPassNac10.UseVisualStyleBackColor = true;
            // 
            // rdbPassInt20
            // 
            this.rdbPassInt20.AutoSize = true;
            this.rdbPassInt20.Location = new System.Drawing.Point(243, 62);
            this.rdbPassInt20.Name = "rdbPassInt20";
            this.rdbPassInt20.Size = new System.Drawing.Size(234, 24);
            this.rdbPassInt20.TabIndex = 10;
            this.rdbPassInt20.TabStop = true;
            this.rdbPassInt20.Text = "Passagem Internacional 20%";
            this.rdbPassInt20.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(633, 436);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(136, 37);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(29, 436);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 37);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gpbCalcular);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comissionamento";
            this.Load += new System.EventHandler(this.frmcomissao_Load);
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.gpbCalcular.ResumeLayout(false);
            this.gpbCalcular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorDaPassagem;
        private System.Windows.Forms.TextBox txtValorDaPassagem;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.TextBox txtValorDaComissao;
        private System.Windows.Forms.Label lblValorDaComissao;
        private System.Windows.Forms.TextBox txtValorFinalDaPassagem;
        private System.Windows.Forms.Label lblValorFinalPassagem;
        private System.Windows.Forms.ComboBox cbbVendedores;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.GroupBox gpbCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rdbPassNac10;
        private System.Windows.Forms.RadioButton rdbPassInt20;
        private System.Windows.Forms.RadioButton rdbPacNac10;
        private System.Windows.Forms.RadioButton rdbPacInt20;
        private System.Windows.Forms.Button btnVoltar;
    }
}