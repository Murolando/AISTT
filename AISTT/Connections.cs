using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AISTT
{
    [XmlRoot(ElementName = "YourPreferableNameHere")]
    public  class Connections<T,U,K>
    {

        [XmlAttribute("IdSecond")]
        public U Second { get; set; }

        [XmlAttribute("IdFisrt")]
        public T First { get; set; }

        [XmlAttribute ("ConId")]

        public K Third { get; set; }

        public Connections()
        {

        }
        public Connections(T IdFisrt , U IdSecond, K ConId)
        {
            this.First = IdFisrt;
            this.Second =IdSecond;
            this.Third = ConId;
        }
    }
}
