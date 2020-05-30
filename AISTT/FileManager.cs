﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AISTT;
using System.Xml.Serialization;

namespace AISTT
{
    public class FileManager
    {
        //Открытие текста
        /* public static string GetText(string fileName, Encoding encoding)
         {

             string text = File.ReadAllText(fileName, encoding);
             return text;
         }*/
        public static string GetFile(string PathName, ref List<Buttonn> buttonns)
        {
            string pathString = Path.Combine(PathName, "filename.txt");
            string text = File.ReadAllText(pathString);
            buttonns = DeserializeXml(buttonns,PathName);
           
            return text ;
        }
        public static string GetFile(string PathName)
        {
            
            string text = File.ReadAllText(PathName);
            return text;
        }
        //XmlDeSerial
        public static List<Buttonn> DeserializeXml(List<Buttonn> Buttons, string filename)
        {
            XmlSerializer xmlMaker = new XmlSerializer(typeof(List<Buttonn>));
            string pathString = Path.Combine(filename, "filename1.xml");
            try
            {
                using (FileStream fs = new FileStream(pathString, FileMode.OpenOrCreate))
                {

                    return (List<Buttonn>)xmlMaker.Deserialize(fs);
                }
            }
            catch {
                return new List<Buttonn>();
                 }
        }
        //Сохранение текста
        /* public static void SaveText(string fileName, string text, Encoding encoding)
         {
             File.WriteAllText(fileName, text, encoding);
         }*/
        public static void SaveFile(string fileName, string text, List<Buttonn> buttonns)
        {
           // Directory.CreateDirectory(fileName);
            string pathString = Path.Combine(fileName, "filename.txt");
           // File.Create(fileName+@"filename");
            File.WriteAllText(pathString,text);

            XMLSerializer(buttonns, fileName);
            
            

        }
        public static void SaveFileAs(string text, List<Buttonn> buttonns )
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(dlg.FileName);
                SaveFile(dlg.FileName, text, buttonns);
                
                
            }

        }
        //XmlSerial
        public static void XMLSerializer(List<Buttonn> Buttons, string filename)
        {
            XmlSerializer xmlMaker = new XmlSerializer(typeof(List<Buttonn>));

            string pathString = Path.Combine(filename, "filename1.xml");
            using (FileStream fs = new FileStream(pathString, FileMode.OpenOrCreate)) 
            {
               
                xmlMaker.Serialize(fs, Buttons);
            }

        }
       



    }
}
