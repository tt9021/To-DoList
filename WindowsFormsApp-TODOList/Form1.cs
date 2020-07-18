using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TODOList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToDomenue_toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string list_view = "リスト一覧";
            string list_create = "リスト作成";

            /* comboBoxで選択された文字 「リスト一覧」 */
            if (list_view.Equals(ToDomenue_toolStripComboBox.SelectedItem))
            {
                Listview_tabControl.Visible = true; /* tab一覧を表示 */
                Listview_tabControl.SelectedTab = tabPage_doing;
                visible_list_columns();
            }
            /* comboBoxで選択された文字 「リスト作成」 */
            else if (list_create.Equals(ToDomenue_toolStripComboBox.SelectedItem))
            {
                ListCreate_Form create_form = new ListCreate_Form();
                create_form.Show();
            }
            else
            {

            }
        }


        private void Listview_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            visible_list_columns();
        }

        private void visible_list_columns()
        {

            var file_list = new List<string>();
            string[] set_string;

            if (tabPage_doing == Listview_tabControl.SelectedTab)
            {
                Console.WriteLine("tab_view");
                ToDo_listView.Columns.Add("実施状態");
                ToDo_listView.Columns.Add("タイトル");
                ToDo_listView.Columns.Add("内容");
                ToDo_listView.Columns.Add("開始日");
                ToDo_listView.Columns.Add("終了日");
                ToDo_listView.Columns.Add("備考");

                //ToDo_data createList = new ToDo_data();
                //file_list = createList.road_list();

                //for(int i = 0; i < file_list.Count; i++)
                //{
                //    file_list.IndexOf("[状態]", 1);
                //    set_string.SetValue(, 1);

                //    file_list.IndexOf("[タイトル]", 1);
                //    file_list.IndexOf("[内容]", 1);
                //    file_list.IndexOf("[開始日時]", 1);
                //    file_list.IndexOf("[終了日時]", 1);
                //    file_list.IndexOf("[備考]", 1);

                //    ToDo_listView.Items.Add(new ListView(set_string));
                //}

                //リスト項目の設定
               // string[] set_string = { "1行目_列1", "1行目_列2", "1行目_列3" };
                //string[] row_2 = { "2行目_列1", "2行目_列2", "2行目_列3" };
               // string[] row_3 = { "3行目_列1", "3行目_列2", "3行目_列3" };
                // todo_listview.items.add(new listviewitem(row_1));
                //todo_listview.items.add(new listviewitem(row_2));
                //todo_listview.items.add(new listviewitem(row_3));

            }

            return;
        }
    }
}
