using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPnet.App_Code
{
    public abstract class Animal  //抽象類別 基底類別   可以實作 彈性不足可做成介面
    {
        public string Name { get; set; }

        //public string Move(int m)
        //{
        //    return "移動了" + m + "公尺"; //實作內容

        //}

        //public abstract string Speak(); //抽象方法
    }
}