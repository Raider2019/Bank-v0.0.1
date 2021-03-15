
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb1 = new System.Windows.Forms.GroupBox();
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
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.відділенняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.емайлDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відділеняTableAdapter = new Bank.BDDataSetTableAdapters.ВідділеняTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gb1.Controls.Add(this.btDelOtd);
            this.gb1.Controls.Add(this.btUpdate);
            this.gb1.Controls.Add(this.btNext);
            this.gb1.Controls.Add(this.btAddOtd);
            this.gb1.Controls.Add(this.btPrev);
            this.gb1.Controls.Add(this.txb4);
            this.gb1.Controls.Add(this.txb3);
            this.gb1.Controls.Add(this.txb2);
            this.gb1.Controls.Add(this.txb1);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb1.Location = new System.Drawing.Point(37, 45);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(413, 374);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Дані відділення";
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
            this.btUpdate.Text = "Змінити";
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
            this.txb4.Location = new System.Drawing.Point(127, 151);
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
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Еиайл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // gb2
            // 
            this.gb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gb2.Controls.Add(this.dg1);
            this.gb2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb2.Location = new System.Drawing.Point(477, 45);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(562, 374);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = " Відділеня";
            // 
            // dg1
            // 
            this.dg1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.відділенняDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.емайлDataGridViewTextBoxColumn});
            this.dg1.DataSource = this.відділеняBindingSource;
            this.dg1.Location = new System.Drawing.Point(17, 19);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(539, 234);
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
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 603);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fBank";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
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
    }
}

