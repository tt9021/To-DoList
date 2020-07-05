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
            if(list_view.Equals(ToDomenue_toolStripComboBox.SelectedItem) )
            {
                Listview_tabControl.Visible = true; /* tab一覧を表示 */
            }
            /* comboBoxで選択された文字 「リスト作成」 */
            else if(list_create.Equals(ToDomenue_toolStripComboBox.SelectedItem))
            {
                ListCreate_Form create_form = new ListCreate_Form();
                create_form.Show();
            }
            else
            {

            }
        }
    }
}
