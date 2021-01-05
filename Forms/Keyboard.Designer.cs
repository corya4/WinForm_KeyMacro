namespace MACP.Forms
{
    partial class Keyboard
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
            this.keyData = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keyData)).BeginInit();
            this.SuspendLayout();
            // 
            // keyData
            // 
            this.keyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyData.Dock = System.Windows.Forms.DockStyle.Top;
            this.keyData.Location = new System.Drawing.Point(0, 0);
            this.keyData.Name = "keyData";
            this.keyData.RowTemplate.Height = 23;
            this.keyData.Size = new System.Drawing.Size(186, 254);
            this.keyData.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(11, 263);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(74, 21);
            this.OK.TabIndex = 1;
            this.OK.Text = "선택";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(100, 263);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(74, 21);
            this.CANCEL.TabIndex = 2;
            this.CANCEL.Text = "취소";
            this.CANCEL.UseVisualStyleBackColor = true;
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 293);
            this.ControlBox = false;
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.keyData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(186, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(186, 293);
            this.Name = "Keyboard";
            this.ShowIcon = false;
            this.Text = "Keyboard";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.keyData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView keyData;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button CANCEL;
    }
}