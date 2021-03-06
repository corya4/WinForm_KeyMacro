﻿namespace MACP.Forms
{
    partial class KeyOption
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BOK = new System.Windows.Forms.Button();
            this.BCANCEL = new System.Windows.Forms.Button();
            this.ID_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputKey = new System.Windows.Forms.DataGridView();
            this.view_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_shift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.view_Ctrl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_registBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_option = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.InputKey)).BeginInit();
            this.pnl_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // BOK
            // 
            this.BOK.Location = new System.Drawing.Point(15, 242);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(95, 23);
            this.BOK.TabIndex = 0;
            this.BOK.Text = "확인";
            this.BOK.UseVisualStyleBackColor = true;
            this.BOK.Click += new System.EventHandler(this.OnOK);
            // 
            // BCANCEL
            // 
            this.BCANCEL.Location = new System.Drawing.Point(133, 242);
            this.BCANCEL.Name = "BCANCEL";
            this.BCANCEL.Size = new System.Drawing.Size(94, 23);
            this.BCANCEL.TabIndex = 1;
            this.BCANCEL.Text = "취소";
            this.BCANCEL.UseVisualStyleBackColor = true;
            this.BCANCEL.Click += new System.EventHandler(this.OnCancel);
            // 
            // ID_title
            // 
            this.ID_title.Location = new System.Drawing.Point(105, 3);
            this.ID_title.Name = "ID_title";
            this.ID_title.Size = new System.Drawing.Size(122, 21);
            this.ID_title.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
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
            this.view_Ctrl,
            this.Alt});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InputKey.DefaultCellStyle = dataGridViewCellStyle6;
            this.InputKey.Location = new System.Drawing.Point(3, 109);
            this.InputKey.MultiSelect = false;
            this.InputKey.Name = "InputKey";
            this.InputKey.ReadOnly = true;
            this.InputKey.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InputKey.RowHeadersVisible = false;
            this.InputKey.RowTemplate.Height = 23;
            this.InputKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InputKey.Size = new System.Drawing.Size(231, 126);
            this.InputKey.TabIndex = 4;
            // 
            // view_index
            // 
            this.view_index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.view_index.DefaultCellStyle = dataGridViewCellStyle4;
            this.view_index.FillWeight = 64.4011F;
            this.view_index.HeaderText = "No.";
            this.view_index.Name = "view_index";
            this.view_index.ReadOnly = true;
            this.view_index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // view_key
            // 
            this.view_key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.view_key.DefaultCellStyle = dataGridViewCellStyle5;
            this.view_key.FillWeight = 203.0457F;
            this.view_key.HeaderText = "입력키";
            this.view_key.Name = "view_key";
            this.view_key.ReadOnly = true;
            this.view_key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // view_shift
            // 
            this.view_shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_shift.FillWeight = 69.22985F;
            this.view_shift.HeaderText = "Shift";
            this.view_shift.Name = "view_shift";
            this.view_shift.ReadOnly = true;
            // 
            // view_Ctrl
            // 
            this.view_Ctrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_Ctrl.FillWeight = 63.32338F;
            this.view_Ctrl.HeaderText = "Ctrl";
            this.view_Ctrl.Name = "view_Ctrl";
            this.view_Ctrl.ReadOnly = true;
            // 
            // Alt
            // 
            this.Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alt.FillWeight = 69.22985F;
            this.Alt.HeaderText = "Alt";
            this.Alt.Name = "Alt";
            this.Alt.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClick2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "메크로 키    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "레지스트 키 :";
            // 
            // ID_registBox
            // 
            this.ID_registBox.Location = new System.Drawing.Point(105, 42);
            this.ID_registBox.Name = "ID_registBox";
            this.ID_registBox.ReadOnly = true;
            this.ID_registBox.Size = new System.Drawing.Size(68, 21);
            this.ID_registBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 19);
            this.button2.TabIndex = 12;
            this.button2.Text = "등록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClick);
            // 
            // pnl_option
            // 
            this.pnl_option.Controls.Add(this.button2);
            this.pnl_option.Controls.Add(this.label1);
            this.pnl_option.Controls.Add(this.label2);
            this.pnl_option.Controls.Add(this.InputKey);
            this.pnl_option.Controls.Add(this.ID_registBox);
            this.pnl_option.Controls.Add(this.BOK);
            this.pnl_option.Controls.Add(this.label3);
            this.pnl_option.Controls.Add(this.BCANCEL);
            this.pnl_option.Controls.Add(this.button1);
            this.pnl_option.Controls.Add(this.ID_title);
            this.pnl_option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_option.Location = new System.Drawing.Point(0, 0);
            this.pnl_option.Name = "pnl_option";
            this.pnl_option.Size = new System.Drawing.Size(239, 279);
            this.pnl_option.TabIndex = 13;
            // 
            // KeyOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 279);
            this.Controls.Add(this.pnl_option);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(255, 318);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 318);
            this.Name = "KeyOption";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.InputKey)).EndInit();
            this.pnl_option.ResumeLayout(false);
            this.pnl_option.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Button BCANCEL;
        private System.Windows.Forms.TextBox ID_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InputKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_registBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_key;
        private System.Windows.Forms.DataGridViewCheckBoxColumn view_shift;
        private System.Windows.Forms.DataGridViewCheckBoxColumn view_Ctrl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Alt;
        public System.Windows.Forms.Panel pnl_option;
    }
}