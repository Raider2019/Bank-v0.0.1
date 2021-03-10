
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
            this.NumOtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відділеняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new Bank.BDDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NumWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adrres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.працівникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.головнеМеюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кліентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проМенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.відділеняTableAdapter = new Bank.BDDataSetTableAdapters.ВідділеняTableAdapter();
            this.працівникиTableAdapter = new Bank.BDDataSetTableAdapters.ПрацівникиTableAdapter();
            this.btnAddOtd = new System.Windows.Forms.Button();
            this.btnEditOtd = new System.Windows.Forms.Button();
            this.btnDelOtd = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnEditWorker = new System.Windows.Forms.Button();
            this.btnDelWorker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOtd,
            this.Address,
            this.Namber,
            this.mail});
            this.dataGridView1.DataSource = this.відділеняBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // NumOtd
            // 
            this.NumOtd.DataPropertyName = "№ відділення";
            this.NumOtd.HeaderText = "№ відділення";
            this.NumOtd.Name = "NumOtd";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Адрес";
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // Namber
            // 
            this.Namber.DataPropertyName = "Номер";
            this.Namber.HeaderText = "Номер";
            this.Namber.Name = "Namber";
            // 
            // mail
            // 
            this.mail.DataPropertyName = "Емайл";
            this.mail.HeaderText = "Емайл";
            this.mail.Name = "mail";
            // 
            // відділеняBindingSource
            // 
            this.відділеняBindingSource.DataMember = "Відділеня";
            this.відділеняBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumWorker,
            this.Name,
            this.Date,
            this.age,
            this.WSex,
            this.Adrres,
            this.Otd,
            this.Pos});
            this.dataGridView2.DataSource = this.працівникиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(35, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(845, 170);
            this.dataGridView2.TabIndex = 1;
            // 
            // NumWorker
            // 
            this.NumWorker.DataPropertyName = "№ працівника";
            this.NumWorker.HeaderText = "№ працівника";
            this.NumWorker.Name = "NumWorker";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Імя";
            this.Name.HeaderText = "Імя";
            this.Name.Name = "Name";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Дата народження";
            this.Date.HeaderText = "Дата народження";
            this.Date.Name = "Date";
            // 
            // age
            // 
            this.age.DataPropertyName = "Вік";
            this.age.HeaderText = "Вік";
            this.age.Name = "age";
            // 
            // WSex
            // 
            this.WSex.DataPropertyName = "Стать";
            this.WSex.HeaderText = "Стать";
            this.WSex.Name = "WSex";
            // 
            // Adrres
            // 
            this.Adrres.DataPropertyName = "Адрес";
            this.Adrres.HeaderText = "Адрес";
            this.Adrres.Name = "Adrres";
            // 
            // Otd
            // 
            this.Otd.DataPropertyName = "Відділення";
            this.Otd.HeaderText = "Відділення";
            this.Otd.Name = "Otd";
            // 
            // Pos
            // 
            this.Pos.DataPropertyName = "Посада";
            this.Pos.HeaderText = "Посада";
            this.Pos.Name = "Pos";
            // 
            // працівникиBindingSource
            // 
            this.працівникиBindingSource.DataMember = "Працівники";
            this.працівникиBindingSource.DataSource = this.bDDataSet;
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
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Працівники";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головнеМеюToolStripMenuItem,
            this.кліентиToolStripMenuItem,
            this.проМенеToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // головнеМеюToolStripMenuItem
            // 
            this.головнеМеюToolStripMenuItem.Name = "головнеМеюToolStripMenuItem";
            this.головнеМеюToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.головнеМеюToolStripMenuItem.Text = "Головне мею";
            this.головнеМеюToolStripMenuItem.Click += new System.EventHandler(this.головнеМеюToolStripMenuItem_Click);
            // 
            // кліентиToolStripMenuItem
            // 
            this.кліентиToolStripMenuItem.Name = "кліентиToolStripMenuItem";
            this.кліентиToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.кліентиToolStripMenuItem.Text = "Кліенти";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 44);
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
            this.tb1.Location = new System.Drawing.Point(436, 37);
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
            // відділеняTableAdapter
            // 
            this.відділеняTableAdapter.ClearBeforeFill = true;
            // 
            // працівникиTableAdapter
            // 
            this.працівникиTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddOtd
            // 
            this.btnAddOtd.Location = new System.Drawing.Point(35, 228);
            this.btnAddOtd.Name = "btnAddOtd";
            this.btnAddOtd.Size = new System.Drawing.Size(75, 23);
            this.btnAddOtd.TabIndex = 9;
            this.btnAddOtd.Text = "Додати";
            this.btnAddOtd.UseVisualStyleBackColor = true;
            this.btnAddOtd.Click += new System.EventHandler(this.btnAddOtd_Click);
            // 
            // btnEditOtd
            // 
            this.btnEditOtd.Location = new System.Drawing.Point(178, 228);
            this.btnEditOtd.Name = "btnEditOtd";
            this.btnEditOtd.Size = new System.Drawing.Size(75, 23);
            this.btnEditOtd.TabIndex = 10;
            this.btnEditOtd.Text = "Змінити";
            this.btnEditOtd.UseVisualStyleBackColor = true;
            this.btnEditOtd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelOtd
            // 
            this.btnDelOtd.Location = new System.Drawing.Point(352, 228);
            this.btnDelOtd.Name = "btnDelOtd";
            this.btnDelOtd.Size = new System.Drawing.Size(75, 23);
            this.btnDelOtd.TabIndex = 11;
            this.btnDelOtd.Text = "Видалити";
            this.btnDelOtd.UseVisualStyleBackColor = true;
            this.btnDelOtd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(910, 315);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorker.TabIndex = 12;
            this.btnAddWorker.Text = "Додати";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnEditWorker
            // 
            this.btnEditWorker.Location = new System.Drawing.Point(910, 388);
            this.btnEditWorker.Name = "btnEditWorker";
            this.btnEditWorker.Size = new System.Drawing.Size(75, 23);
            this.btnEditWorker.TabIndex = 13;
            this.btnEditWorker.Text = "Змінити";
            this.btnEditWorker.UseVisualStyleBackColor = true;
            // 
            // btnDelWorker
            // 
            this.btnDelWorker.Location = new System.Drawing.Point(910, 458);
            this.btnDelWorker.Name = "btnDelWorker";
            this.btnDelWorker.Size = new System.Drawing.Size(75, 23);
            this.btnDelWorker.TabIndex = 14;
            this.btnDelWorker.Text = "Видалити";
            this.btnDelWorker.UseVisualStyleBackColor = true;
            this.btnDelWorker.Click += new System.EventHandler(this.btnDelWorker_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 547);
            this.Controls.Add(this.btnDelWorker);
            this.Controls.Add(this.btnEditWorker);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.btnDelOtd);
            this.Controls.Add(this.btnEditOtd);
            this.Controls.Add(this.btnAddOtd);
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
          //  this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.ToolStripMenuItem головнеМеюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проМенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кліентиToolStripMenuItem;
        private System.Windows.Forms.Button btnAddOtd;
        private System.Windows.Forms.Button btnEditOtd;
        private System.Windows.Forms.Button btnDelOtd;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnEditWorker;
        private System.Windows.Forms.Button btnDelWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namber;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn WSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adrres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pos;
    }
}