using System.Text;
using System.IO;

namespace AIST.BL
{
    class FileManager
    {
        //Открытие текста
        public string GetText(string fileName, Encoding encoding)
        {

            string text = File.ReadAllText(fileName, encoding);
            return text;
        }
        public string GetText(string fileName)

        {

            string text = File.ReadAllText(fileName);
            return text;
        }
        //Сохранение текста
        public void SaveText(string fileName, string text, Encoding encoding)
        {
            File.WriteAllText(fileName, text, encoding);
        }
        public void SaveText(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
    }
}
