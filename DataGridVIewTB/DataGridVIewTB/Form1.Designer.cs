namespace DataGridVIewTB
{
    partial class Form1
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
            this.dataGridVIewTB1 = new DataGridVIewTB();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVIewTB1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVIewTB1
            // 
            this.dataGridVIewTB1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVIewTB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVIewTB1.Location = new System.Drawing.Point(0, 0);
            this.dataGridVIewTB1.Name = "dataGridVIewTB1";
            this.dataGridVIewTB1.RowTemplate.Height = 23;
            this.dataGridVIewTB1.Size = new System.Drawing.Size(230, 217);
            this.dataGridVIewTB1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 217);
            this.Controls.Add(this.dataGridVIewTB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVIewTB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridVIewTB dataGridVIewTB1;
    }
}