using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentGitIgnore.Models;

namespace StudentGitIgnore.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            List<Student> obj = new List<Student>()
            {
                new Student{SId=1,SName="Disha",Marks=82 },
                new Student{SId=2,SName="Somnath",Marks=82 },
                new Student{SId=3,SName="Anuj",Marks=82 }

            };
            return View(obj);
        }
    }
}