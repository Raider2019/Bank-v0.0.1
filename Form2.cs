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

       
        private void btnAddOtd_Click(object sender, EventArgs e)
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
                this.відділеняTableAdapter.Insert(NumOtd, Address, Namber, mail); // вставка
                this.відділеняTableAdapter.Fill(this.bDDataSet.Відділеня); // відображення
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditOtdelenia f = new EditOtdelenia(); // створити форму
            int index;
            int NumOtd;
            string Address, Namber, mail;

            if (dataGridView1.RowCount <= 1) return;
            index = dataGridView1.CurrentRow.Index;

            if (index == dataGridView1.RowCount - 1) return;

            NumOtd = (int)dataGridView1.Rows[index].Cells[0].Value;
            Address = (string)dataGridView1.Rows[index].Cells[1].Value;
            Namber = (string)dataGridView1.Rows[index].Cells[2].Value;
            mail = (string)dataGridView1.Rows[index].Cells[3].Value;

            f.textBox1.Text = Address;
            f.textBox2.Text = Namber;
            f.textBox3.Text = mail;

            if (f.ShowDialog() == DialogResult.OK)
            {
                string nAddress, nNumber, nmail;

                nAddress = f.textBox1.Text;
                nNumber = f.textBox2.Text;
                nmail = f.textBox3.Text;

                this.відділеняTableAdapter.Update(nAddress, nNumber, nmail, NumOtd, mail);
                this.відділеняTableAdapter.Fill(this.bDDataSet.Відділеня);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DelOtdelenia f = new DelOtdelenia(); // створити форму
            int NumOtd;
            string Address, Namber, mail;
            int index;


            index = dataGridView1.CurrentRow.Index;

            // заповнити внутрішні змінні з поточного рядка dataGridView1
            NumOtd = Convert.ToInt16(dataGridView1[0, index].Value);
            Address = Convert.ToString(dataGridView1[1, index].Value);
            Namber = Convert.ToString(dataGridView1[2, index].Value);
            mail = Convert.ToString(dataGridView1[3, index].Value);

            // сформувати інформаційний рядок
            f.label2.Text = NumOtd + " " + Address + " " + Namber + " " + mail;

            if (f.ShowDialog() == DialogResult.OK)
            {
                this.відділеняTableAdapter.Delete(NumOtd, mail);

                this.відділеняTableAdapter.Fill(this.bDDataSet.Відділеня);
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            AddWorker f = new AddWorker(); // створити форму
          

            if (f.ShowDialog() == DialogResult.OK) // відобразити форму
            {
                string NumWorker;
                  int   Otd;
                string Name, WSex, Adrres, Pos;
               short Age;
                NumWorker = f.textBox1.Text;
                Name = f.textBox2.Text;

                DateTime Date = Convert.ToDateTime(f.textBox3.Text);
                Age =Convert.ToInt16( f.textBox4.Text);
                WSex = f.textBox5.Text;
                Adrres = f.textBox6.Text;
                Otd = Convert.ToInt32(f.textBox7.Text);
                Pos = f.textBox8.Text;


                // працює
                this.працівникиTableAdapter.Insert(NumWorker,Name,Date,Age,WSex,Adrres,Otd,Pos); // вставка
                this.працівникиTableAdapter.Fill(this.bDDataSet.Працівники); // відображення
            }
        }

        private void btnDelWorker_Click(object sender, EventArgs e)
        {

            string NumWorker;
            int Otd;
            string Name, WSex, Adrres, Pos;
            short Age;
            DateTime Date;
            int index;

            DelWorker f = new DelWorker(); // створити форму
            index = dataGridView1.CurrentRow.Index;
            NumWorker = Convert.ToString(dataGridView1[0, index].Value);
            Name = Convert.ToString(dataGridView1[1, index].Value);
            Date = Convert.ToDateTime(dataGridView1[2, index].Value);
            Age = Convert.ToInt16(dataGridView1[3, index].Value);
            WSex = Convert.ToString(dataGridView1[4, index].Value);
            Adrres = Convert.ToString(dataGridView1[5, index].Value);
          Otd = Convert.ToInt32(dataGridView1[6, index].Value);
           Pos = Convert.ToString(dataGridView1[7, index].Value);
            f.label2.Text = NumWorker + " " + Name;
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.працівникиTableAdapter.Delete( NumWorker,Name,Date,Age,WSex,Adrres,Otd,Pos);

                this.працівникиTableAdapter.Fill(this.bDDataSet.Працівники);
            }
        } 
    }
    }
