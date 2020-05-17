﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AISTT
{
    public class Pair<T, U>
    {

        [XmlElement("With_whom")]
        public T First { get; set; }
        [XmlElement("Value")]
        public U Second { get; set; }
        public Pair()
        { 
        }
        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

 
    };
}