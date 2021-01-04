namespace MACP.Forms
{
    partial class MaCrt
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
            this.BOK = new System.Windows.Forms.Button();
            this.BCANCEL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BOK
            // 
            this.BOK.Location = new System.Drawing.Point(21, 228);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(85, 24);
            this.BOK.TabIndex = 0;
            this.BOK.Text = "확인";
            this.BOK.UseVisualStyleBackColor = true;
            // 
            // BCANCEL
            // 
            this.BCANCEL.Location = new System.Drawing.Point(128, 228);
            this.BCANCEL.Name = "BCANCEL";
            this.BCANCEL.Size = new System.Drawing.Size(85, 24);
            this.BCANCEL.TabIndex = 1;
            this.BCANCEL.Text = "취소";
            this.BCANCEL.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "타이틀 : ";
            // 
            // MaCrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 264);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BCANCEL);
            this.Controls.Add(this.BOK);
            this.Name = "MaCrt";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Button BCANCEL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}