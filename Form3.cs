﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Вклади". При необходимости она может быть перемещена или удалена.
            this.вкладиTableAdapter.Fill(this.bDDataSet.Вклади);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Кліенти". При необходимости она может быть перемещена или удалена.
            this.кліентиTableAdapter.Fill(this.bDDataSet.Кліенти);

        }
    }
}
