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
    public class ToDo_data
    {
        private string title;
        private string contents;

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

            // フォルダーの存在確認
            if (!fileInfo.Directory.Exists)
            {
                // 存在しない場合はフォルダーを作成
                fileInfo.Directory.Create();
            }

            /* ファイルの作成 */
            using (FileStream fileStream = fileInfo.Create())
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes("[タイトル]");
                // ファイルへ書き込む
                fileStream.Write(bytes, 0, bytes.Length);

                bytes = new UTF8Encoding(true).GetBytes(this.title);
                // ファイルへ書き込む
                fileStream.Write(bytes, 0, bytes.Length);

                bytes = new UTF8Encoding(true).GetBytes("[内容]");
                // ファイルへ書き込む
                fileStream.Write(bytes, 0, bytes.Length);
                
                bytes = new UTF8Encoding(true).GetBytes(this.contents);
                // ファイルへ書き込む
                fileStream.Write(bytes, 0, bytes.Length);
            }
            result = true;

            return result;
        }
    }
}
