﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyXeCong.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. ĐÂY là trang about giới thiệu về chúng tôi";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. Đây là trang liên hệ của chúng tôi";

            return View();
        }
    }
}