using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace MariaVaiComAsOutras
{
    public partial class frmPassagens : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPassagens()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmRoteiros abrir = new frmRoteiros();
            abrir.Show();
            this.Hide();
        }

        private void frmPassagens_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        // desabilitar campos
        public void desabilitarCampos()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            txtDescricao.Enabled = false;
            rdbNacional.Checked = false;
            rdbInternacional.Checked = false;
        }
        // habilitar campos
        public void habilitarCampos()
        {
          btnPesquisar.Enabled = true;
          btnLimpar.Enabled = true;
          txtDescricao.Enabled = true;
          txtDescricao.Focus();

        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        public void pesquisarNacional (string modalidade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select modalidade from tbPassagensNacionais where modalidade like '%" + modalidade + "%';"; ;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("modalidade", MySqlDbType.VarChar,15).Value = modalidade;

            comm.Connection = Conexao.obterConexao();

            // carregar na tabela

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbDestinos.Items.Clear();
            try
            {
                ltbDestinos.Items.Add(DR.GetString(0));
            }
            catch (Exception)
            {

                MessageBox.Show("Destino nacional indisponível no momento!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
            }
            

            Conexao.fecharConexao();
        }

        public void pesquisarInternacional(string modalidade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select modalidade from tbPassagensInternacionais where modalidade like '%" + modalidade + "%';"; ;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@modalidade", MySqlDbType.VarChar, 15).Value = modalidade;

            comm.Connection = Conexao.obterConexao();

            // carregar na tabela

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbDestinos.Items.Clear();

            try
            {
                ltbDestinos.Items.Add(DR.GetString(0));
            }
            catch (Exception)
            {

                MessageBox.Show("Destino internacional indisponível no momento!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            

            Conexao.fecharConexao();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNacional.Checked)
            {
                pesquisarNacional(Convert.ToString(txtDescricao.Text));
            }
            if (rdbInternacional.Checked)
            {
                pesquisarInternacional(Convert.ToString(txtDescricao.Text));
            }
            if (txtDescricao.Text.Equals(""))
            {
                limparCampos();
                MessageBox.Show("Por favor, escoha um destino!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);            
            }
           
            // mensagem do sistema quando não encontra/não há um destino
           
        }
        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbNacional.Checked = false;
            rdbInternacional.Checked = false;
            txtDescricao.Enabled = false;
            ltbDestinos.Items.Clear();
            txtDescricao.Enabled = true;

        }
        private void btnLimpar_Click(object sender, EventArgs e)
       
        {
            limparCampos();
        }

        private void ltbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbDestinos == null)
            {
                MessageBox.Show("Por favor, digite um destino", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            frmComissao abrir = new frmComissao();
            abrir.Show();
            this.Hide();
        }
    }
}
