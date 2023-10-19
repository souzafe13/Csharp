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
    public partial class frmRoteiros : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmRoteiros()

        {
            InitializeComponent();
        }

        private void frmRoteiros_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnPacotes_Click(object sender, EventArgs e)
        {
            frmPacotes abrir = new frmPacotes();
            abrir.Show();
            this.Hide();
        }

        private void btnPassagens_Click(object sender, EventArgs e)
        {
            frmPassagens abrir = new frmPassagens();
            abrir.Show();
            this.Hide();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            frmHotel abrir = new frmHotel();
            abrir.Show();
            this.Hide();
        }
    }
}
