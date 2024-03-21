using Student.BL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.BL.Managers.Student
{
	public interface IStudentManager
	{
		IEnumerable<AddStudentVM> GetAll();
		
		void Add(AddStudentVM stdaddVM);
        AddStudentVM? GetForEditById(int id);
        void Delete(AddStudentVM stdaddVM);
        void Update(AddStudentVM stdaddVM);
    }
}
