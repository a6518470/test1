using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPnet.Controllers
{
    public class _01VarController : Controller
    {
        // GET: _01Var
        public string Index()
        {
            //字串
            string w = "Hello world";
            return w;
        }
        public string boolIndex(bool gender)
        {
            //布林
            bool w = gender;
            if (w)
                return "男生";

            return "女生";

        }
        public string stringIndex(string name,bool gender)
        {
            //字串
            string g ="" ;
            if (gender)
                g = "男";
            else
                g = "女";

            return "<h1>"+name+"你好!!你的性別是"+g+"生!!</h1>";
        }
        public void numberIndex()
        {
            //數值
            byte a = 255;//0~255 整數值(8位元整數)
            sbyte b = 127;//-128~+127 含正負數的8位元整數
            short c = 123; //-32768~+-32767 含正負數的16位元整數
            int d = 234;//-2147483648~+2147483647 含正負數的32位元整數
            long e = 453265;//含正負數的64位元整數

            /////////////////////////////////////////////////////
            ushort f = 123;//0~65535 整數值(16位元正整數)
            uint g = 123;//整數值(32位元正整數)
            ulong h = 123;//整數值(64位元正整數)

            ////////////////////////////////////////////
            float i = 123.138f;//單精準度浮點數
            double j = 123.456464;//雙精準度浮點數
  
            
        }
    }
}