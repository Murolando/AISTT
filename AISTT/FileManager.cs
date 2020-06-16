using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AISTT
{
    public static class FileManager
    {
        //Открытие текста
        /* public static string GetText(string fileName, Encoding encoding)
         {

             string text = File.ReadAllText(fileName, encoding);
             return text;
         }*/

        /// <summary>
        /// Открывает файл
        /// </summary>
        /// <param name="PathName">Путь к папке </param>
        /// <param name="buttonns">Связываю со списком вершин и их связей,чтобы потом выгружать </param>
        /// <returns>Текст</returns>
        public static string GetFile(string PathName)
        {
            string pathString = Path.Combine(PathName, "filename.txt");
            string text = File.ReadAllText(pathString);
            DeserializeXml(PathName);
            return text ;
        }
        //Сохранение текста
        /* public static void SaveText(string fileName, string text, Encoding encoding)
         {
             File.WriteAllText(fileName, text, encoding);
         }*/

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="fileName">путь к папке куда сохранять</param>
        /// <param name="text">текст файла</param>
        public static void SaveFile(string fileName, string text)
        {
           // Directory.CreateDirectory(fileName);
            string pathString = Path.Combine(fileName, "filename.txt");
           // File.Create(fileName+@"filename");
            File.WriteAllText(pathString,text);

            XMLSerializer( fileName);
            
            

        }
        /// <summary>
        /// Сохранение файла как
        /// </summary>
        /// <param name="text">текст файла</param>
        public static void SaveFileAs(string text)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(dlg.FileName);
                SaveFile(dlg.FileName, text);
            }

        }
        /// <summary>
        /// Сохраняет всю нужную инфу о вершинах и связями между ними в отдельный xml файл
        /// </summary>
        /// <param name="filename">путь к папке сохранения </param>
        public static void XMLSerializer(string filename)
        {
            XmlSerializer xmlMaker = new XmlSerializer( typeof(List<Buttonn>));
            XmlSerializer xmlMakerCon = new XmlSerializer(typeof(List<Connections<int,int,int>>));
            string pathString = Path.Combine(filename, "filename1.xml");
            string pathStringCon= Path.Combine(filename, "filename2.xml");
            using (FileStream fs = new FileStream(pathString, FileMode.OpenOrCreate)) 
            {
               
                xmlMaker.Serialize(fs, mainForm.Buttonns);
            }
            using (FileStream fs = new FileStream(pathStringCon, FileMode.OpenOrCreate))
            {

                xmlMakerCon.Serialize(fs, mainForm.connections);
            }

        }
        /// <summary>
        /// Десериализирует Xml файл
        /// </summary>
        /// <param name="filename">путь к файлу xml</param>
        /// <returns>Если есть xml файл,то возрващает заполненный Buttons иначе пустой</returns>
        public static void DeserializeXml( string filename)
        {
            XmlSerializer xmlMaker = new XmlSerializer(typeof(List<Buttonn>));
            XmlSerializer xmlMakerCon = new XmlSerializer(typeof(List<Connections<int, int, int>>));
            string pathString = Path.Combine(filename, "filename1.xml");
            string pathStringCon = Path.Combine(filename, "filename2.xml");
            try
            {

                using (FileStream fs = new FileStream(pathString, FileMode.OpenOrCreate))
                {
                    // mainForm.connections
                    mainForm.Buttonns = (List<Buttonn>)xmlMaker.Deserialize(fs);

                }
                using (FileStream ms = new FileStream(pathStringCon, FileMode.OpenOrCreate))
                {

                    mainForm.connections = (List<Connections<int, int, int>>)xmlMaker.Deserialize(ms);
                }
            }
            catch
            {
                
            }
           
        }




    }
}
