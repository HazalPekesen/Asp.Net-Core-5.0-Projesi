﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {

        NotificationManager nm = new NotificationManager(new EfNotificationRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotification()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
