namespace MACP
{
    partial class MacpMain
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
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.추가변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MacroViewer = new DataGridVIewTB.DataGridVIewTB();
            this.macro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MacroViewer)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가변경ToolStripMenuItem,
            this.설정SToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(239, 24);
            this.menubar.TabIndex = 1;
            this.menubar.Text = "menubar";
            // 
            // 추가변경ToolStripMenuItem
            // 
            this.추가변경ToolStripMenuItem.Name = "추가변경ToolStripMenuItem";
            this.추가변경ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.추가변경ToolStripMenuItem.Text = "추가(&A)";
            this.추가변경ToolStripMenuItem.Click += new System.EventHandler(this.OnAddClicked);
            // 
            // 설정SToolStripMenuItem
            // 
            this.설정SToolStripMenuItem.Name = "설정SToolStripMenuItem";
            this.설정SToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.설정SToolStripMenuItem.Text = "설정(&S)";
            this.설정SToolStripMenuItem.Click += new System.EventHandler(this.OnSettingClicked);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.도움말ToolStripMenuItem.Text = "도움말(&M)";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.OnHelpClicked);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MacroViewer
            // 
            this.MacroViewer.AllowUserToAddRows = false;
            this.MacroViewer.AllowUserToResizeColumns = false;
            this.MacroViewer.AllowUserToResizeRows = false;
            this.MacroViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MacroViewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.MacroViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MacroViewer.ColumnHeadersVisible = false;
            this.MacroViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macro});
            this.MacroViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MacroViewer.Location = new System.Drawing.Point(0, 24);
            this.MacroViewer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MacroViewer.Name = "MacroViewer";
            this.MacroViewer.RowHeadersVisible = false;
            this.MacroViewer.RowTemplate.Height = 23;
            this.MacroViewer.Size = new System.Drawing.Size(239, 255);
            this.MacroViewer.TabIndex = 2;
            this.MacroViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnEntry);
            // 
            // macro
            // 
            this.macro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.macro.HeaderText = "macro";
            this.macro.Name = "macro";
            this.macro.ReadOnly = true;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.MacroViewer);
            this.pnl_main.Controls.Add(this.menubar);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(239, 279);
            this.pnl_main.TabIndex = 3;
            // 
            // MacpMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 279);
            this.Controls.Add(this.pnl_main);
            this.MainMenuStrip = this.menubar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(255, 318);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 318);
            this.Name = "MacpMain";
            this.ShowIcon = false;
            this.Text = "KM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MacroViewer)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem 추가변경ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridVIewTB.DataGridVIewTB MacroViewer;
        private System.Windows.Forms.DataGridViewButtonColumn macro;
        private System.Windows.Forms.ToolStripMenuItem 설정SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_main;
    }
}

