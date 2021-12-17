using AjaxDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxDemo.Controllers
{
    public class AlumnosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddAlumno(Alumno alumno)
        {
            //return Json(alumno, JsonRequestBehavior.AllowGet);
            return Json(alumno, new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}
