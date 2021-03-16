namespace Bank
{
    partial class fGeneral
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
            this.btnOpenBank = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenBank
            // 
            this.btnOpenBank.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenBank.Location = new System.Drawing.Point(44, 301);
            this.btnOpenBank.Name = "btnOpenBank";
            this.btnOpenBank.Size = new System.Drawing.Size(201, 64);
            this.btnOpenBank.TabIndex = 0;
            this.btnOpenBank.Text = "Банк";
            this.btnOpenBank.UseVisualStyleBackColor = true;
            this.btnOpenBank.Click += new System.EventHandler(this.btnOpenBank_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(426, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 64);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(681, 434);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenBank);
            this.Name = "fGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenBank;
        private System.Windows.Forms.Button btnExit;
    }
}