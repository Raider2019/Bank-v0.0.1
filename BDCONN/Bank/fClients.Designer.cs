﻿
namespace Bank
{
    partial class fClients
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.кліентиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кліентиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new Bank.BDDataSet();
            this.кліентиTableAdapter = new Bank.BDDataSetTableAdapters.КліентиTableAdapter();
            this.tableAdapterManager = new Bank.BDDataSetTableAdapters.TableAdapterManager();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btCli = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btAddCli = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.вкладиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вкладиTableAdapter = new Bank.BDDataSetTableAdapters.ВкладиTableAdapter();
            this.вкладиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.gb4 = new System.Windows.Forms.GroupBox();
            this.btDelVkl = new System.Windows.Forms.Button();
            this.btUpdateVkl = new System.Windows.Forms.Button();
            this.btNextVkl = new System.Windows.Forms.Button();
            this.btAddVkl = new System.Windows.Forms.Button();
            this.btPrevVkl = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txSearchCli = new System.Windows.Forms.TextBox();
            this.btnSearhCli = new System.Windows.Forms.Button();
            this.RefreshCli = new System.Windows.Forms.Button();
            this.btSearchVkl = new System.Windows.Forms.Button();
            this.txSearhVkl = new System.Windows.Forms.TextBox();
            this.btRefreshVkl = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.кліентиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кліентиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вкладиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладиDataGridView)).BeginInit();
            this.gb3.SuspendLayout();
            this.gb4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.DarkOrange;
            this.gb1.Controls.Add(this.кліентиDataGridView);
            this.gb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb1.Location = new System.Drawing.Point(416, 30);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(965, 175);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Кліенти";
            // 
            // кліентиDataGridView
            // 
            this.кліентиDataGridView.AutoGenerateColumns = false;
            this.кліентиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.кліентиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.кліентиDataGridView.DataSource = this.кліентиBindingSource;
            this.кліентиDataGridView.Location = new System.Drawing.Point(24, 19);
            this.кліентиDataGridView.Name = "кліентиDataGridView";
            this.кліентиDataGridView.Size = new System.Drawing.Size(936, 128);
            this.кліентиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ІД";
            this.dataGridViewTextBoxColumn1.HeaderText = "ІД";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ПІБ";
            this.dataGridViewTextBoxColumn2.HeaderText = "ПІБ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрс";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стать";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стать";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата народження";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата народження";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Менеджер";
            this.dataGridViewTextBoxColumn7.HeaderText = "Менеджер";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "№ вклада";
            this.dataGridViewTextBoxColumn8.HeaderText = "№ вклада";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Сума вклада";
            this.dataGridViewTextBoxColumn9.HeaderText = "Сума вклада";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // кліентиBindingSource
            // 
            this.кліентиBindingSource.DataMember = "Кліенти";
            this.кліентиBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кліентиTableAdapter
            // 
            this.кліентиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bank.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідділеняTableAdapter = null;
            this.tableAdapterManager.ВкладиTableAdapter = null;
            this.tableAdapterManager.КліентиTableAdapter = this.кліентиTableAdapter;
            this.tableAdapterManager.ПрацівникиTableAdapter = null;
            // 
            // gb2
            // 
            this.gb2.BackColor = System.Drawing.Color.DarkOrange;
            this.gb2.Controls.Add(this.btCli);
            this.gb2.Controls.Add(this.btUpdate);
            this.gb2.Controls.Add(this.btNext);
            this.gb2.Controls.Add(this.btAddCli);
            this.gb2.Controls.Add(this.btPrev);
            this.gb2.Controls.Add(this.textBox12);
            this.gb2.Controls.Add(this.textBox11);
            this.gb2.Controls.Add(this.textBox10);
            this.gb2.Controls.Add(this.textBox9);
            this.gb2.Controls.Add(this.textBox8);
            this.gb2.Controls.Add(this.textBox7);
            this.gb2.Controls.Add(this.textBox4);
            this.gb2.Controls.Add(this.textBox5);
            this.gb2.Controls.Add(this.textBox6);
            this.gb2.Controls.Add(this.label10);
            this.gb2.Controls.Add(this.label11);
            this.gb2.Controls.Add(this.label12);
            this.gb2.Controls.Add(this.label13);
            this.gb2.Controls.Add(this.label14);
            this.gb2.Controls.Add(this.label15);
            this.gb2.Controls.Add(this.label16);
            this.gb2.Controls.Add(this.label17);
            this.gb2.Controls.Add(this.label18);
            this.gb2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb2.Location = new System.Drawing.Point(12, 30);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(386, 450);
            this.gb2.TabIndex = 12;
            this.gb2.TabStop = false;
            this.gb2.Text = "Дані кліента";
            // 
            // btCli
            // 
            this.btCli.Location = new System.Drawing.Point(155, 412);
            this.btCli.Name = "btCli";
            this.btCli.Size = new System.Drawing.Size(89, 32);
            this.btCli.TabIndex = 24;
            this.btCli.Text = "Видалити";
            this.btCli.UseVisualStyleBackColor = true;
            this.btCli.Click += new System.EventHandler(this.btCli_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(18, 412);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(91, 32);
            this.btUpdate.TabIndex = 23;
            this.btUpdate.Text = "Зберегти";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(278, 360);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(102, 35);
            this.btNext.TabIndex = 22;
            this.btNext.Text = "Наступний";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btAddCli
            // 
            this.btAddCli.Location = new System.Drawing.Point(155, 360);
            this.btAddCli.Name = "btAddCli";
            this.btAddCli.Size = new System.Drawing.Size(75, 35);
            this.btAddCli.TabIndex = 19;
            this.btAddCli.Text = "Додати";
            this.btAddCli.UseVisualStyleBackColor = true;
            this.btAddCli.Click += new System.EventHandler(this.btAddCli_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(18, 360);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(105, 35);
            this.btPrev.TabIndex = 18;
            this.btPrev.Text = "Попередній";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "Сума вклада", true));
            this.textBox12.Location = new System.Drawing.Point(115, 307);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(101, 26);
            this.textBox12.TabIndex = 17;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "№ вклада", true));
            this.textBox11.Location = new System.Drawing.Point(99, 276);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(58, 26);
            this.textBox11.TabIndex = 16;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "Менеджер", true));
            this.textBox10.Location = new System.Drawing.Point(99, 246);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(145, 26);
            this.textBox10.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "Дата народження", true));
            this.textBox9.Location = new System.Drawing.Point(141, 216);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(145, 26);
            this.textBox9.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "Телефон", true));
            this.textBox8.Location = new System.Drawing.Point(85, 180);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(145, 26);
            this.textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "Стать", true));
            this.textBox7.Location = new System.Drawing.Point(65, 147);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(44, 26);
            this.textBox7.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "Адрс", true));
            this.textBox4.Location = new System.Drawing.Point(65, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(288, 26);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "ПІБ", true));
            this.textBox5.Location = new System.Drawing.Point(65, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(288, 26);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кліентиBindingSource, "ІД", true));
            this.textBox6.Location = new System.Drawing.Point(65, 35);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(7, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Сума вклада";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "№ вклада";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Менеджер";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(7, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Дата народження";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(7, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Телефон";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(7, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Стать";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(7, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Адрес";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(7, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 19);
            this.label17.TabIndex = 1;
            this.label17.Text = "ПІБ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(7, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "ІД";
            // 
            // вкладиBindingSource
            // 
            this.вкладиBindingSource.DataMember = "Вклади";
            this.вкладиBindingSource.DataSource = this.bDDataSet;
            // 
            // вкладиTableAdapter
            // 
            this.вкладиTableAdapter.ClearBeforeFill = true;
            // 
            // вкладиDataGridView
            // 
            this.вкладиDataGridView.AutoGenerateColumns = false;
            this.вкладиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.вкладиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.вкладиDataGridView.DataSource = this.вкладиBindingSource;
            this.вкладиDataGridView.Location = new System.Drawing.Point(24, 28);
            this.вкладиDataGridView.Name = "вкладиDataGridView";
            this.вкладиDataGridView.Size = new System.Drawing.Size(433, 149);
            this.вкладиDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "№ вклада";
            this.dataGridViewTextBoxColumn10.HeaderText = "№ вклада";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Відсоток";
            this.dataGridViewTextBoxColumn11.HeaderText = "Відсоток";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Термін вкладу місяці";
            this.dataGridViewTextBoxColumn12.HeaderText = "Термін вкладу місяці";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Термін вкладу дні";
            this.dataGridViewTextBoxColumn13.HeaderText = "Термін вкладу дні";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // gb3
            // 
            this.gb3.BackColor = System.Drawing.Color.DarkOrange;
            this.gb3.Controls.Add(this.вкладиDataGridView);
            this.gb3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb3.Location = new System.Drawing.Point(416, 550);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(468, 188);
            this.gb3.TabIndex = 13;
            this.gb3.TabStop = false;
            this.gb3.Text = "gb3";
            // 
            // gb4
            // 
            this.gb4.BackColor = System.Drawing.Color.DarkOrange;
            this.gb4.Controls.Add(this.btDelVkl);
            this.gb4.Controls.Add(this.btUpdateVkl);
            this.gb4.Controls.Add(this.btNextVkl);
            this.gb4.Controls.Add(this.btAddVkl);
            this.gb4.Controls.Add(this.btPrevVkl);
            this.gb4.Controls.Add(this.textBox13);
            this.gb4.Controls.Add(this.textBox3);
            this.gb4.Controls.Add(this.textBox2);
            this.gb4.Controls.Add(this.textBox1);
            this.gb4.Controls.Add(this.label4);
            this.gb4.Controls.Add(this.label3);
            this.gb4.Controls.Add(this.label2);
            this.gb4.Controls.Add(this.label1);
            this.gb4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb4.Location = new System.Drawing.Point(12, 550);
            this.gb4.Name = "gb4";
            this.gb4.Size = new System.Drawing.Size(386, 350);
            this.gb4.TabIndex = 14;
            this.gb4.TabStop = false;
            this.gb4.Text = "groupBox1";
            // 
            // btDelVkl
            // 
            this.btDelVkl.Location = new System.Drawing.Point(141, 313);
            this.btDelVkl.Name = "btDelVkl";
            this.btDelVkl.Size = new System.Drawing.Size(89, 29);
            this.btDelVkl.TabIndex = 13;
            this.btDelVkl.Text = "Видалити";
            this.btDelVkl.UseVisualStyleBackColor = true;
            this.btDelVkl.Click += new System.EventHandler(this.btDelVkl_Click);
            // 
            // btUpdateVkl
            // 
            this.btUpdateVkl.Location = new System.Drawing.Point(11, 313);
            this.btUpdateVkl.Name = "btUpdateVkl";
            this.btUpdateVkl.Size = new System.Drawing.Size(103, 29);
            this.btUpdateVkl.TabIndex = 12;
            this.btUpdateVkl.Text = "Зберегти";
            this.btUpdateVkl.UseVisualStyleBackColor = true;
            this.btUpdateVkl.Click += new System.EventHandler(this.btUpdateVkl_Click);
            // 
            // btNextVkl
            // 
            this.btNextVkl.Location = new System.Drawing.Point(257, 255);
            this.btNextVkl.Name = "btNextVkl";
            this.btNextVkl.Size = new System.Drawing.Size(96, 39);
            this.btNextVkl.TabIndex = 10;
            this.btNextVkl.Text = "Наступний";
            this.btNextVkl.UseVisualStyleBackColor = true;
            this.btNextVkl.Click += new System.EventHandler(this.btNextVkl_Click);
            // 
            // btAddVkl
            // 
            this.btAddVkl.Location = new System.Drawing.Point(141, 255);
            this.btAddVkl.Name = "btAddVkl";
            this.btAddVkl.Size = new System.Drawing.Size(89, 39);
            this.btAddVkl.TabIndex = 9;
            this.btAddVkl.Text = "Додати";
            this.btAddVkl.UseVisualStyleBackColor = true;
            this.btAddVkl.Click += new System.EventHandler(this.btAddVkl_Click);
            // 
            // btPrevVkl
            // 
            this.btPrevVkl.Location = new System.Drawing.Point(11, 255);
            this.btPrevVkl.Name = "btPrevVkl";
            this.btPrevVkl.Size = new System.Drawing.Size(103, 39);
            this.btPrevVkl.TabIndex = 8;
            this.btPrevVkl.Text = "Попередній";
            this.btPrevVkl.UseVisualStyleBackColor = true;
            this.btPrevVkl.Click += new System.EventHandler(this.btPrevVkl_Click);
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладиBindingSource, "Термін вкладу дні", true));
            this.textBox13.Location = new System.Drawing.Point(191, 182);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 26);
            this.textBox13.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладиBindingSource, "Термін вкладу місяці", true));
            this.textBox3.Location = new System.Drawing.Point(191, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладиBindingSource, "Відсоток", true));
            this.textBox2.Location = new System.Drawing.Point(144, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вкладиBindingSource, "№ вклада", true));
            this.textBox1.Location = new System.Drawing.Point(115, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Термін вкладу дні";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Термін вкладу місяці";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Відсоток";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ вклада";
            // 
            // txSearchCli
            // 
            this.txSearchCli.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txSearchCli.Location = new System.Drawing.Point(568, 359);
            this.txSearchCli.Name = "txSearchCli";
            this.txSearchCli.Size = new System.Drawing.Size(374, 26);
            this.txSearchCli.TabIndex = 15;
            // 
            // btnSearhCli
            // 
            this.btnSearhCli.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearhCli.Location = new System.Drawing.Point(429, 353);
            this.btnSearhCli.Name = "btnSearhCli";
            this.btnSearhCli.Size = new System.Drawing.Size(99, 37);
            this.btnSearhCli.TabIndex = 16;
            this.btnSearhCli.Text = "Пошук";
            this.btnSearhCli.UseVisualStyleBackColor = true;
            this.btnSearhCli.Click += new System.EventHandler(this.btnSearhCli_Click);
            // 
            // RefreshCli
            // 
            this.RefreshCli.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshCli.Location = new System.Drawing.Point(23, 497);
            this.RefreshCli.Name = "RefreshCli";
            this.RefreshCli.Size = new System.Drawing.Size(98, 34);
            this.RefreshCli.TabIndex = 17;
            this.RefreshCli.Text = "Оновити";
            this.RefreshCli.UseVisualStyleBackColor = true;
            this.RefreshCli.Click += new System.EventHandler(this.RefreshCli_Click);
            // 
            // btSearchVkl
            // 
            this.btSearchVkl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchVkl.Location = new System.Drawing.Point(429, 798);
            this.btSearchVkl.Name = "btSearchVkl";
            this.btSearchVkl.Size = new System.Drawing.Size(99, 46);
            this.btSearchVkl.TabIndex = 18;
            this.btSearchVkl.Text = "Пошук";
            this.btSearchVkl.UseVisualStyleBackColor = true;
            this.btSearchVkl.Click += new System.EventHandler(this.btSearchVkl_Click);
            // 
            // txSearhVkl
            // 
            this.txSearhVkl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txSearhVkl.Location = new System.Drawing.Point(568, 805);
            this.txSearhVkl.Name = "txSearhVkl";
            this.txSearhVkl.Size = new System.Drawing.Size(361, 26);
            this.txSearhVkl.TabIndex = 19;
            // 
            // btRefreshVkl
            // 
            this.btRefreshVkl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshVkl.Location = new System.Drawing.Point(12, 906);
            this.btRefreshVkl.Name = "btRefreshVkl";
            this.btRefreshVkl.Size = new System.Drawing.Size(93, 33);
            this.btRefreshVkl.TabIndex = 20;
            this.btRefreshVkl.Text = "Оновити";
            this.btRefreshVkl.UseVisualStyleBackColor = true;
            this.btRefreshVkl.Click += new System.EventHandler(this.btRefreshVkl_Click);
            // 
            // fClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1392, 958);
            this.Controls.Add(this.btRefreshVkl);
            this.Controls.Add(this.txSearhVkl);
            this.Controls.Add(this.btSearchVkl);
            this.Controls.Add(this.RefreshCli);
            this.Controls.Add(this.btnSearhCli);
            this.Controls.Add(this.txSearchCli);
            this.Controls.Add(this.gb4);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "fClients";
            this.Text = "fClients";
            this.Load += new System.EventHandler(this.fClients_Load);
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.кліентиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кліентиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вкладиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладиDataGridView)).EndInit();
            this.gb3.ResumeLayout(false);
            this.gb4.ResumeLayout(false);
            this.gb4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource кліентиBindingSource;
        private BDDataSetTableAdapters.КліентиTableAdapter кліентиTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView кліентиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btCli;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btAddCli;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource вкладиBindingSource;
        private BDDataSetTableAdapters.ВкладиTableAdapter вкладиTableAdapter;
        private System.Windows.Forms.DataGridView вкладиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.GroupBox gb4;
        private System.Windows.Forms.Button btDelVkl;
        private System.Windows.Forms.Button btUpdateVkl;
        private System.Windows.Forms.Button btNextVkl;
        private System.Windows.Forms.Button btAddVkl;
        private System.Windows.Forms.Button btPrevVkl;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSearchCli;
        private System.Windows.Forms.Button btnSearhCli;
        private System.Windows.Forms.Button RefreshCli;
        private System.Windows.Forms.Button btSearchVkl;
        private System.Windows.Forms.TextBox txSearhVkl;
        private System.Windows.Forms.Button btRefreshVkl;
    }
}