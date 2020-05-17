using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AISTT;

namespace AISTT
{
     public class XMLSerial
     {
        List<Buttonn> buttons = new List<Buttonn>();
        
        public void MakeConntection(int idIn,int idOut,int valueOfConnection)
        {
            for(int i = 0 ;i<buttons.Count;i++)
            {
                if (buttons[i].buttonId == idOut)
                    buttons[i].connections.Add(new Pair<int,int> (idIn,valueOfConnection));
                if (buttons[i].buttonId == idIn)
                    buttons[i].connections.Add(new Pair<int, int>(idOut, valueOfConnection));
            }
        }
        public void XMLSerializer()
        {



        }

     }
}
