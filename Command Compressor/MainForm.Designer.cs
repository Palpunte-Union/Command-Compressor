
namespace Command_Compressor
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemExport = new System.Windows.Forms.MenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PageOnRun = new System.Windows.Forms.TabPage();
            this.dataGridViewOnRun = new System.Windows.Forms.DataGridView();
            this.ImageRun = new System.Windows.Forms.DataGridViewImageColumn();
            this.CommandInputRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageOnEnd = new System.Windows.Forms.TabPage();
            this.dataGridViewOnEnd = new System.Windows.Forms.DataGridView();
            this.ImageEnd = new System.Windows.Forms.DataGridViewImageColumn();
            this.CommandInputEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageDefault = new System.Windows.Forms.TabPage();
            this.tabControlSub = new System.Windows.Forms.TabControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ButtonAddPage = new System.Windows.Forms.ToolStripButton();
            this.ButtonDeletePage = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl.SuspendLayout();
            this.PageOnRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnRun)).BeginInit();
            this.PageOnEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnEnd)).BeginInit();
            this.PageDefault.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemExport});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemExit});
            this.menuItemFile.Text = "ファイル (&F)";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 0;
            this.menuItemExit.Text = "終了 (&X)";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemExport
            // 
            this.menuItemExport.Index = 1;
            this.menuItemExport.Text = "出力 (&E)";
            this.menuItemExport.Click += new System.EventHandler(this.menuItemExport_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PageOnRun);
            this.tabControl.Controls.Add(this.PageOnEnd);
            this.tabControl.Controls.Add(this.PageDefault);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 366);
            this.tabControl.TabIndex = 0;
            // 
            // PageOnRun
            // 
            this.PageOnRun.Controls.Add(this.dataGridViewOnRun);
            this.PageOnRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageOnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PageOnRun.Location = new System.Drawing.Point(4, 22);
            this.PageOnRun.Name = "PageOnRun";
            this.PageOnRun.Padding = new System.Windows.Forms.Padding(3);
            this.PageOnRun.Size = new System.Drawing.Size(792, 340);
            this.PageOnRun.TabIndex = 0;
            this.PageOnRun.Text = "起動時に実行";
            this.PageOnRun.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOnRun
            // 
            this.dataGridViewOnRun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOnRun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOnRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnRun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageRun,
            this.CommandInputRun});
            this.dataGridViewOnRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOnRun.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOnRun.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewOnRun.Name = "dataGridViewOnRun";
            this.dataGridViewOnRun.RowTemplate.Height = 21;
            this.dataGridViewOnRun.Size = new System.Drawing.Size(786, 334);
            this.dataGridViewOnRun.TabIndex = 0;
            this.dataGridViewOnRun.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnRun_RowEnter);
            this.dataGridViewOnRun.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewOnRun_RowsAdded);
            // 
            // ImageRun
            // 
            this.ImageRun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "null";
            this.ImageRun.DefaultCellStyle = dataGridViewCellStyle1;
            this.ImageRun.Frozen = true;
            this.ImageRun.HeaderText = "";
            this.ImageRun.Image = ((System.Drawing.Image)(resources.GetObject("ImageRun.Image")));
            this.ImageRun.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ImageRun.Name = "ImageRun";
            this.ImageRun.ReadOnly = true;
            this.ImageRun.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ImageRun.ToolTipText = "a";
            this.ImageRun.Width = 21;
            // 
            // CommandInputRun
            // 
            this.CommandInputRun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CommandInputRun.FillWeight = 60000F;
            this.CommandInputRun.HeaderText = "コマンド";
            this.CommandInputRun.Name = "CommandInputRun";
            this.CommandInputRun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PageOnEnd
            // 
            this.PageOnEnd.Controls.Add(this.dataGridViewOnEnd);
            this.PageOnEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageOnEnd.Location = new System.Drawing.Point(4, 22);
            this.PageOnEnd.Name = "PageOnEnd";
            this.PageOnEnd.Padding = new System.Windows.Forms.Padding(3);
            this.PageOnEnd.Size = new System.Drawing.Size(792, 340);
            this.PageOnEnd.TabIndex = 1;
            this.PageOnEnd.Text = "終了時に実行";
            this.PageOnEnd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOnEnd
            // 
            this.dataGridViewOnEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnEnd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageEnd,
            this.CommandInputEnd});
            this.dataGridViewOnEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOnEnd.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOnEnd.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewOnEnd.Name = "dataGridViewOnEnd";
            this.dataGridViewOnEnd.RowTemplate.Height = 21;
            this.dataGridViewOnEnd.Size = new System.Drawing.Size(786, 334);
            this.dataGridViewOnEnd.TabIndex = 0;
            this.dataGridViewOnEnd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnEnd_RowEnter);
            this.dataGridViewOnEnd.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewOnEnd_RowsAdded);
            // 
            // ImageEnd
            // 
            this.ImageEnd.HeaderText = "";
            this.ImageEnd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ImageEnd.Name = "ImageEnd";
            this.ImageEnd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ImageEnd.Width = 20;
            // 
            // CommandInputEnd
            // 
            this.CommandInputEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CommandInputEnd.FillWeight = 60000F;
            this.CommandInputEnd.HeaderText = "コマンド";
            this.CommandInputEnd.Name = "CommandInputEnd";
            this.CommandInputEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PageDefault
            // 
            this.PageDefault.Controls.Add(this.tabControlSub);
            this.PageDefault.Controls.Add(this.toolStrip);
            this.PageDefault.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDefault.Location = new System.Drawing.Point(4, 22);
            this.PageDefault.Name = "PageDefault";
            this.PageDefault.Size = new System.Drawing.Size(792, 340);
            this.PageDefault.TabIndex = 2;
            this.PageDefault.Text = "常時実行";
            this.PageDefault.UseVisualStyleBackColor = true;
            // 
            // tabControlSub
            // 
            this.tabControlSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSub.Location = new System.Drawing.Point(0, 25);
            this.tabControlSub.Name = "tabControlSub";
            this.tabControlSub.SelectedIndex = 0;
            this.tabControlSub.Size = new System.Drawing.Size(792, 315);
            this.tabControlSub.TabIndex = 1;
            this.tabControlSub.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlSub_Selected);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonAddPage,
            this.ButtonDeletePage});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(792, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // ButtonAddPage
            // 
            this.ButtonAddPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonAddPage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddPage.Image")));
            this.ButtonAddPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAddPage.Name = "ButtonAddPage";
            this.ButtonAddPage.Size = new System.Drawing.Size(72, 22);
            this.ButtonAddPage.Text = "ページを追加";
            this.ButtonAddPage.Click += new System.EventHandler(this.ButtonAddPage_Click);
            // 
            // ButtonDeletePage
            // 
            this.ButtonDeletePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonDeletePage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDeletePage.Image")));
            this.ButtonDeletePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonDeletePage.Name = "ButtonDeletePage";
            this.ButtonDeletePage.Size = new System.Drawing.Size(72, 22);
            this.ButtonDeletePage.Text = "ページを削除";
            this.ButtonDeletePage.Click += new System.EventHandler(this.ButtonDeletePage_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "null";
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "a";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 20;
            // 
            // dataGridViewImageColumn
            // 
            this.dataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewImageColumn.Frozen = true;
            this.dataGridViewImageColumn.HeaderText = "";
            this.dataGridViewImageColumn.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn.Image")));
            this.dataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn.Name = "dataGridViewImageColumn";
            this.dataGridViewImageColumn.ReadOnly = true;
            this.dataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl.ResumeLayout(false);
            this.PageOnRun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnRun)).EndInit();
            this.PageOnEnd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnEnd)).EndInit();
            this.PageDefault.ResumeLayout(false);
            this.PageDefault.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemExport;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage PageOnRun;
        private System.Windows.Forms.TabPage PageOnEnd;
        private System.Windows.Forms.TabPage PageDefault;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton ButtonAddPage;
        private System.Windows.Forms.ToolStripButton ButtonDeletePage;
        private System.Windows.Forms.DataGridView dataGridViewOnRun;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dataGridViewOnEnd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn ImageRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandInputRun;
        private System.Windows.Forms.DataGridViewImageColumn ImageEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommandInputEnd;
        private System.Windows.Forms.TabControl tabControlSub;
        private System.Windows.Forms.MenuItem menuItemExit;
    }
}

