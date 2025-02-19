using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Fix_UI_Vispro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Anda salah memasukkan Username atau Password!.");
            }
        }
    }
}
