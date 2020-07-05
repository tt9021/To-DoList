using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp_TODOList;

namespace WindowsFormsApp_TODOList
{
    public partial class ListCreate_Form : Form
    {
        public ListCreate_Form()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string date_combobox = "期間";
            string extra_combobox = "備考";

            /* 期間を選択して追加時 */
            if(date_combobox.Equals(addList_comboBox.SelectedItem) )
            {
                /* 期間開始表示 */
                date_start_label.Visible = true;
                dateTimePicker_start.Visible = true;

                /* 期間終了表示 */
                date_end_label.Visible = true;
                dateTimePicker_end.Visible = true;
            }
            /* 備考を選択して追加時 */
            else if(extra_combobox.Equals(addList_comboBox.SelectedItem) )
            {
                /* 備考項目表示 */
                extra_label.Visible = true;
                extra_richTextBox.Visible = true;
            }
            else
            {

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string date_combobox = "期間";
            string extra_combobox = "備考";

            /* 期間を選択して削除時 */
            if (date_combobox.Equals(addList_comboBox.SelectedItem))
            {
                /* 期間開始非表示 */
                date_start_label.Visible = false;
                dateTimePicker_start.Visible = false;

                /* 期間終了非表示 */
                date_end_label.Visible = false;
                dateTimePicker_end.Visible = false;

                dateTimePicker_start.Value = DateTime.Today;
                dateTimePicker_end.Value = DateTime.Today;
            }
            /* 備考を選択して削除時 */
            else if (extra_combobox.Equals(addList_comboBox.SelectedItem))
            {
                /* 備考項目非表示 */
                extra_label.Visible = false;
                extra_richTextBox.Visible = false;
                
                extra_richTextBox.Text = ""; /* 入力内容初期化 */
            }
            else
            {

            }

        }

        private void list_create_button_Click(object sender, EventArgs e)
        {
            bool create_result = false;

            ToDo_data createList = new ToDo_data(title_textBox.Text, contents_richTextBox.Text);
            
            create_result = createList.create_ToDo_data();

            if(true == create_result)
            {
                Console.WriteLine("create_file SUCCESS");
            }
            else
            {
                Console.WriteLine("create_file FAILED");
            }
        }
    }
}
