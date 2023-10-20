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
        // habilitar campos
        public void habilitarCampos()
        {
            rdbNacional.Enabled = true;

        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        public void pesquisarNacional (string modalidade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select modalidade from tbPassagens where modalidade like '%" + modalidade + "%';"; ;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@modalidade", MySqlDbType.VarChar,15).Value = modalidade;

            comm.Connection = Conexao.obterConexao();

            // carregar na tabela

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbDestinos.Items.Clear();
            ltbDestinos.Items.Add(DR.GetString(0));

            Conexao.fecharConexao();
        }

        public void pesquisarInternacional(string modalidade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select modalidade from tbPassagens where modalidade like '%" + modalidade + "%';"; ;
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@modalidade", MySqlDbType.VarChar, 15).Value = modalidade;

            comm.Connection = Conexao.obterConexao();

            // carregar na tabela

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbDestinos.Items.Clear();
            ltbDestinos.Items.Add(DR.GetString(0));

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
        }
    }
}
