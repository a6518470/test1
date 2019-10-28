using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02Controller.Controllers
{
    public class fileUploadController : Controller
    {
        // GET: fileUpload
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {
            string fileName = "";

            if (photo != null)
            {
                if (photo.ContentLength>0)
                {
                    fileName = photo.FileName; //取得圖片檔名
                    fileName = Path.GetFileName(fileName);

                    photo.SaveAs(Server.MapPath("~/Photos/"+ fileName)); //存入Photos資料夾 

                }

            }

            return RedirectToAction("ShowPhotos");
        }

        public string ShowPhotos()
        {
            string show = "";

            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos/"));

            FileInfo[] fInfo = dir.GetFiles();

            foreach (FileInfo result in fInfo)
            {
                show += "<a href='../Photos/" + result.Name + "'><img src='../Photos/" + result.Name + "' width='90' height='60'/></a>";

            }

            show += "<p><a href='Create'>返回</a></p>";
            return show;

        }
    }
}