
namespace Bank
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.працівникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вікDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відділенняDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.працівникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new Bank.BDDataSet();
            this.NumOtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.емайлDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відділеняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.відділеняTableAdapter = new Bank.BDDataSetTableAdapters.ВідділеняTableAdapter();
            this.працівникиTableAdapter = new Bank.BDDataSetTableAdapters.ПрацівникиTableAdapter();
            this.головнеМеюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відділенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.працівникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проМенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOtd,
            this.адресDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.емайлDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.відділеняBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 148);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.працівникаDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn,
            this.вікDataGridViewTextBoxColumn,
            this.статьDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn1,
            this.відділенняDataGridViewTextBoxColumn1,
            this.посадаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.працівникиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(35, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(845, 170);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Відділеня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Посада";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головнеМеюToolStripMenuItem,
            this.відділенняToolStripMenuItem,
            this.працівникиToolStripMenuItem,
            this.проМенеToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пошук";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пошук";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(430, 40);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 7;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(744, 264);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 8;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // працівникаDataGridViewTextBoxColumn
            // 
            this.працівникаDataGridViewTextBoxColumn.DataPropertyName = "№ працівника";
            this.працівникаDataGridViewTextBoxColumn.HeaderText = "№ працівника";
            this.працівникаDataGridViewTextBoxColumn.Name = "працівникаDataGridViewTextBoxColumn";
            // 
            // імяDataGridViewTextBoxColumn
            // 
            this.імяDataGridViewTextBoxColumn.DataPropertyName = "Імя";
            this.імяDataGridViewTextBoxColumn.HeaderText = "Імя";
            this.імяDataGridViewTextBoxColumn.Name = "імяDataGridViewTextBoxColumn";
            // 
            // датаНародженняDataGridViewTextBoxColumn
            // 
            this.датаНародженняDataGridViewTextBoxColumn.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.Name = "датаНародженняDataGridViewTextBoxColumn";
            // 
            // вікDataGridViewTextBoxColumn
            // 
            this.вікDataGridViewTextBoxColumn.DataPropertyName = "Вік";
            this.вікDataGridViewTextBoxColumn.HeaderText = "Вік";
            this.вікDataGridViewTextBoxColumn.Name = "вікDataGridViewTextBoxColumn";
            // 
            // статьDataGridViewTextBoxColumn
            // 
            this.статьDataGridViewTextBoxColumn.DataPropertyName = "Стать";
            this.статьDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.статьDataGridViewTextBoxColumn.Name = "статьDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn1
            // 
            this.адресDataGridViewTextBoxColumn1.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn1.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn1.Name = "адресDataGridViewTextBoxColumn1";
            // 
            // відділенняDataGridViewTextBoxColumn1
            // 
            this.відділенняDataGridViewTextBoxColumn1.DataPropertyName = "Відділення";
            this.відділенняDataGridViewTextBoxColumn1.HeaderText = "Відділення";
            this.відділенняDataGridViewTextBoxColumn1.Name = "відділенняDataGridViewTextBoxColumn1";
            // 
            // посадаDataGridViewTextBoxColumn
            // 
            this.посадаDataGridViewTextBoxColumn.DataPropertyName = "Посада";
            this.посадаDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.посадаDataGridViewTextBoxColumn.Name = "посадаDataGridViewTextBoxColumn";
            // 
            // працівникиBindingSource
            // 
            this.працівникиBindingSource.DataMember = "Працівники";
            this.працівникиBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NumOtd
            // 
            this.NumOtd.DataPropertyName = "№ відділення";
            this.NumOtd.HeaderText = "№ відділення";
            this.NumOtd.Name = "NumOtd";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // емайлDataGridViewTextBoxColumn
            // 
            this.емайлDataGridViewTextBoxColumn.DataPropertyName = "Емайл";
            this.емайлDataGridViewTextBoxColumn.HeaderText = "Емайл";
            this.емайлDataGridViewTextBoxColumn.Name = "емайлDataGridViewTextBoxColumn";
            // 
            // відділеняBindingSource
            // 
            this.відділеняBindingSource.DataMember = "Відділеня";
            this.відділеняBindingSource.DataSource = this.bDDataSet;
            // 
            // відділеняTableAdapter
            // 
            this.відділеняTableAdapter.ClearBeforeFill = true;
            // 
            // працівникиTableAdapter
            // 
            this.працівникиTableAdapter.ClearBeforeFill = true;
            // 
            // головнеМеюToolStripMenuItem
            // 
            this.головнеМеюToolStripMenuItem.Name = "головнеМеюToolStripMenuItem";
            this.головнеМеюToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.головнеМеюToolStripMenuItem.Text = "Головне мею";
            this.головнеМеюToolStripMenuItem.Click += new System.EventHandler(this.головнеМеюToolStripMenuItem_Click);
            // 
            // відділенняToolStripMenuItem
            // 
            this.відділенняToolStripMenuItem.Name = "відділенняToolStripMenuItem";
            this.відділенняToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.відділенняToolStripMenuItem.Text = "Відділення";
            // 
            // працівникиToolStripMenuItem
            // 
            this.працівникиToolStripMenuItem.Name = "працівникиToolStripMenuItem";
            this.працівникиToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.працівникиToolStripMenuItem.Text = "Працівники";
            // 
            // проМенеToolStripMenuItem
            // 
            this.проМенеToolStripMenuItem.Name = "проМенеToolStripMenuItem";
            this.проМенеToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.проМенеToolStripMenuItem.Text = "Про мене";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 547);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource відділеняBindingSource;
        private BDDataSetTableAdapters.ВідділеняTableAdapter відділеняTableAdapter;
        private System.Windows.Forms.BindingSource працівникиBindingSource;
        private BDDataSetTableAdapters.ПрацівникиTableAdapter працівникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn працівникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вікDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn відділенняDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn посадаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn емайлDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.ToolStripMenuItem головнеМеюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відділенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem працівникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проМенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
    }
}