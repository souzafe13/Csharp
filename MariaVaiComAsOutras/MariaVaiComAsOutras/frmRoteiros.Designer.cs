
namespace MariaVaiComAsOutras
{
    partial class frmRoteiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoteiros));
            this.gpbRoteiros = new System.Windows.Forms.GroupBox();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnPassagens = new System.Windows.Forms.Button();
            this.btnPacotes = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbRoteiros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbRoteiros
            // 
            this.gpbRoteiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.gpbRoteiros.Controls.Add(this.btnHotel);
            this.gpbRoteiros.Controls.Add(this.btnPassagens);
            this.gpbRoteiros.Controls.Add(this.btnPacotes);
            this.gpbRoteiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRoteiros.Location = new System.Drawing.Point(35, 46);
            this.gpbRoteiros.Name = "gpbRoteiros";
            this.gpbRoteiros.Size = new System.Drawing.Size(724, 340);
            this.gpbRoteiros.TabIndex = 0;
            this.gpbRoteiros.TabStop = false;
            this.gpbRoteiros.Text = "Roteiros";
            // 
            // btnHotel
            // 
            this.btnHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnHotel.Image = ((System.Drawing.Image)(resources.GetObject("btnHotel.Image")));
            this.btnHotel.Location = new System.Drawing.Point(485, 44);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(215, 253);
            this.btnHotel.TabIndex = 3;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHotel.UseVisualStyleBackColor = false;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnPassagens
            // 
            this.btnPassagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnPassagens.Image = ((System.Drawing.Image)(resources.GetObject("btnPassagens.Image")));
            this.btnPassagens.Location = new System.Drawing.Point(252, 44);
            this.btnPassagens.Name = "btnPassagens";
            this.btnPassagens.Size = new System.Drawing.Size(215, 253);
            this.btnPassagens.TabIndex = 2;
            this.btnPassagens.Text = "Passagens";
            this.btnPassagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPassagens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPassagens.UseVisualStyleBackColor = false;
            this.btnPassagens.Click += new System.EventHandler(this.btnPassagens_Click);
            // 
            // btnPacotes
            // 
            this.btnPacotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnPacotes.Image = ((System.Drawing.Image)(resources.GetObject("btnPacotes.Image")));
            this.btnPacotes.Location = new System.Drawing.Point(22, 44);
            this.btnPacotes.Name = "btnPacotes";
            this.btnPacotes.Size = new System.Drawing.Size(215, 253);
            this.btnPacotes.TabIndex = 1;
            this.btnPacotes.Text = "Pacotes";
            this.btnPacotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPacotes.UseVisualStyleBackColor = false;
            this.btnPacotes.Click += new System.EventHandler(this.btnPacotes_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(224)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(35, 405);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 33);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // frmRoteiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbRoteiros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRoteiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maria Vai Com As Outras";
            this.Load += new System.EventHandler(this.frmRoteiros_Load);
            this.gpbRoteiros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbRoteiros;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnPassagens;
        private System.Windows.Forms.Button btnPacotes;
        private System.Windows.Forms.Button btnVoltar;
    }
}

