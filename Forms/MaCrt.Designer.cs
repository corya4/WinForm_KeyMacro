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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BOK = new System.Windows.Forms.Button();
            this.BCANCEL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputKey = new System.Windows.Forms.DataGridView();
            this.view_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_shift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.view_Ctrl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputKey)).BeginInit();
            this.SuspendLayout();
            // 
            // BOK
            // 
            this.BOK.Location = new System.Drawing.Point(12, 228);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(95, 24);
            this.BOK.TabIndex = 0;
            this.BOK.Text = "확인";
            this.BOK.UseVisualStyleBackColor = true;
            // 
            // BCANCEL
            // 
            this.BCANCEL.Location = new System.Drawing.Point(133, 228);
            this.BCANCEL.Name = "BCANCEL";
            this.BCANCEL.Size = new System.Drawing.Size(94, 24);
            this.BCANCEL.TabIndex = 1;
            this.BCANCEL.Text = "취소";
            this.BCANCEL.UseVisualStyleBackColor = true;
            this.BCANCEL.Click += new System.EventHandler(this.OnCancel);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "타이틀        :";
            // 
            // InputKey
            // 
            this.InputKey.AllowUserToAddRows = false;
            this.InputKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view_index,
            this.view_key,
            this.view_shift,
            this.view_Ctrl});
            this.InputKey.Location = new System.Drawing.Point(12, 122);
            this.InputKey.MultiSelect = false;
            this.InputKey.Name = "InputKey";
            this.InputKey.ReadOnly = true;
            this.InputKey.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InputKey.RowHeadersVisible = false;
            this.InputKey.RowTemplate.Height = 23;
            this.InputKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InputKey.Size = new System.Drawing.Size(215, 100);
            this.InputKey.TabIndex = 4;
            // 
            // view_index
            // 
            this.view_index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.view_index.DefaultCellStyle = dataGridViewCellStyle1;
            this.view_index.FillWeight = 72.27548F;
            this.view_index.HeaderText = "순서";
            this.view_index.Name = "view_index";
            this.view_index.ReadOnly = true;
            this.view_index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // view_key
            // 
            this.view_key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.view_key.DefaultCellStyle = dataGridViewCellStyle2;
            this.view_key.FillWeight = 178.9639F;
            this.view_key.HeaderText = "입력키";
            this.view_key.Name = "view_key";
            this.view_key.ReadOnly = true;
            this.view_key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // view_shift
            // 
            this.view_shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_shift.FillWeight = 77.69465F;
            this.view_shift.HeaderText = "Shift";
            this.view_shift.Name = "view_shift";
            this.view_shift.ReadOnly = true;
            // 
            // view_Ctrl
            // 
            this.view_Ctrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_Ctrl.FillWeight = 71.06599F;
            this.view_Ctrl.HeaderText = "Ctrl";
            this.view_Ctrl.Name = "view_Ctrl";
            this.view_Ctrl.ReadOnly = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(183, 62);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 19);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "등록";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 21);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "레지스트 키 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "메크로 키    :";
            // 
            // MaCrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 264);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.InputKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BCANCEL);
            this.Controls.Add(this.BOK);
            this.Name = "MaCrt";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.InputKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Button BCANCEL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InputKey;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_key;
        private System.Windows.Forms.DataGridViewCheckBoxColumn view_shift;
        private System.Windows.Forms.DataGridViewCheckBoxColumn view_Ctrl;
    }
}