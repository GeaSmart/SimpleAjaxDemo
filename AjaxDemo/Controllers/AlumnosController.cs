using AjaxDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            //Alumno alumno = new Alumno();
            return View();
        }

        [HttpPost]
        public ActionResult AddAlumno([FromBody]Alumno alumno)
        {
            return Json(alumno);
        }
    }
}
