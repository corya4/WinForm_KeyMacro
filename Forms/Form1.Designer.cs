namespace MACP
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MacroViewer = new System.Windows.Forms.DataGridView();
            this.Macr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.추가변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.변경MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MacroViewer)).BeginInit();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MacroViewer
            // 
            this.MacroViewer.AllowUserToAddRows = false;
            this.MacroViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MacroViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MacroViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MacroViewer.ColumnHeadersVisible = false;
            this.MacroViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macr});
            this.MacroViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MacroViewer.Location = new System.Drawing.Point(0, 24);
            this.MacroViewer.Name = "MacroViewer";
            this.MacroViewer.ReadOnly = true;
            this.MacroViewer.RowHeadersVisible = false;
            this.MacroViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MacroViewer.RowTemplate.Height = 23;
            this.MacroViewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MacroViewer.Size = new System.Drawing.Size(202, 255);
            this.MacroViewer.TabIndex = 0;
            this.MacroViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MacroViewer_CellClick);
            // 
            // Macr
            // 
            this.Macr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Macr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Macr.HeaderText = "";
            this.Macr.Name = "Macr";
            this.Macr.ReadOnly = true;
            this.Macr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가변경ToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(202, 24);
            this.menubar.TabIndex = 1;
            this.menubar.Text = "menubar";
            // 
            // 추가변경ToolStripMenuItem
            // 
            this.추가변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가AToolStripMenuItem,
            this.변경MToolStripMenuItem,
            this.삭제DToolStripMenuItem});
            this.추가변경ToolStripMenuItem.Name = "추가변경ToolStripMenuItem";
            this.추가변경ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.추가변경ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 추가AToolStripMenuItem
            // 
            this.추가AToolStripMenuItem.Name = "추가AToolStripMenuItem";
            this.추가AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.추가AToolStripMenuItem.Text = "추가(&A)";
            // 
            // 변경MToolStripMenuItem
            // 
            this.변경MToolStripMenuItem.Name = "변경MToolStripMenuItem";
            this.변경MToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.변경MToolStripMenuItem.Text = "변경(&M)";
            // 
            // 삭제DToolStripMenuItem
            // 
            this.삭제DToolStripMenuItem.Name = "삭제DToolStripMenuItem";
            this.삭제DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.삭제DToolStripMenuItem.Text = "삭제(&D)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 279);
            this.Controls.Add(this.MacroViewer);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(218, 318);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(218, 318);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "KM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MacroViewer)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MacroViewer;
        private System.Windows.Forms.DataGridViewButtonColumn Macr;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem 추가변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변경MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
    }
}

