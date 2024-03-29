﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _06ViewModel.Models;
using System.Data.Entity;

namespace _06ViewModel.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Home
        public ActionResult Index()
        {
            //Linq

            //var aa = (from b in db.職稱
            //          join a in db.員工
            //          on b.職稱代碼 equals a.職稱
            //          select new { a.員工編號, a.姓名, b.職稱1, a.出生日期 });

            //var aa = (from b in db.職稱
            //          from a in db.員工

            //          select new { a.員工編號, a.姓名, b.職稱1, a.出生日期 });

            //var aa = db.員工;
            var bb = db.員工.Include(員=> 員.職稱1);


            return View(bb.ToList());
        }

        public ActionResult Create()
        {
            //ViewBag.職稱 = db.職稱.ToList();

            ViewBag.職稱 = new SelectList(db.職稱, "職稱代碼", "職稱1");
            return View();
        }
        [HttpPost]
        public ActionResult Create(員工 員工)
        {
            db.員工.Add(員工);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}