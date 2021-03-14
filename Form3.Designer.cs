
namespace Bank
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bDDataSet = new Bank.BDDataSet();
            this.кліентиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кліентиTableAdapter = new Bank.BDDataSetTableAdapters.КліентиTableAdapter();
            this.іДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.менеджерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сумаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відсотокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вкладиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вкладиTableAdapter = new Bank.BDDataSetTableAdapters.ВкладиTableAdapter();
            this.вкладаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.термінВкладумісDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відсотокDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кліентиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1217, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.іДDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.адрсDataGridViewTextBoxColumn,
            this.статьDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn,
            this.менеджерDataGridViewTextBoxColumn,
            this.вкладаDataGridViewTextBoxColumn,
            this.сумаВкладаDataGridViewTextBoxColumn,
            this.відсотокDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.кліентиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1039, 137);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.вкладаDataGridViewTextBoxColumn1,
            this.термінВкладумісDataGridViewTextBoxColumn,
            this.відсотокDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.вкладиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(54, 281);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 134);
            this.dataGridView2.TabIndex = 2;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кліентиBindingSource
            // 
            this.кліентиBindingSource.DataMember = "Кліенти";
            this.кліентиBindingSource.DataSource = this.bDDataSet;
            // 
            // кліентиTableAdapter
            // 
            this.кліентиTableAdapter.ClearBeforeFill = true;
            // 
            // іДDataGridViewTextBoxColumn
            // 
            this.іДDataGridViewTextBoxColumn.DataPropertyName = "ІД";
            this.іДDataGridViewTextBoxColumn.HeaderText = "ІД";
            this.іДDataGridViewTextBoxColumn.Name = "іДDataGridViewTextBoxColumn";
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            // 
            // адрсDataGridViewTextBoxColumn
            // 
            this.адрсDataGridViewTextBoxColumn.DataPropertyName = "Адрс";
            this.адрсDataGridViewTextBoxColumn.HeaderText = "Адрс";
            this.адрсDataGridViewTextBoxColumn.Name = "адрсDataGridViewTextBoxColumn";
            // 
            // статьDataGridViewTextBoxColumn
            // 
            this.статьDataGridViewTextBoxColumn.DataPropertyName = "Стать";
            this.статьDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.статьDataGridViewTextBoxColumn.Name = "статьDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // датаНародженняDataGridViewTextBoxColumn
            // 
            this.датаНародженняDataGridViewTextBoxColumn.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.Name = "датаНародженняDataGridViewTextBoxColumn";
            // 
            // менеджерDataGridViewTextBoxColumn
            // 
            this.менеджерDataGridViewTextBoxColumn.DataPropertyName = "Менеджер";
            this.менеджерDataGridViewTextBoxColumn.HeaderText = "Менеджер";
            this.менеджерDataGridViewTextBoxColumn.Name = "менеджерDataGridViewTextBoxColumn";
            // 
            // вкладаDataGridViewTextBoxColumn
            // 
            this.вкладаDataGridViewTextBoxColumn.DataPropertyName = "№ вклада";
            this.вкладаDataGridViewTextBoxColumn.HeaderText = "№ вклада";
            this.вкладаDataGridViewTextBoxColumn.Name = "вкладаDataGridViewTextBoxColumn";
            // 
            // сумаВкладаDataGridViewTextBoxColumn
            // 
            this.сумаВкладаDataGridViewTextBoxColumn.DataPropertyName = "Сума вклада";
            this.сумаВкладаDataGridViewTextBoxColumn.HeaderText = "Сума вклада";
            this.сумаВкладаDataGridViewTextBoxColumn.Name = "сумаВкладаDataGridViewTextBoxColumn";
            // 
            // відсотокDataGridViewTextBoxColumn
            // 
            this.відсотокDataGridViewTextBoxColumn.DataPropertyName = "Відсоток";
            this.відсотокDataGridViewTextBoxColumn.HeaderText = "Відсоток";
            this.відсотокDataGridViewTextBoxColumn.Name = "відсотокDataGridViewTextBoxColumn";
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
            // вкладаDataGridViewTextBoxColumn1
            // 
            this.вкладаDataGridViewTextBoxColumn1.DataPropertyName = "№ вклада";
            this.вкладаDataGridViewTextBoxColumn1.HeaderText = "№ вклада";
            this.вкладаDataGridViewTextBoxColumn1.Name = "вкладаDataGridViewTextBoxColumn1";
            // 
            // термінВкладумісDataGridViewTextBoxColumn
            // 
            this.термінВкладумісDataGridViewTextBoxColumn.DataPropertyName = "Термін вкладу,міс";
            this.термінВкладумісDataGridViewTextBoxColumn.HeaderText = "Термін вкладу,міс";
            this.термінВкладумісDataGridViewTextBoxColumn.Name = "термінВкладумісDataGridViewTextBoxColumn";
            // 
            // відсотокDataGridViewTextBoxColumn1
            // 
            this.відсотокDataGridViewTextBoxColumn1.DataPropertyName = "Відсоток";
            this.відсотокDataGridViewTextBoxColumn1.HeaderText = "Відсоток";
            this.відсотокDataGridViewTextBoxColumn1.Name = "відсотокDataGridViewTextBoxColumn1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 517);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кліентиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вкладиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource кліентиBindingSource;
        private BDDataSetTableAdapters.КліентиTableAdapter кліентиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn іДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn менеджерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сумаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn відсотокDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource вкладиBindingSource;
        private BDDataSetTableAdapters.ВкладиTableAdapter вкладиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn вкладаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn термінВкладумісDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn відсотокDataGridViewTextBoxColumn1;
    }
}