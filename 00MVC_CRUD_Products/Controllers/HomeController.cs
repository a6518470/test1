//00-1-6 using _00MVC_CRUD_Products.Models;
using _00MVC_CRUD_Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _00MVC_CRUD_Products.Controllers
{
    public class HomeController : Controller
    {
        //00-1-7 使用Entity建立DB物件
        dbProductEntities db = new dbProductEntities();

        // GET: Home
        //00-2-1 在HomeController裡撰寫Index的Action
        public ActionResult Index()
        {
            var products = db.tProduct.ToList();                
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string fId,string fName,decimal fPrice,HttpPostedFileBase fImg)
        {
            //處理圖檔
            string fileName = "";
            if (fImg != null)
            {
                if (fImg.ContentLength > 0)
                {
                    fileName = System.IO.Path.GetFileName(fImg.FileName); //取得檔案的檔名
                    fImg.SaveAs(Server.MapPath("~/images/" + fileName)); //將檔案存到images資料夾下

                }
            }

            tProduct product = new tProduct();
            product.fId = fId;
            product.fName = fName;
            product.fPrice = fPrice;
            product.fImg = fileName;

            db.tProduct.Add(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(string fId)
        {
            var product = db.tProduct.Where(m => m.fId == fId).FirstOrDefault();
            string fileName = product.fImg;
            if (fileName != "")
            {
                System.IO.File.Delete(Server.MapPath("~/images/" + fileName));
            }

            db.tProduct.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(string fId)
        {
            var product = db.tProduct.Where(m => m.fId == fId).FirstOrDefault();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(string fId, string fName, decimal fPrice, HttpPostedFileBase fImg, string oldImg)
        {
            //處理圖檔上傳
            string fileName = "";
            if (fImg != null)
            {
                if (fImg.ContentLength > 0)
                {

                    System.IO.File.Delete(Server.MapPath("~/images/" + oldImg));//刪掉暨有的圖檔
                    fileName = System.IO.Path.GetFileName(fImg.FileName); //取得檔案的檔名
                    fImg.SaveAs(Server.MapPath("~/images/" + fileName));  //將檔案存到Images資料夾下

                }
            }
            else
            {
                fileName = oldImg;
            }
            //處理圖檔上傳end
            var product = db.tProduct.Where(m => m.fId == fId).FirstOrDefault();

            product.fName = fName;
            product.fPrice = fPrice;
            product.fImg = fileName;


            db.SaveChanges();

            return RedirectToAction("Index");  //導向Index的Action方法
        }
    }
}

//00-1 利用Entity Framework建立Model(DB First)
//00-1-1 建立dbProduct.mdb資料庫Model
//       在Models上按右鍵,選擇加入,新增項目,資料,ADO.NET實體資料模型,名稱輸入"ProductModel",按新增
//       來自資料庫的EF Designer
//       連接dbProduct.mdf資料庫,連線名稱不修改,按下一步按鈕
//       選擇Entity Framework 6.x, 按下一步按鈕
//       資料表勾選"tProuct", 按完成鈕
//       若跳出詢問方法按確定鈕
//00-1-2 在專案上按右鍵,建置
//00-1-3 在tProduct.cs裡加入欄位名稱顯示(需using System.ComponentModel)
//00-1-4 在Controllers資料夾上按右鍵,加入,控制器,選擇 MVC5Controller-Empty
//00-1-5 指定控制器名稱為HomeController,並開啟HomeController
//00-1-6 using _00MVC_CRUD_Product.Models
//00-1-7 使用Entity建立DB物件


//00-2 製作Index頁面的顯示所有產品功能
//00-2-1 在HomeController裡撰寫Index的Action
//00-2-2 在public ActionResult Index()上按右鍵,新增檢視,建立Index View
//00-2-3 進行下列設定:
//       View name:Index
//       Template:List
//       Model class:tStudent(_00MVC_CRUD_Product.Models)
//       Data context class:dbProductEntities(_00MVC_CRUD_Product.Models)
//       勾選Use a layout pages
//       按下Add
//00-2-4 修改 _Layout.cshtml
//00-2-5 修改Index View,英文文字為中文
//00-2-6 修改圖片顯示處,處理沒有圖片的產品
//00-2-7 修改功能連結處 (id=>fId) 

//00-3 製作刪除功能
//00-3-1 在HomeController裡撰寫Delete的Action
//00-3-2 修改Index View的刪除連結，加入確認訊息框

//00-4 製作Create頁面及新增產品功能
//00-4-1 在HomeController裡撰寫GET及POST的Create Action
//00-4-2 在public ActionResult Create()上按右鍵,新增檢視,建立Create View
//00-4-3 進行下列設定:
//       View name:Create
//       Template:Create
//       Model class:tStudent(_00MVC_CRUD_Product.Models)
//       Data context class:dbProductEntities(_00MVC_CRUD_Product.Models)
//       勾選Use a layout pages
//       按下Add
//00-4-4 修改Index View,英文文字為中文
//00-4-5 修改form的HTML Helper為一般的from
//00-4-6 修改圖片上傳處表單
//00-4-7 加入例外訊息顯示處


//00-5 製作Edit頁面及修改產品功能
//00-5-1 在HomeController裡撰寫GET及POST的Edit Action
//00-5-2 在public ActionResult Edit()上按右鍵,新增檢視,建立Edit View
//00-5-3 進行下列設定:
//       View name:Edit
//       Template:Edit
//       Model class:tStudent(_00MVC_CRUD_Product.Models)
//       Data context class:dbProductEntities(_00MVC_CRUD_Product.Models)
//       勾選Use a layout pages
//       按下Add
//00-5-4 修改Edit View,英文文字為中文
//00-5-5 修改form的HTML Helper為一般的from
//00-5-6 修改圖片上傳處表單
//00-5-7 加入錯誤訊息顯示處

//00-5 執行與測試

//00-1 利用Entity Framework建立Model(DB First)
//00-1-1 建立dbProduct.mdb資料庫Model
//       在Models上按右鍵,選擇加入,新增項目,資料,ADO.NET實體資料模型,名稱輸入"ProductModel",按新增
//       來自資料庫的EF Designer
//       連接dbProduct.mdf資料庫,連線名稱不修改,按下一步按鈕
//       選擇Entity Framework 6.x, 按下一步按鈕
//       資料表勾選"tProuct", 按完成鈕
//       若跳出詢問方法按確定鈕
//00-1-2 在專案上按右鍵,建置
//00-1-3 在tProduct.cs裡加入欄位名稱顯示(需using System.ComponentModel)
//00-1-4 在Controllers資料夾上按右鍵,加入,控制器,選擇 MVC5Controller-Empty
//00-1-5 指定控制器名稱為HomeController,並開啟HomeController
//00-1-6 using _00MVC_CRUD_Product.Models
//00-1-7 使用Entity建立DB物件


//00-2 製作Index頁面的顯示所有產品功能
//00-2-1 在HomeController裡撰寫Index的Action
//00-2-2 在public ActionResult Index()上按右鍵,新增檢視,建立Index View
//00-2-3 進行下列設定:
//       View name:Index
//       Template:List
//       Model class:tStudent(_00MVC_CRUD_Product.Models)
//       Data context class:dbProductEntities(_00MVC_CRUD_Product.Models)
//       勾選Use a layout pages
//       按下Add
//00-2-4 修改 _Layout.cshtml
//00-2-5 修改Index View,英文文字為中文
//00-2-6 修改圖片顯示處,處理沒有圖片的產品
//00-2-7 修改功能連結處 (id=>fId) 
