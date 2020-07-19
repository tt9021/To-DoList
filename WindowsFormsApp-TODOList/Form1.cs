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
            string[] toarray_list; /* List<string>の要素をstring[]で取得用 */
            string[] set_string = new string[6]; /* 表示させる文字列の配列 */

            int string_num_start = 0;
            int string_num_end = 0;

            if (tabPage_doing == Listview_tabControl.SelectedTab)
            {
                /* リストを全削除(初期化) */
                ToDo_listView.Columns.Clear();
                ToDo_listView.Items.Clear();
                
                /* 表示列 */
                Console.WriteLine("tab_view");
                ToDo_listView.Columns.Add("実施状態");
                ToDo_listView.Columns.Add("タイトル");
                ToDo_listView.Columns.Add("内容");
                ToDo_listView.Columns.Add("開始日");
                ToDo_listView.Columns.Add("終了日");
                ToDo_listView.Columns.Add("備考");

                /* セットする文字列取得 */
                ToDo_data createlist = new ToDo_data();
                file_list = createlist.road_list();

                toarray_list = file_list.ToArray();

                for(int i = 0; i < file_list.Count; i++)
                {
                    /* [状態]の内容取得 */
                    string_num_start  = toarray_list[i].IndexOf("[状態]", 1);
                    string_num_end = toarray_list[i].IndexOf("[タイトル]", 1);
                    set_string[0] = toarray_list[i].Substring(string_num_start + 5, string_num_end - (string_num_start + 5));

                    /* [タイトル]の内容取得 */
                    string_num_start  = toarray_list[i].IndexOf("[タイトル]", 1);
                    string_num_end = toarray_list[i].IndexOf("[内容]", 1);
                    set_string[1] = toarray_list[i].Substring(string_num_start + 6, string_num_end - (string_num_start + 6));


                    /* [内容]の内容取得 */
                    string_num_start  = toarray_list[i].IndexOf("[内容]", 1);
                    string_num_end = toarray_list[i].IndexOf("[開始日時]", 1);
                    if(-1 != string_num_end)
                    {
                        set_string[2] = toarray_list[i].Substring(string_num_start + 4, string_num_end - (string_num_start + 4));
                    }
                    else{
                        set_string[2] = toarray_list[i].Substring(string_num_start + 4);
                    }

                    /* [開始日時]の内容取得 */
                    string_num_start  = toarray_list[i].IndexOf("[開始日時]", 1);
                    string_num_end = toarray_list[i].IndexOf("[終了日時]", 1);
                    if(-1 != string_num_start || -1 != string_num_end)
                    {
                        set_string[3] = toarray_list[i].Substring(string_num_start + 6, string_num_end - (string_num_start + 6));
                    }

                    /* [終了日時]の内容取得 */
                    string_num_start  = toarray_list[i].IndexOf("[終了日時]", 1);
                    string_num_end = toarray_list[i].IndexOf("[備考]", 1);
                    if(-1 != string_num_start || -1 != string_num_end)
                    {
                        set_string[4] = toarray_list[i].Substring(string_num_start + 6, string_num_end - (string_num_start + 6) );
                    }

                    /* [備考]の内容取得 */
                    string_num_start  = toarray_list[i].IndexOf("[備考]", 1);
                    if(-1 != string_num_start || -1 != string_num_end)
                    {
                        set_string[5] = toarray_list[i].Substring(string_num_start + 4);
                    }

                    /* 取得した内容をリスト項目に追加する */
                    ToDo_listView.Items.Add(new ListViewItem(set_string));
                }
            }

            return;
        }
    }
}
