﻿
namespace Bank
{
    partial class fBank
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btDelOtd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btAddOtd = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.txb4 = new System.Windows.Forms.TextBox();
            this.відділеняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new Bank.BDDataSet();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.відділенняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.емайлDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відділеняTableAdapter = new Bank.BDDataSetTableAdapters.ВідділеняTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grb3 = new System.Windows.Forms.GroupBox();
            this.txb11 = new System.Windows.Forms.TextBox();
            this.працівникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txb12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelWork = new System.Windows.Forms.Button();
            this.btnUpdateWork = new System.Windows.Forms.Button();
            this.btnNextWork = new System.Windows.Forms.Button();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.btnPrevWork = new System.Windows.Forms.Button();
            this.txb8 = new System.Windows.Forms.TextBox();
            this.txb7 = new System.Windows.Forms.TextBox();
            this.txb6 = new System.Windows.Forms.TextBox();
            this.txb5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grb4 = new System.Windows.Forms.GroupBox();
            this.працівникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.працівникиTableAdapter = new Bank.BDDataSetTableAdapters.ПрацівникиTableAdapter();
            this.tableAdapterManager = new Bank.BDDataSetTableAdapters.TableAdapterManager();
            this.bdDataSet1 = new Bank.BDDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.txbSearchWorker = new System.Windows.Forms.TextBox();
            this.txbSearchOtd = new System.Windows.Forms.TextBox();
            this.tbSearchOtd = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.grb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.grb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).BeginInit();
            this.grb4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.DarkOrange;
            this.grb1.Controls.Add(this.btDelOtd);
            this.grb1.Controls.Add(this.btUpdate);
            this.grb1.Controls.Add(this.btNext);
            this.grb1.Controls.Add(this.btAddOtd);
            this.grb1.Controls.Add(this.btPrev);
            this.grb1.Controls.Add(this.txb4);
            this.grb1.Controls.Add(this.txb3);
            this.grb1.Controls.Add(this.txb2);
            this.grb1.Controls.Add(this.txb1);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grb1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb1.Location = new System.Drawing.Point(0, 27);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(413, 314);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Дані відділення";
            // 
            // btDelOtd
            // 
            this.btDelOtd.Location = new System.Drawing.Point(152, 269);
            this.btDelOtd.Name = "btDelOtd";
            this.btDelOtd.Size = new System.Drawing.Size(107, 30);
            this.btDelOtd.TabIndex = 12;
            this.btDelOtd.Text = "Видалити";
            this.btDelOtd.UseVisualStyleBackColor = true;
            this.btDelOtd.Click += new System.EventHandler(this.btDelOtd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(16, 271);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(105, 28);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Зберегти";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(251, 219);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(100, 34);
            this.btNext.TabIndex = 10;
            this.btNext.Text = "Наступний";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btAddOtd
            // 
            this.btAddOtd.Location = new System.Drawing.Point(152, 219);
            this.btAddOtd.Name = "btAddOtd";
            this.btAddOtd.Size = new System.Drawing.Size(75, 34);
            this.btAddOtd.TabIndex = 9;
            this.btAddOtd.Text = "Додати";
            this.btAddOtd.UseVisualStyleBackColor = true;
            this.btAddOtd.Click += new System.EventHandler(this.btAddOtd_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(16, 219);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(105, 34);
            this.btPrev.TabIndex = 8;
            this.btPrev.Text = "Попередній";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // txb4
            // 
            this.txb4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.відділеняBindingSource, "Емайл", true));
            this.txb4.Location = new System.Drawing.Point(127, 150);
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(176, 26);
            this.txb4.TabIndex = 7;
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
            // txb3
            // 
            this.txb3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.відділеняBindingSource, "Номер", true));
            this.txb3.Location = new System.Drawing.Point(127, 114);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(176, 26);
            this.txb3.TabIndex = 6;
            // 
            // txb2
            // 
            this.txb2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.відділеняBindingSource, "Адрес", true));
            this.txb2.Location = new System.Drawing.Point(127, 81);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(176, 26);
            this.txb2.TabIndex = 5;
            // 
            // txb1
            // 
            this.txb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.відділеняBindingSource, "№ відділення", true));
            this.txb1.Location = new System.Drawing.Point(127, 45);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(176, 26);
            this.txb1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Еиайл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // grb2
            // 
            this.grb2.BackColor = System.Drawing.Color.DarkOrange;
            this.grb2.Controls.Add(this.dg1);
            this.grb2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grb2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb2.Location = new System.Drawing.Point(440, 27);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(652, 299);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = " Відділеня";
            // 
            // dg1
            // 
            this.dg1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.відділенняDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.емайлDataGridViewTextBoxColumn});
            this.dg1.DataSource = this.відділеняBindingSource;
            this.dg1.Location = new System.Drawing.Point(17, 19);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(593, 242);
            this.dg1.TabIndex = 0;
            // 
            // відділенняDataGridViewTextBoxColumn
            // 
            this.відділенняDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.відділенняDataGridViewTextBoxColumn.DataPropertyName = "№ відділення";
            this.відділенняDataGridViewTextBoxColumn.HeaderText = "№ відділення";
            this.відділенняDataGridViewTextBoxColumn.Name = "відділенняDataGridViewTextBoxColumn";
            this.відділенняDataGridViewTextBoxColumn.Width = 131;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.Width = 76;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.Width = 81;
            // 
            // емайлDataGridViewTextBoxColumn
            // 
            this.емайлDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.емайлDataGridViewTextBoxColumn.DataPropertyName = "Емайл";
            this.емайлDataGridViewTextBoxColumn.HeaderText = "Емайл";
            this.емайлDataGridViewTextBoxColumn.Name = "емайлDataGridViewTextBoxColumn";
            this.емайлDataGridViewTextBoxColumn.Width = 81;
            // 
            // відділеняTableAdapter
            // 
            this.відділеняTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grb3
            // 
            this.grb3.BackColor = System.Drawing.Color.DarkOrange;
            this.grb3.Controls.Add(this.txb11);
            this.grb3.Controls.Add(this.label12);
            this.grb3.Controls.Add(this.txb12);
            this.grb3.Controls.Add(this.label11);
            this.grb3.Controls.Add(this.txb10);
            this.grb3.Controls.Add(this.label10);
            this.grb3.Controls.Add(this.txb9);
            this.grb3.Controls.Add(this.label9);
            this.grb3.Controls.Add(this.btnDelWork);
            this.grb3.Controls.Add(this.btnUpdateWork);
            this.grb3.Controls.Add(this.btnNextWork);
            this.grb3.Controls.Add(this.btnAddWork);
            this.grb3.Controls.Add(this.btnPrevWork);
            this.grb3.Controls.Add(this.txb8);
            this.grb3.Controls.Add(this.txb7);
            this.grb3.Controls.Add(this.txb6);
            this.grb3.Controls.Add(this.txb5);
            this.grb3.Controls.Add(this.label5);
            this.grb3.Controls.Add(this.label6);
            this.grb3.Controls.Add(this.label7);
            this.grb3.Controls.Add(this.label8);
            this.grb3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grb3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb3.Location = new System.Drawing.Point(0, 407);
            this.grb3.Name = "grb3";
            this.grb3.Size = new System.Drawing.Size(413, 442);
            this.grb3.TabIndex = 3;
            this.grb3.TabStop = false;
            this.grb3.Text = "Дані працівники";
            // 
            // txb11
            // 
            this.txb11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "Відділення", true));
            this.txb11.Location = new System.Drawing.Point(152, 287);
            this.txb11.Name = "txb11";
            this.txb11.Size = new System.Drawing.Size(176, 26);
            this.txb11.TabIndex = 20;
            // 
            // працівникиBindingSource
            // 
            this.працівникиBindingSource.DataMember = "Працівники";
            this.працівникиBindingSource.DataSource = this.bDDataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(43, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Відділення";
            // 
            // txb12
            // 
            this.txb12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "Посада", true));
            this.txb12.Location = new System.Drawing.Point(152, 326);
            this.txb12.Name = "txb12";
            this.txb12.Size = new System.Drawing.Size(176, 26);
            this.txb12.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(43, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Посада";
            // 
            // txb10
            // 
            this.txb10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "Адрес", true));
            this.txb10.Location = new System.Drawing.Point(152, 245);
            this.txb10.Name = "txb10";
            this.txb10.Size = new System.Drawing.Size(176, 26);
            this.txb10.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(43, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Адрес";
            // 
            // txb9
            // 
            this.txb9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "Стать", true));
            this.txb9.Location = new System.Drawing.Point(152, 200);
            this.txb9.Name = "txb9";
            this.txb9.Size = new System.Drawing.Size(176, 26);
            this.txb9.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(40, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Стать";
            // 
            // btnDelWork
            // 
            this.btnDelWork.Location = new System.Drawing.Point(152, 407);
            this.btnDelWork.Name = "btnDelWork";
            this.btnDelWork.Size = new System.Drawing.Size(107, 30);
            this.btnDelWork.TabIndex = 12;
            this.btnDelWork.Text = "Видалити";
            this.btnDelWork.UseVisualStyleBackColor = true;
            this.btnDelWork.Click += new System.EventHandler(this.btnDelWork_Click);
            // 
            // btnUpdateWork
            // 
            this.btnUpdateWork.Location = new System.Drawing.Point(16, 407);
            this.btnUpdateWork.Name = "btnUpdateWork";
            this.btnUpdateWork.Size = new System.Drawing.Size(105, 28);
            this.btnUpdateWork.TabIndex = 11;
            this.btnUpdateWork.Text = "Зберегти";
            this.btnUpdateWork.UseVisualStyleBackColor = true;
            this.btnUpdateWork.Click += new System.EventHandler(this.btnUpdateWork_Click);
            // 
            // btnNextWork
            // 
            this.btnNextWork.Location = new System.Drawing.Point(251, 355);
            this.btnNextWork.Name = "btnNextWork";
            this.btnNextWork.Size = new System.Drawing.Size(100, 34);
            this.btnNextWork.TabIndex = 10;
            this.btnNextWork.Text = "Наступний";
            this.btnNextWork.UseVisualStyleBackColor = true;
            this.btnNextWork.Click += new System.EventHandler(this.btnNextWork_Click);
            // 
            // btnAddWork
            // 
            this.btnAddWork.Location = new System.Drawing.Point(152, 355);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(75, 34);
            this.btnAddWork.TabIndex = 9;
            this.btnAddWork.Text = "Додати";
            this.btnAddWork.UseVisualStyleBackColor = true;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // btnPrevWork
            // 
            this.btnPrevWork.Location = new System.Drawing.Point(16, 355);
            this.btnPrevWork.Name = "btnPrevWork";
            this.btnPrevWork.Size = new System.Drawing.Size(105, 34);
            this.btnPrevWork.TabIndex = 8;
            this.btnPrevWork.Text = "Попередній";
            this.btnPrevWork.UseVisualStyleBackColor = true;
            this.btnPrevWork.Click += new System.EventHandler(this.btnPrevWork_Click);
            // 
            // txb8
            // 
            this.txb8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "Вік", true));
            this.txb8.Location = new System.Drawing.Point(152, 158);
            this.txb8.Name = "txb8";
            this.txb8.Size = new System.Drawing.Size(176, 26);
            this.txb8.TabIndex = 7;
            // 
            // txb7
            // 
            this.txb7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "Дата народження", true));
            this.txb7.Location = new System.Drawing.Point(152, 121);
            this.txb7.Name = "txb7";
            this.txb7.Size = new System.Drawing.Size(176, 26);
            this.txb7.TabIndex = 6;
            // 
            // txb6
            // 
            this.txb6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "Імя", true));
            this.txb6.Location = new System.Drawing.Point(127, 81);
            this.txb6.Name = "txb6";
            this.txb6.Size = new System.Drawing.Size(224, 26);
            this.txb6.TabIndex = 5;
            // 
            // txb5
            // 
            this.txb5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.працівникиBindingSource, "№ працівника", true));
            this.txb5.Location = new System.Drawing.Point(127, 45);
            this.txb5.Name = "txb5";
            this.txb5.Size = new System.Drawing.Size(176, 26);
            this.txb5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Вік";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата народження";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(40, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Імя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(43, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "№";
            // 
            // grb4
            // 
            this.grb4.BackColor = System.Drawing.Color.DarkOrange;
            this.grb4.Controls.Add(this.працівникиDataGridView);
            this.grb4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grb4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb4.Location = new System.Drawing.Point(429, 407);
            this.grb4.Name = "grb4";
            this.grb4.Size = new System.Drawing.Size(871, 313);
            this.grb4.TabIndex = 2;
            this.grb4.TabStop = false;
            this.grb4.Text = "Праівники";
            // 
            // працівникиDataGridView
            // 
            this.працівникиDataGridView.AutoGenerateColumns = false;
            this.працівникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.працівникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.працівникиDataGridView.DataSource = this.працівникиBindingSource;
            this.працівникиDataGridView.Location = new System.Drawing.Point(17, 45);
            this.працівникиDataGridView.Name = "працівникиDataGridView";
            this.працівникиDataGridView.Size = new System.Drawing.Size(804, 257);
            this.працівникиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "№ працівника";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ працівника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 124;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Імя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Імя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата народження";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата народження";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 147;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Вік";
            this.dataGridViewTextBoxColumn4.HeaderText = "Вік";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Стать";
            this.dataGridViewTextBoxColumn5.HeaderText = "Стать";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 76;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Відділення";
            this.dataGridViewTextBoxColumn7.HeaderText = "Відділення";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 113;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Посада";
            this.dataGridViewTextBoxColumn8.HeaderText = "Посада";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 85;
            // 
            // працівникиTableAdapter
            // 
            this.працівникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Bank.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідділеняTableAdapter = this.відділеняTableAdapter;
            this.tableAdapterManager.ВкладиTableAdapter = null;
            this.tableAdapterManager.КліентиTableAdapter = null;
            this.tableAdapterManager.ПрацівникиTableAdapter = this.працівникиTableAdapter;
            // 
            // bdDataSet1
            // 
            this.bdDataSet1.DataSetName = "BDDataSet";
            this.bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(429, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Пошук";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbSearchWorker
            // 
            this.txbSearchWorker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbSearchWorker.Location = new System.Drawing.Point(581, 762);
            this.txbSearchWorker.Multiline = true;
            this.txbSearchWorker.Name = "txbSearchWorker";
            this.txbSearchWorker.Size = new System.Drawing.Size(303, 29);
            this.txbSearchWorker.TabIndex = 22;
            this.txbSearchWorker.TextChanged += new System.EventHandler(this.txbSearchWorker_TextChanged);
            // 
            // txbSearchOtd
            // 
            this.txbSearchOtd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbSearchOtd.Location = new System.Drawing.Point(601, 354);
            this.txbSearchOtd.Multiline = true;
            this.txbSearchOtd.Name = "txbSearchOtd";
            this.txbSearchOtd.Size = new System.Drawing.Size(303, 30);
            this.txbSearchOtd.TabIndex = 24;
            // 
            // tbSearchOtd
            // 
            this.tbSearchOtd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchOtd.Location = new System.Drawing.Point(440, 341);
            this.tbSearchOtd.Name = "tbSearchOtd";
            this.tbSearchOtd.Size = new System.Drawing.Size(115, 43);
            this.tbSearchOtd.TabIndex = 23;
            this.tbSearchOtd.Text = "Пошук";
            this.tbSearchOtd.UseVisualStyleBackColor = true;
            this.tbSearchOtd.Click += new System.EventHandler(this.tbSearchOtd_Click);
            // 
            // fBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 886);
            this.Controls.Add(this.txbSearchOtd);
            this.Controls.Add(this.tbSearchOtd);
            this.Controls.Add(this.txbSearchWorker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grb4);
            this.Controls.Add(this.grb3);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fBank";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.grb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.grb3.ResumeLayout(false);
            this.grb3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).EndInit();
            this.grb4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.працівникиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.DataGridView dg1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource відділеняBindingSource;
        private BDDataSetTableAdapters.ВідділеняTableAdapter відділеняTableAdapter;
        private System.Windows.Forms.Button btDelOtd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btAddOtd;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.TextBox txb4;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn відділенняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn емайлDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox grb3;
        private System.Windows.Forms.Button btnDelWork;
        private System.Windows.Forms.Button btnUpdateWork;
        private System.Windows.Forms.Button btnNextWork;
        private System.Windows.Forms.Button btnAddWork;
        private System.Windows.Forms.Button btnPrevWork;
        private System.Windows.Forms.TextBox txb8;
        private System.Windows.Forms.TextBox txb7;
        private System.Windows.Forms.TextBox txb6;
        private System.Windows.Forms.TextBox txb5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grb4;
        private System.Windows.Forms.BindingSource працівникиBindingSource;
        private BDDataSetTableAdapters.ПрацівникиTableAdapter працівникиTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txb11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView працівникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BDDataSet bdDataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbSearchWorker;
        private System.Windows.Forms.TextBox txbSearchOtd;
        private System.Windows.Forms.Button tbSearchOtd;
    }
}

