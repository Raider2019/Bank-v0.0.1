using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class fGeneral : Form
    {
        public fGeneral()
        {
            InitializeComponent();
        }

        private void btnOpenBank_Click(object sender, EventArgs e)
        {
            fBank f = new fBank();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Головне меню", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void fGeneral_Load(object sender, EventArgs e)
        {

        }

        private void btnCliVKl_Click(object sender, EventArgs e)
        {
            fClients f = new fClients();
            f.Show();
            this.Hide();
        }
    }
}
