using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoUpSchoolProject.Models.Entities;

namespace DemoUpSchoolProject.Controllers
{
    public class MemberController : Controller
    {
        DBUpSchoolPortfolioEntities db = new DBUpSchoolPortfolioEntities();
        public ActionResult Index()
        {
            var mail = Session["MemberMail"].ToString();
            var values = db.TblMember.Where(x => x.MemberMail == mail).FirstOrDefault();
            ViewBag.name = values.MemerName;
            ViewBag.surname = values.MemberSurname;
            ViewBag.id = values.MemberID;
            return View();
        }
    }
}