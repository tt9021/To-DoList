namespace WindowsFormsApp_TODOList
{
    partial class ListCreate_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.addList_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contents_richTextBox = new System.Windows.Forms.RichTextBox();
            this.extra_richTextBox = new System.Windows.Forms.RichTextBox();
            this.extra_label = new System.Windows.Forms.Label();
            this.date_start_label = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.date_end_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.list_create_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイトル";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(82, 43);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(226, 19);
            this.title_textBox.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(686, 40);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(43, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "追加";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // addList_comboBox
            // 
            this.addList_comboBox.FormattingEnabled = true;
            this.addList_comboBox.Items.AddRange(new object[] {
            "期間",
            "備考"});
            this.addList_comboBox.Location = new System.Drawing.Point(559, 40);
            this.addList_comboBox.Name = "addList_comboBox";
            this.addList_comboBox.Size = new System.Drawing.Size(121, 20);
            this.addList_comboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "内容";
            // 
            // contents_richTextBox
            // 
            this.contents_richTextBox.Location = new System.Drawing.Point(82, 82);
            this.contents_richTextBox.Name = "contents_richTextBox";
            this.contents_richTextBox.Size = new System.Drawing.Size(226, 96);
            this.contents_richTextBox.TabIndex = 5;
            this.contents_richTextBox.Text = "";
            // 
            // extra_richTextBox
            // 
            this.extra_richTextBox.Location = new System.Drawing.Point(558, 339);
            this.extra_richTextBox.Name = "extra_richTextBox";
            this.extra_richTextBox.Size = new System.Drawing.Size(226, 96);
            this.extra_richTextBox.TabIndex = 6;
            this.extra_richTextBox.Text = "";
            this.extra_richTextBox.Visible = false;
            // 
            // extra_label
            // 
            this.extra_label.AutoSize = true;
            this.extra_label.Location = new System.Drawing.Point(507, 342);
            this.extra_label.Name = "extra_label";
            this.extra_label.Size = new System.Drawing.Size(29, 12);
            this.extra_label.TabIndex = 7;
            this.extra_label.Text = "備考";
            this.extra_label.Visible = false;
            // 
            // date_start_label
            // 
            this.date_start_label.AutoSize = true;
            this.date_start_label.Location = new System.Drawing.Point(507, 265);
            this.date_start_label.Name = "date_start_label";
            this.date_start_label.Size = new System.Drawing.Size(53, 12);
            this.date_start_label.TabIndex = 8;
            this.date_start_label.Text = "期間開始";
            this.date_start_label.Visible = false;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(584, 265);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker_start.TabIndex = 9;
            this.dateTimePicker_start.Visible = false;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(584, 307);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker_end.TabIndex = 10;
            this.dateTimePicker_end.Visible = false;
            // 
            // date_end_label
            // 
            this.date_end_label.AutoSize = true;
            this.date_end_label.Location = new System.Drawing.Point(507, 307);
            this.date_end_label.Name = "date_end_label";
            this.date_end_label.Size = new System.Drawing.Size(53, 12);
            this.date_end_label.TabIndex = 11;
            this.date_end_label.Text = "期間終了";
            this.date_end_label.Visible = false;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(735, 40);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(49, 23);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "削除";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // list_create_button
            // 
            this.list_create_button.Location = new System.Drawing.Point(82, 396);
            this.list_create_button.Name = "list_create_button";
            this.list_create_button.Size = new System.Drawing.Size(75, 23);
            this.list_create_button.TabIndex = 13;
            this.list_create_button.Text = "リスト作成";
            this.list_create_button.UseVisualStyleBackColor = true;
            this.list_create_button.Click += new System.EventHandler(this.list_create_button_Click);
            // 
            // ListCreate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_create_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.date_end_label);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.date_start_label);
            this.Controls.Add(this.contents_richTextBox);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.extra_label);
            this.Controls.Add(this.extra_richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addList_comboBox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label1);
            this.Name = "ListCreate_Form";
            this.Text = "リスト作成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox addList_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox contents_richTextBox;
        private System.Windows.Forms.RichTextBox extra_richTextBox;
        private System.Windows.Forms.Label extra_label;
        private System.Windows.Forms.Label date_start_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label date_end_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button list_create_button;
    }
}