using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPnet.Controllers
{
    public class _04hwController : Controller
    {
        const string E = "ABCDEFGHJKLMNPQRSTUVWXYZIO";
        // GET: _04hw
        public ActionResult Hw()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Hw(string id)
        {
            string result = "";
            if (!No1(ref id))
                result = "格式有誤";
            else if (!No2(ref id))
                result = "格式有誤";
            else if (!No3(ref id))
                result = "格式有誤";
            else if (!No4(ref id))
                result = "格式有誤";
            else if (!No5(ref id))
                result = "此身分證字號不正確";
            else
                result = "這是合法的身分證字號";

            ViewBag.Result = result;

            return View();
        }
        public bool No1(ref string id)
        {
            if (id.Length == 10)
                return true;
            return false;
        }
        public bool No2(ref string id)
        {
            string w = id.Substring(0, 1);

            if (E.Contains(w))
                return true;

            return false;
        }
        public bool No3(ref string id)
        {
            string gender = id.Substring(1, 1);

            if (gender == "1" || gender == "2")
                return true;

            return false;
        }
        public bool No4(ref string id)
        {
            try
            {
                for (int i = 2; i < 10; i++)
                {
                    Convert.ToInt16(id.Substring(i, 1));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool No5(ref string id)
        {
            string w = id.Substring(0, 1);
            int intEng = E.IndexOf(w) + 10;

            int n1 = intEng / 10;
            int n2 = intEng % 10;

            int[] a = new int[9];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt16(id.Substring(i + 1, 1));
            }

            int sum = n1 + n2 * 9 + a[0] * 8 + a[1] * 7 + a[2] * 6 + a[3] * 5 + a[4] * 4 + a[5] * 3 + a[6] * 2 + a[7] + a[8];
            if (sum % 10 == 0)
                return true;

            return false;
        }

    }
}
