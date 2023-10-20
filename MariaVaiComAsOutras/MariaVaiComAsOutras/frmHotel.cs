using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MariaVaiComAsOutras
{
    public partial class frmHotel : Form
    {
        public frmHotel()
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
