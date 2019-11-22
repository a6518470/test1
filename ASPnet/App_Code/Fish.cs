using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPnet.App_Code
{
    public class Fish:IAnimalmove  //抽象類別只能繼承一次 介面可以繼承很多
    {
        public string Move(int m)
        {
            return "游" + m + "公尺";
        }
    }
}