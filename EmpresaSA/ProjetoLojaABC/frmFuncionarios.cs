﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoLojaABC
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            // habilitar os campos
            habilitarCamposAlterar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gpbFuncionario_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        // criando método de limpar campos

        public void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtEmail.Clear();
            mskCEP.Clear();
            mskCPF.Clear();
            cbbEstado.Items.Clear();
            cbbEstado.Text = "";
            txtNome.Focus();

        }
        // desabilitar campos

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtEmail.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;
            dtpNascimento.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;




        }  // desabilitar campos novo (botão cadastrar)

        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtEmail.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            cbbEstado.Enabled = false;
            dtpNascimento.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();

        }


        // habilitar campos

        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtEmail.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            cbbEstado.Enabled = true;
            dtpNascimento.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }        // habilitar campos alterar

        public void habilitarCamposAlterar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtEmail.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            cbbEstado.Enabled = true;
            dtpNascimento.Enabled = true;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtEndereco.Text.Equals("")
                || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("")
                || mskCPF.Text.Equals("   .   .   -") || mskCEP.Text.Equals("     -") || cbbEstado.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher campos!!!");
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!");
                desabilitarCamposNovo();
                LimparCampos();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", 
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Mensagem do sistema", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (resp == DialogResult.OK)
            {
                LimparCampos();
            }
            else
            {

            }
        }

        private void btnCarregaCEP_Click(object sender, EventArgs e)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            WSCorreios.enderecoERP endereco = ws.consultaCEP(mskCEP.Text);
            txtEndereco.Text = endereco.end;
            txtBairro.Text = endereco.bairro;
            txtCidade.Text = endereco.cidade;
            cbbEstado.Text = endereco.uf;

        }
    }
}