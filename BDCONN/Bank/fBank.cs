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
    public partial class fBank : Form
    {
        public fBank()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Відділеня". При необходимости она может быть перемещена или удалена.
            this.відділеняTableAdapter.Fill(this.bDDataSet.Відділеня);

        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.MovePrevious();
        }

        private void btAddOtd_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.AddNew();

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.MoveNext();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
         
            відділеняBindingSource.EndEdit();
            відділеняTableAdapter.Update(bDDataSet.Відділеня);
            MessageBox.Show("Update");
           
        }

        private void btDelOtd_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.RemoveCurrent();
        }
    }
}
