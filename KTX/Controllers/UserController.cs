using KTX.Models;
using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTX.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
       /* public ActionResult Index()
        {
            var user = new UserDAO();
            var model= user.ListAll();
            return View(model);
        }
        */
        public ActionResult Index(string searchString)
        {
            var user = new UserDAO();
            var model = user.ListWhereAll(searchString);
            @ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NGUOIDUNG ngDung)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                if (dao.Find(ngDung.TenDangNhap) != null)
                {
                    return RedirectToAction("Create", "User");
                }
                String result = dao.Insert(ngDung);
                if (!String.IsNullOrEmpty(result))
                {
                  
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm người dùng không thành công");
                }
            }
            return View();
        } 
    }
}