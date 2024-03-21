using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DAL.Data.Models.Enum
{
	public enum DeptStatus
	{
		SD,
		UI,
		Wireless,
		[Display(Name = "Cloud Computing")]
		CloudComputing,
		[Display(Name = "MERN")]
		MernStack
	}
}
