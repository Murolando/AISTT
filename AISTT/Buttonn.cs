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
        public string Name { get; set; }
        [XmlAttribute]
        public string Text { get; set; }

       // [XmlAttribute]
        public Point position { get; set; }

        [XmlElement("Connections")]
        public List<Pair<int,int>> connections { get; set; }
        [XmlAttribute]
        public int buttonId { get; set; }

        [XmlElement("Size")]
        public Pair <int,int > size { get; set; }



        public Buttonn()
        {

        }
        
        public Buttonn(string Name,string Text, Point position , int buttonId, List<Pair<int,int>> connections, Pair<int,int> size)
        {
            this.Name = Name;
            this.Text = Text;
            this.position = position;
            this.buttonId = buttonId;
            this.size = size;
            this.connections = connections;
        }   

    }
}
