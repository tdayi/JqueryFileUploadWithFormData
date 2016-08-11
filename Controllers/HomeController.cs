using JqueryFileUploadWithFormData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryFileUploadWithFormData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveUser(
            User user)
        {
            byte[] userPhoto = null;

            if (user != null && user.File != null)
            {
                HttpPostedFileBase file = user.File;
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    userPhoto = ms.ToArray();
                };
            }

            this.InsertUser(
                user.Name,
                user.Surname,
                user.BirthPlace,
                userPhoto);

            return Json(true);
        }

        private void InsertUser(
            string name,
            string surName,
            string birthPlace,
            byte[] photo)
        {
            //.......
        }
    }
}