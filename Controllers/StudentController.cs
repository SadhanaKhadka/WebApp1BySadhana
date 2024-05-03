using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApp1BySijan.Models;

namespace WebApp1ByYourName.Controllers
{
    public class StudentController : Controller
    {
        Student s = new Student()
        {
            StdID = 12,
            Name = "John Doe",
            Address = "123 Main St",
            Faculty = "Computer Science"
        };
        public IActionResult MyRazorPage()
        {
            return View(s);
        }
        public IActionResult CreateStudentRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudentRecord(Student s)
        {
            if (ModelState.IsValid)
                return View("StudentDetail", s);
            else
                return View(s);
        }

        public IActionResult StudentDetail()
        {
            return View(s);
        }
    }
}
