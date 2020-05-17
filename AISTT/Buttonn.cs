using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace AISTT
{
    public class Buttonn
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public Point position { get; set; }
        public List<Pair<int,int>> connections { get; set; }
        public int buttonId { get; set; }
        
        //public 
        
        public Buttonn(string Name,string Text, Point position , int buttonId, List<Pair<int,int>> connections)
        {
            this.Name = Name;
            this.Text = Text;
            this.position = position;
            this.buttonId = buttonId;
            this.connections = connections;
        }   

    }
}
