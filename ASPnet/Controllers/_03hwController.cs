using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPnet.Controllers
{
    public class _03hwController : Controller
    {
        // GET: _03hw
        public void Hw()
        {
            //撲克牌發牌程式
            string[] poker = new string[52];  //0~51
            PlayGame(ref poker);
            Shuffle(ref poker);
            Deal_the_Card(ref poker);
        }

        //弄一副牌出來
        public void PlayGame(ref string[] poker)
        {

            for (int i = 0; i < poker.Length; i++)
                poker[i] = (i + 1).ToString();

            //測試
            //for (int i = 0; i < poker.Length; i++)
            //    Response.Write("<img src='../poker_img/" + poker[i] + ".gif' />");
            //Response.Write("<hr>");


        }
        //洗牌
        public void Shuffle(ref string[] poker)
        {
            Random r = new Random();
            int t = 0;
            string tmp = "";
            for (int i = 0; i < poker.Length; i++)
            {
                t = r.Next(52);
                tmp = poker[i];
                poker[i] = poker[t];
                poker[t] = tmp;
            }
            //測試
            //for (int i = 0; i < poker.Length; i++)
            //    Response.Write("<img src='../poker_img/"+poker[i]+".gif' />");
            //Response.Write("<hr>");

        }
        public void Deal_the_Card(ref string[] poker)
        {
            string p1 = "", p2 = "", p3 = "", p4 = "";
            string result = "";

            for (int i = 0; i < poker.Length; i++)
            {
                result = "<img src='../poker_img/" + poker[i] + ".gif' />";
                switch (i % 4)
                {
                    case 0:
                        p1 += result;
                        break;
                    case 1:
                        p2 += result;
                        break;
                    case 2:
                        p3 += result;
                        break;
                    case 3:
                        p4 += result;
                        break;
                }
            }

            Response.Write("<div>玩家1：" + p1 + "</div><div>玩家2：" + p2 + "</div><div>玩家3：" + p3 + "</div><div>玩家4：" + p4 + "</div>");


        }

    }
}