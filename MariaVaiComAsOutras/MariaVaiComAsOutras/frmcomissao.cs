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


namespace MariaVaiComAsOutras
{
    public partial class frmComissao : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        
        public frmComissao()
        {
            InitializeComponent();
        }

        private void frmcomissao_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
              
        // limpar campos
        public void limparCampos()
        {
            txtValorDaPassagem.Clear();
            rdbPassInt20.Checked = false;
            rdbPassNac10.Checked = false;
            rdbPacInt20.Checked = false;
            rdbPacNac10.Checked = false;
            cbbVendedores.Text = "";
            txtValorDaComissao.Clear();
            txtValorFinalDaPassagem.Clear();

            txtValorDaPassagem.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, num3,num4, num5, resultado = 0;
            try
            {
                num1 = Convert.ToDouble(txtValorDaPassagem.Text);
                num2 = 20.0/100.0;               
                num3 = 10.0 / 100.0;
                num4 = 20.0 / 100.0;
                num5 = 10.0 / 100.0;

                if (rdbPassInt20.Checked || rdbPassNac10.Checked || rdbPacInt20.Checked || rdbPacNac10.Checked)
                {
                    if (rdbPassInt20.Checked)
                    {
                        resultado = num1 + (num2 * num1);
                    }
                    if (rdbPassNac10.Checked)
                    {
                        resultado = num1 + (num3 * num1);
                    }
                    if (rdbPacInt20.Checked)
                    {
                        resultado = num1 + (num4 * num1);
                    }
                    if (rdbPacNac10.Checked)
                    {
                        resultado = num1 + (num5 * num1);
                    }
                    txtValorFinalDaPassagem.Text = resultado.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma modalidade!",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                }

            } catch (Exception)
            {
                MessageBox.Show("Por favor, inserir somente números!",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                limparCampos();
            }

            try
            {
                num1 = Convert.ToDouble(txtValorDaPassagem.Text);
                num2 = 0.20;
                num3 = 0.10;
                num4 = 0.20;
                num5 = 0.10;

                if (rdbPassInt20.Checked || rdbPassNac10.Checked || rdbPacInt20.Checked || rdbPacNac10.Checked)
                {
                    if (rdbPassInt20.Checked)
                    {
                        resultado = num1 * num2;
                    }
                    if (rdbPassNac10.Checked)
                    {
                        resultado = num1 * num3;
                    }
                    if (rdbPacInt20.Checked)
                    {
                        resultado = num1 * num4;
                    }
                    if (rdbPacNac10.Checked)
                    {
                        resultado = num1 *num5;
                    }
                    txtValorDaComissao.Text = resultado.ToString();
                }
             

            }
            catch (Exception)
            {
                limparCampos();  
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPassagens abrir = new frmPassagens();
            abrir.Show();
            this.Hide();
        }
    }
}
