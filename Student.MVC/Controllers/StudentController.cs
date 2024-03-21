using Microsoft.AspNetCore.Mvc;
using Student.BL.Managers.Student;
using Student.BL.ViewModels;
using System.Collections.Generic;

namespace Student.MVC.Controllers
{
	public class StudentController : Controller
	{
		static List<string> IQLevel = [
			"Super intelligent",
			"very intelligent",
			"intelligent",
			"Average intelligence",
			"Low intelligence"
		];
		private readonly IStudentManager _stdManager;
		public StudentController(IStudentManager stdManager)
		{
			_stdManager = stdManager;
		}
		public IActionResult MainPage()
			{

			IEnumerable<AddStudentVM> students = _stdManager.GetAll();

			
			return View(students);
		}


		[HttpGet]
		public IActionResult AddStudent()
		{
			ViewBag.IqLevel = IQLevel;
			return View();
		}

		//----------------------------------------------------------
		[HttpPost]
		public IActionResult AddStudent(AddStudentVM std)
		{
			ViewBag.IqLevel = IQLevel;
			if (!ModelState.IsValid)
				return View();

			_stdManager.Add(std);
			return RedirectToAction(nameof(MainPage));
		}

        //----------------------------------------------------------
        [HttpGet]
        public IActionResult Edit(int id)
        {
			ViewBag.IqLevel = IQLevel;
			var supStd = _stdManager.GetForEditById(id);
			TempData[Constants.MyDataKeys.StdData] = supStd;
			return View(supStd);

        }
        [HttpPost]
        public IActionResult Edit(AddStudentVM supStd)
        {
			ViewBag.IqLevel = IQLevel;
			_stdManager.Update(supStd);
            
            return RedirectToAction(nameof(MainPage));
        }

		[HttpGet]
		[Route("Student/MainPage/del/{id}")]
		public IActionResult RemoveStudent(int id)
		{
			AddStudentVM  supStd = _stdManager.GetForEditById(id);
			
			_stdManager.Delete(supStd);
			return RedirectToAction(nameof(MainPage));

		

		}
	}
}
