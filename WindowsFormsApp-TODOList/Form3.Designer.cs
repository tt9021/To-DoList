namespace WindowsFormsApp_TODOList
{
    partial class result_view_window
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
            this.result_view_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result_view_label
            // 
            this.result_view_label.AutoSize = true;
            this.result_view_label.Location = new System.Drawing.Point(38, 23);
            this.result_view_label.Name = "result_view_label";
            this.result_view_label.Size = new System.Drawing.Size(35, 12);
            this.result_view_label.TabIndex = 0;
            this.result_view_label.Text = "label1";
            // 
            // result_view_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 56);
            this.Controls.Add(this.result_view_label);
            this.Name = "result_view_window";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result_view_label;
    }
}