namespace WindowsFormsApp_TODOList
{
    partial class Form1
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
            this.ToDo_menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToDomenue_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Listview_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_doing = new System.Windows.Forms.TabPage();
            this.tabPage_finish = new System.Windows.Forms.TabPage();
            this.tabPage_all = new System.Windows.Forms.TabPage();
            this.ToDo_menuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Listview_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToDo_menuStrip
            // 
            this.ToDo_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToDomenue_toolStripComboBox});
            this.ToDo_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToDo_menuStrip.Name = "ToDo_menuStrip";
            this.ToDo_menuStrip.Size = new System.Drawing.Size(800, 27);
            this.ToDo_menuStrip.TabIndex = 0;
            this.ToDo_menuStrip.Text = "menuStrip";
            // 
            // ToDomenue_toolStripComboBox
            // 
            this.ToDomenue_toolStripComboBox.Items.AddRange(new object[] {
            "リスト一覧",
            "リスト作成"});
            this.ToDomenue_toolStripComboBox.Name = "ToDomenue_toolStripComboBox";
            this.ToDomenue_toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.ToDomenue_toolStripComboBox.Text = "メニュー";
            this.ToDomenue_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ToDomenue_toolStripComboBox_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Listview_tabControl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 423);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Listview_tabControl
            // 
            this.Listview_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listview_tabControl.Controls.Add(this.tabPage_doing);
            this.Listview_tabControl.Controls.Add(this.tabPage_finish);
            this.Listview_tabControl.Controls.Add(this.tabPage_all);
            this.Listview_tabControl.Location = new System.Drawing.Point(3, 3);
            this.Listview_tabControl.Multiline = true;
            this.Listview_tabControl.Name = "Listview_tabControl";
            this.Listview_tabControl.SelectedIndex = 0;
            this.Listview_tabControl.Size = new System.Drawing.Size(797, 420);
            this.Listview_tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Listview_tabControl.TabIndex = 0;
            this.Listview_tabControl.Visible = false;
            // 
            // tabPage_doing
            // 
            this.tabPage_doing.Location = new System.Drawing.Point(4, 22);
            this.tabPage_doing.Name = "tabPage_doing";
            this.tabPage_doing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_doing.Size = new System.Drawing.Size(789, 394);
            this.tabPage_doing.TabIndex = 0;
            this.tabPage_doing.Text = "実施中";
            this.tabPage_doing.UseVisualStyleBackColor = true;
            // 
            // tabPage_finish
            // 
            this.tabPage_finish.Location = new System.Drawing.Point(4, 22);
            this.tabPage_finish.Name = "tabPage_finish";
            this.tabPage_finish.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_finish.Size = new System.Drawing.Size(789, 394);
            this.tabPage_finish.TabIndex = 1;
            this.tabPage_finish.Text = "終了";
            this.tabPage_finish.UseVisualStyleBackColor = true;
            // 
            // tabPage_all
            // 
            this.tabPage_all.Location = new System.Drawing.Point(4, 22);
            this.tabPage_all.Name = "tabPage_all";
            this.tabPage_all.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_all.Size = new System.Drawing.Size(789, 394);
            this.tabPage_all.TabIndex = 2;
            this.tabPage_all.Text = "All";
            this.tabPage_all.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ToDo_menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ToDo_menuStrip.ResumeLayout(false);
            this.ToDo_menuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Listview_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToDo_menuStrip;
        private System.Windows.Forms.ToolStripComboBox ToDomenue_toolStripComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl Listview_tabControl;
        private System.Windows.Forms.TabPage tabPage_doing;
        private System.Windows.Forms.TabPage tabPage_finish;
        private System.Windows.Forms.TabPage tabPage_all;
    }
}

