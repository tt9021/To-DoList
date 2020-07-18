using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_TODOList
{
    /* List親クラス */
    public class ToDo_data
    {
        public string title; /* タイトル */
        public string contents; /* 内容 */

        /* デフォルトコンストラクタ */
        public ToDo_data()
        {

        }

        public ToDo_data(string title, string contents)
        {
            this.title = title;
            this.contents = contents;
        }

        public bool create_ToDo_data()
        {
            bool result = false;
            string path = @"\ToDo_List\"; /* 作成ファイル保存フォルダ */
            path += this.title + ".txt";
            string create_path; /* ToDo_List\[タイトル].txtのパスを作成 */

            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory()); /* カレントディレクトリを取得 */
            create_path = di.FullName + path; /* カレントディレクトからToDo_List\[タイトル].txtファイルのパスを作成 */
            Console.WriteLine(create_path);

            /* FileInfoオブジェクトのインスタンスを生成 */
            FileInfo fileInfo = new FileInfo(create_path);

            /* ファイルの存在確認 */
            if (fileInfo.Exists)
            {
                return result; //既にファイルが存在するので失敗を返す
            }

            // フォルダーの存在確認
            if (!fileInfo.Directory.Exists)
            {
                // 存在しない場合はフォルダーを作成
                fileInfo.Directory.Create();
            }

            /* ファイルの作成 */
            using (FileStream fileStream = fileInfo.Create())
            {
                // ファイルへ書き込む
                byte[] bytes = new UTF8Encoding(true).GetBytes("[状態]");
                fileStream.Write(bytes, 0, bytes.Length);

                // ファイルへ書き込む
                bytes = new UTF8Encoding(true).GetBytes("1");
                fileStream.Write(bytes, 0, bytes.Length);

                // ファイルへ書き込む
                bytes = new UTF8Encoding(true).GetBytes("[タイトル]");
                fileStream.Write(bytes, 0, bytes.Length);

                // ファイルへ書き込む
                bytes = new UTF8Encoding(true).GetBytes(this.title);
                fileStream.Write(bytes, 0, bytes.Length);


                // ファイルへ書き込む
                bytes = new UTF8Encoding(true).GetBytes("[内容]");
                fileStream.Write(bytes, 0, bytes.Length);

                // ファイルへ書き込む
                bytes = new UTF8Encoding(true).GetBytes(this.contents);

                fileStream.Write(bytes, 0, bytes.Length);
            }
            result = true;

            return result;
        }

        //public List<string> road_list()
        //{
        //    var file_list = new List<string>();

        //    string path = @"\ToDo_List\"; /* 作成ファイル保存フォルダ */
        //    string road_path; /* ToDo_List\[タイトル].txtのパスを作成 */

        //    DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory()); /* カレントディレクトリを取得 */
        //    road_path = di.FullName + path; /* カレントディレクトから/ToDo_Listのパス追加 */
        //    Console.WriteLine(road_path);

        //    string[] list_files_name = Directory.GetFiles(road_path, "*.txt");


        //    /* ToDo_Listフォルダ内にあるtxtファイルの内容をリストに記録 */
        //    foreach (string name in list_files_name)
        //    {
        //        road_path = di.FullName + path + name + ".txt"; /* 取得するファイルパスを設定 */
        //        StreamReader stream = new StreamReader(road_path, Encoding.GetEncoding("UTF-8"));
        //        string stream_str = stream.ReadToEnd();

        //        file_list.Add(stream_str);

        //        stream.Close();

        //    }

        //    return file_list;
            
        //}
    }

    /* List子クラス */
    public class add_ToDo_data : ToDo_data
    {
        public DateTime date_start; /* 期間開始 */
        public DateTime date_end;   /* 期間終了 */

        public string extra_contents; /* 備考 */

        /* デフォルトコンストラクタ */
        public add_ToDo_data()
        {

        }

        public add_ToDo_data(string title, string contents, 
            DateTime date_start, DateTime date_end, string extra_contents)
        {
            this.title = title;
            this.contents = contents;

            this.date_start = date_start;
            this.date_end = date_end;

            this.extra_contents = extra_contents;
        }

        public bool create_ToDo_data_add()
        {
            bool result = false;
            bool result_ToDo_data = false;

            string path = @"\ToDo_List\"; /* 作成ファイル保存フォルダ */
            path += this.title + ".txt";
            string create_path; /* ToDo_List\[タイトル].txtのパスを作成 */

            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory()); /* カレントディレクトリを取得 */
            create_path = di.FullName + path; /* カレントディレクトからToDo_List\[タイトル].txtファイルのパスを作成 */
            Console.WriteLine(create_path);

            /* FileInfoオブジェクトのインスタンスを生成 */
            FileInfo fileInfo = new FileInfo(create_path);

            result_ToDo_data = create_ToDo_data();

            if(true == result_ToDo_data)
            {
                /* ファイルの作成 */
                using ( StreamWriter filewriter = fileInfo.AppendText())
                {
                    /* 開始日時 */
                    string word = "[開始日時]";
                    // ファイルへ書き込む
                    filewriter.Write(word);

                    word = this.date_start.ToShortDateString();
                    // ファイルへ書き込む
                    filewriter.Write(word);

                    /* 終了日時 */
                    word = "[終了日時]";
                    // ファイルへ書き込む
                    filewriter.Write(word);

                    word = this.date_end.ToShortDateString();
                    // ファイルへ書き込む
                    filewriter.Write(word);

                    /* 備考 */
                    word = "[備考]";
                    // ファイルへ書き込む
                    filewriter.Write(word);

                    word = this.extra_contents;
                    // ファイルへ書き込む
                    filewriter.Write(word);
                }
                result = true;
            }
            else
            {
                Console.WriteLine("create_ToDo_data FAILED");
            }

            return result;
        }

    }
}
