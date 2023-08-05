using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YeniProj.Models;

namespace YeniProj.Controllers
{
    public class CourseController : Controller
    
    {
        
        
        public IActionResult List ()
        {

            return View("CourseList", Repository.Courses);
        }

        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("List", "Course");
            
            }

            var kurs = Repository.GetById(id);

            return View(kurs);

        }

    }

}    