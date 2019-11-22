using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPnet.App_Code
{
    public class Superman: Person  //繼承Person
    {
        string style;

        public string Style
        { get { return style; } set { style = value; } }

        public string Fly()
        {
            return "I can fly heigh!!";
        }
        public string Fly(int h)
        {
            return "我飛了"+h+"公尺";
        }
    }
}