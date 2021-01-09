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
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ctrl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.keyData)).BeginInit();
            this.SuspendLayout();
            // 
            // keyData
            // 
            this.keyData.AllowUserToAddRows = false;
            this.keyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.Shift,
            this.Ctrl});
            this.keyData.Dock = System.Windows.Forms.DockStyle.Top;
            this.keyData.Location = new System.Drawing.Point(0, 0);
            this.keyData.Name = "keyData";
            this.keyData.RowHeadersVisible = false;
            this.keyData.RowTemplate.Height = 23;
            this.keyData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.CANCEL.Click += new System.EventHandler(this.OnCancel);
            // 
            // key
            // 
            this.key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.key.FillWeight = 123.3503F;
            this.key.HeaderText = "Key";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Shift
            // 
            this.Shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift.FillWeight = 88.32487F;
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            // 
            // Ctrl
            // 
            this.Ctrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ctrl.FillWeight = 88.32487F;
            this.Ctrl.HeaderText = "Ctrl";
            this.Ctrl.Name = "Ctrl";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Shift;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ctrl;
    }
}