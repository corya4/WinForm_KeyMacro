﻿namespace MACP.Forms
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
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ctrl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.pnl_board = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.keyData)).BeginInit();
            this.pnl_board.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyData
            // 
            this.keyData.AllowUserToAddRows = false;
            this.keyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keyData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.Shift,
            this.Ctrl,
            this.Alt,
            this.KeyCode});
            this.keyData.Dock = System.Windows.Forms.DockStyle.Top;
            this.keyData.Location = new System.Drawing.Point(0, 0);
            this.keyData.Name = "keyData";
            this.keyData.RowHeadersVisible = false;
            this.keyData.RowTemplate.Height = 23;
            this.keyData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.keyData.Size = new System.Drawing.Size(245, 244);
            this.keyData.TabIndex = 0;
            // 
            // key
            // 
            this.key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.key.FillWeight = 176.6498F;
            this.key.HeaderText = "Key";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Shift
            // 
            this.Shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift.FillWeight = 61.67514F;
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            // 
            // Ctrl
            // 
            this.Ctrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ctrl.FillWeight = 61.67514F;
            this.Ctrl.HeaderText = "Ctrl";
            this.Ctrl.Name = "Ctrl";
            // 
            // Alt
            // 
            this.Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alt.FillWeight = 61.67514F;
            this.Alt.HeaderText = "Alt";
            this.Alt.Name = "Alt";
            // 
            // KeyCode
            // 
            this.KeyCode.HeaderText = "KeyCode";
            this.KeyCode.Name = "KeyCode";
            this.KeyCode.ReadOnly = true;
            this.KeyCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KeyCode.Visible = false;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(27, 254);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(74, 22);
            this.OK.TabIndex = 1;
            this.OK.Text = "선택";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OnClick);
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(143, 254);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(74, 22);
            this.CANCEL.TabIndex = 2;
            this.CANCEL.Text = "취소";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.OnCancel);
            // 
            // pnl_board
            // 
            this.pnl_board.Controls.Add(this.keyData);
            this.pnl_board.Controls.Add(this.CANCEL);
            this.pnl_board.Controls.Add(this.OK);
            this.pnl_board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_board.Location = new System.Drawing.Point(0, 0);
            this.pnl_board.Name = "pnl_board";
            this.pnl_board.Size = new System.Drawing.Size(245, 289);
            this.pnl_board.TabIndex = 3;
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 289);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(255, 318);
            this.Name = "Keyboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Keyboard";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.keyData)).EndInit();
            this.pnl_board.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView keyData;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Shift;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ctrl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Alt;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyCode;
        private System.Windows.Forms.Panel pnl_board;
    }
}