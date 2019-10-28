using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPnet.Controllers
{
    public class _01hwController : Controller
    {
        // GET: _01hw
        public void Hw1()
        {
            int a = 42;
            float b = 2.5f;
            Response.Write(a + "+" + b + "=" + (a + b) + "<br>");
            Response.Write(a + "-" + b + "=" + (a - b) + "<br>");
            Response.Write(a + "*" + b + "=" + (a * b) + "<br>");
            Response.Write(a + "/" + b + "=" + (a / b) + "<br>");
            Response.Write(a + "%" + b + "=" + (a % b) + "<br>");
        }
        public double Hw2(double c)
        {
            return c * 9 / 5 + 32;
        }
        public void Hw3(int x, int y)
        {
            x = x ^ y;
            y = x ^ y;  
            x = x ^ y; 
            Response.Write("交換後X=" + x + ", Y=" + y);
        }
        public string Hw4(int s)
        {
            int x = s / 10;
            string level = "";
            switch (x)
            {
                case 10:
                case 9:
                    level = "優等";
                    break;
                case 8:
                    level = "甲等";
                    break;
                case 7:
                    level = "乙等";
                    break;
                case 6:
                    level = "丙等";
                    break;
                default:
                    level = "丁等";
                    break;
            }

            return level;
        }
        public void Hw5(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 != 0)
                    Response.Write(i + " ");
            }
        }
        public void Hw6(int n)
        {
            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0)
                    sum += i;
            }
            Response.Write(sum);
        }
        public void Hw7(int n)
        {
            int i = 1;
            string r = "";
            while (i <= n)
            {
                r += "*";
                Response.Write(r + "<br>");
                i++;
            }

        }
        public void Hw8()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Response.Write(i + "*" + j + "=" + i * j);
                    Response.Write("<br>");
                }
                Response.Write("<br>");
            }
        }
    }
}