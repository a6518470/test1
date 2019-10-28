using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPnet.Controllers
{
    public class _02StatementController : Controller
    {
        // GET: _02Statement
        public void Statement1()
        {
            int a = 10;  //宣告a變數為int型態,並初始化其值為10
            a = 20;  //指運運算 a=20

            a = a + 10;  //加法指定運算  a=30
            a += 10;  //a=40

            a -= 15; //a=25
            a *= 10;  //a=250
            a /= 25;  //a=10

            a = a + 1;
            a += 1;
            a++; //a=13

            Response.Write("a=" + a);
            Response.Write("<hr>");
            //////////////////////////////////////////////////////
            //浮點數的問題-精準度遺失
            int x = 123;
            float z = 12.14567f;
            float result = 0;
            result = x + z;

            Response.Write("x + z=" + result);
            Response.Write("<hr>");

            float xx = 10000.9f;
            double yy = 9999.3;
            Response.Write("xx + yy=" + ((decimal)xx + (decimal)yy));
            Response.Write("<hr>");
            Response.Write("xx - yy=" + ((decimal)xx - (decimal)yy));

        }

        public string ifStatement(int age)
        {
            //0-6歲免票，7-20歲半票，21以上全票
            if (age > 20)
                return "全票";
            else if(age>6)
                return "半票";
            else if (age >= 0)
                return "免票";

            return "年齡輸入錯誤";

        }
        public void forStatement()
        {
            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] arrColor = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            for(int i=0;i< arrRainbow.Length; i++)
            {
                Response.Write("<span style='color:"+arrColor[i]+"'>"+arrRainbow[i]+ "</span>");

            }

        }
        public void foreachStatement()
        {
            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] arrColor = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            int i = 0;
            foreach (string item in arrRainbow)
            {
                Response.Write("<span style='color:"+arrColor[i]+"'>"+item+"</span>");
                i++;
            }

        }
        public void poker()
        {
            for(int i=1;i<=52;i++)
            Response.Write("<img src='../poker_img/"+i+".gif' />");

        }

        public void whileStatement()
        {
            int i = 1;
            while (i <= 52)
            {
                Response.Write("<img src='../poker_img/" + i + ".gif' />");
                i++;
            }
        }

        public void doStatement()
        {
            int i = 1;
            do
            {
                Response.Write("<h" + i + ">Welcome 12345678</h" + i + ">");
                i++;
            }
            while (i <= 6);

        }
    }
}
//算數運算與指定運算
//1.算數運算子 +,-,*,/,%
//2.（）小括號
//3.連接符號 +
//4.負號 -
//5.優先權
//  ()
//  * , / , %
//  + , -
//6,留意浮點數運算後遺失精準度的問題
