using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaVaiComAsOutras
{
    public partial class frmPassagens : Form
    {
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
    }
}
