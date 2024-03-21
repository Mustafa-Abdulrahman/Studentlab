using Azure;
using Student.BL.ViewModels;
using Student.DAL.Data.Models;
using Student.DAL.Repo.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Student.BL.Managers.Student
{
	public class StudentManager : IStudentManager
	{
		private readonly IStudentRepo _stdRepo;


		public StudentManager(IStudentRepo stdRepo)
		{
			_stdRepo = stdRepo;
		}


		public void Add(AddStudentVM stdaddVM)
		{
			var _std = new StudentEntity() { Id = stdaddVM.Id, fName = stdaddVM.fName, lName = stdaddVM.lName,
				Age = stdaddVM.Age, Department = stdaddVM.Department, Email = stdaddVM.Email, IQLevel = stdaddVM.IQLevel };

			_stdRepo.Add(_std);
			_stdRepo.SaveChanges();
		}

		public IEnumerable<AddStudentVM> GetAll()
		{
			IEnumerable<StudentEntity> students = _stdRepo.GetAll();
			IEnumerable<AddStudentVM> studentVM = students.Select(s => new AddStudentVM(s.Id, s.fName, s.lName,
				s.Age, s.Department, s.Email, s.IQLevel));

			return studentVM;
		}

      

        public void Update(AddStudentVM std)
        {
            var student = _stdRepo.GetById(std.Id); 
			student.fName = std.fName;
			student.lName = std.lName;
			student.Age = std.Age;
			student.Department = std.Department;
			student.Email = std.Email;
			student.IQLevel = std.IQLevel;
			_stdRepo.Update(student);
			_stdRepo.SaveChanges();

        }

        public AddStudentVM? GetForEditById(int id)
        {
            var student = _stdRepo.GetById(id);
			if (student == null)
				return null;
			return new AddStudentVM(student.Id, student.fName, student.lName, student.Age, student.Department, student.Email, student.IQLevel);

              
        }

		public void Delete(AddStudentVM stdaddVM)
		{
			var student = _stdRepo.GetById(stdaddVM.Id);
			if (student == null)
				return ;

			_stdRepo.Delete(student);
			_stdRepo.SaveChanges();
		}
	}
}
