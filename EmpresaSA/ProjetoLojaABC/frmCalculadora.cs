﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaABC
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0.0;

            num1 = Convert.ToDouble(txtV1.Text);
            num2 = Convert.ToDouble(txtV2.Text);

            if (rdbAdicao.Checked || rdbSubtracao.Checked || rdbMultiplicacao.Checked || rdbDivisao.Checked)
            {

            
            if (rdbAdicao.Checked)
            {
                resultado = num1 + num2;
            }
            if (rdbSubtracao.Checked)
            {
                resultado = num1 - num2;
            }
            if (rdbMultiplicacao.Checked)
            {
                resultado = num1 * num2;
            }
            if (rdbDivisao.Checked)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Impossível dividir por zero!!!", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);

                }
                resultado = num1 / num2;
            }



            lblValorResultado.Text = resultado.ToString();
            limparCamposCalcular();
        }
        else
        {
                MessageBox.Show("Escolha uma operação", "Mensagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);

            }
        }

        // criando método para limpar conteúdo
        public void limparCamposCalcular()
        {
            txtV1.Text = "";
            txtV2.Clear();
            

            rdbAdicao.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;

            txtV1.Focus();
        }
        public void limparCampos()
        {
            txtV1.Text = "";
            txtV2.Clear();
            lblValorResultado.Text = "";

            rdbAdicao.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;

            txtV1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Declarando variável para recebr valor do botão pressionado

            DialogResult resp = MessageBox.Show("Deseja sair?", "Mensagem do sistema",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button3);

            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executar o método/função limpar campos
            limparCampos();

        }

        private void lblValorResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
