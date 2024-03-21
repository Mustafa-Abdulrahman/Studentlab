using Student.DAL.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DAL.Data.Models
{
	public class StudentEntity
	{
		public int Id { get; set; }
		public int Age { get; set; }
		public string fName { get; set; }
		public string lName { get; set; }
		public string Email { get; set; }
		public DeptStatus Department { get; set; }
		public string IQLevel { get; set; }
		public StudentEntity(int id, int age, string fName, string lName,string _email, DeptStatus department, string iqlevel)/*Dictionary<string, string> iqlevel*/
		{
			Id = id;
			Age = age;
			Email = _email;
			this.fName = fName;
			this.lName = lName;
			Department = department;
			IQLevel = iqlevel;

		}
		public StudentEntity()
		{

		}
	}
}
