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
    public partial class result_view_window : Form
    {
        public  enum label_no
        {
            Success_label = 0,
            False_label,
            Max_label
        }

        /* 表示ラベル文字一覧 */
        private string create_success_label = "リスト作成に成功しました。";
        private string create_false_label = "リスト作成に失敗しました。";



        public result_view_window()
        {
            InitializeComponent();
        }

        /* 引数に合わせた文字のラベルに変える */
        public result_view_window(label_no order_label_no)
        {            
            InitializeComponent();
            Console.WriteLine("order_label_no {0}",order_label_no);

            switch (order_label_no)
            {
                case label_no.Success_label:
                    result_view_label.Text = create_success_label;
                    break;

                case label_no.False_label:
                    result_view_label.Text = create_false_label;
                    break;
                
                default:
                    Console.WriteLine("result_view_error");
                    break;
            }
        }

    }
}
