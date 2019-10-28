using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPnet.Controllers
{
    public class _02hwController : Controller
    {
        // GET: _02hw
        public void Hw1(int a)
        {
            bool flag = false;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                Response.Write(a + "不是質數");
            else
                Response.Write(a + "是質數");
        }

        public void Hw2(int a,int b)
        {
            int aa = a, bb = b, c = 0;

            while (aa % bb != 0)
            {
                c = aa % bb;
                aa = bb;
                bb = c;
            }
            Response.Write(a+"和"+b+"的最大公因數為"+bb);

        }

        public void Hw3(int a)
        {
            int aa = a, b = 0, c = 0;
            int result = 0;

            do
            {
                b = aa % 10; //取餘數
                result += b; //把餘數組合進結果
                c = aa / 10; //取商數做為下一輪的被除數

                aa = c;  //把商數的值丟進被除數的變數裡
                if (c == 0)
                    break;

                result *= 10;
            } while (c != 0);

            if(result==a)
                Response.Write(a + "是迴文");
            else
                Response.Write(a + "不是迴文");

        }
    }
}