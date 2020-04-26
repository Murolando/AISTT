using System.Text;
using System.IO;
using System.Windows.Forms;

namespace AIST.BL
{
   public class FileManager
    {
       
        //Открытие текста
       /* public static string GetText(string fileName, Encoding encoding)
        {

            string text = File.ReadAllText(fileName, encoding);
            return text;
        }*/
        public static string GetText(string fileName)
        {

            string text = File.ReadAllText(fileName);
            return text;
        }
        //Сохранение текста
       /* public static void SaveText(string fileName, string text, Encoding encoding)
        {
            File.WriteAllText(fileName, text, encoding);
        }*/
        public static void SaveText(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
        public static void SaveTextAs(string text)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileManager.SaveText(dlg.FileName, text);
            }
        }
        //создание файла
        
    }
}
