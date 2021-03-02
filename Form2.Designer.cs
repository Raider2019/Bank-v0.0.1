
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
            this.bDDataSet = new Bank.BDDataSet();
            this.відділеняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.відділеняTableAdapter = new Bank.BDDataSetTableAdapters.ВідділеняTableAdapter();
            this.відділенняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.емайлDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.працівникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.працівникиTableAdapter = new Bank.BDDataSetTableAdapters.ПрацівникиTableAdapter();
            this.працівникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вікDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.відділенняDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.відділенняDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.емайлDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.відділеняBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 152);
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
            this.dataGridView2.Location = new System.Drawing.Point(12, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(845, 170);
            this.dataGridView2.TabIndex = 1;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // відділенняDataGridViewTextBoxColumn
            // 
            this.відділенняDataGridViewTextBoxColumn.DataPropertyName = "№ відділення";
            this.відділенняDataGridViewTextBoxColumn.HeaderText = "№ відділення";
            this.відділенняDataGridViewTextBoxColumn.Name = "відділенняDataGridViewTextBoxColumn";
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
            // працівникиBindingSource
            // 
            this.працівникиBindingSource.DataMember = "Працівники";
            this.працівникиBindingSource.DataSource = this.bDDataSet;
            // 
            // працівникиTableAdapter
            // 
            this.працівникиTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.відділеняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.працівникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource відділеняBindingSource;
        private BDDataSetTableAdapters.ВідділеняTableAdapter відділеняTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn відділенняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn емайлDataGridViewTextBoxColumn;
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
    }
}