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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Працівники". При необходимости она может быть перемещена или удалена.
            this.працівникиTableAdapter.Fill(this.bDDataSet.Працівники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Відділеня". При необходимости она может быть перемещена или удалена.
            this.відділеняTableAdapter.Fill(this.bDDataSet.Відділеня);

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

            відділеняBindingSource.Filter = " Адрес LIKE '" + tb1.Text + "%'";
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            працівникиBindingSource.Filter = "[№ працівника] LIKE '" + tb2.Text + "%'";
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void головнеМеюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOtdelenia f = new AddOtdelenia(); // створити форму

            if (f.ShowDialog() == DialogResult.OK) // відобразити форму
            {
                // якщо OK, то додати працівника
                int NumOtd;
                 string Address, Namber, mail;
                NumOtd = Convert.ToInt16(f.textBox1.Text);
                
                Address = f.textBox2.Text; 
                Namber = f.textBox3.Text;
                mail = f.textBox4.Text;
                // працює
                this.відділеняTableAdapter.Insert(NumOtd, Address, Namber, mail); ; // вставка
                this.відділеняTableAdapter.Fill(this.BDDataSet.Account) // відображення
            }
        }
    }
}
