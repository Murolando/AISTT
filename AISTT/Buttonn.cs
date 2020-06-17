using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Xml.Serialization;

namespace AISTT
{
    public class Buttonn
    {
        [XmlAttribute]
        public string Text { get; set; }
        public Point position { get; set; }
      
        [XmlAttribute]
        public int buttonId { get; set; }
      
        /// <summary>
        /// Конструктор по умолчанию для сериализации
        /// </summary>
        public Buttonn()
        {

        }      
        /// <summary>
        /// контруктор,хранящий в себе все нужные нам данные о вершинах
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="position"></param>
        /// <param name="buttonId"></param>
        /// <param name="connections"></param>
        public Buttonn(string Text, Point position , int buttonId)
        {
            
            this.Text = Text;
            this.position = position;
            this.buttonId = buttonId;
          
   
        }   

    }
}
