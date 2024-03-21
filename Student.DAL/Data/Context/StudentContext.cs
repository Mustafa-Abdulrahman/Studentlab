using Microsoft.EntityFrameworkCore;
using Student.DAL.Data.Models;
using Student.DAL.Data.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;




namespace Student.DAL.Data.Context
{
	public class StudentContext:DbContext
	{
		#region Data
		static List<StudentEntity> _student = new List<StudentEntity>{
				new StudentEntity { Id = 1, Age = 27, fName = "Mustafa", lName = "Abdo", Department = DeptStatus.UI ,Email="Mustafa@gmail.com", IQLevel="Super intelligent"},
				new StudentEntity { Id = 2, Age = 25, fName = "Ahmed", lName = "Ali", Department = DeptStatus.MernStack,Email="Ahmed@gmail.com",IQLevel="Super intelligent" },
				new StudentEntity { Id = 3, Age = 30, fName = "Sara", lName = "Mohamed", Department = DeptStatus.SD , Email = "Sara@gmail.com",IQLevel="Super intelligent"},
				new StudentEntity { Id = 4, Age = 28, fName = "Fatima", lName = "Hassan", Department = DeptStatus.Wireless,Email="Fatima@gmail.com",IQLevel="Super intelligent" },
				new StudentEntity { Id = 5, Age = 26, fName = "Khaled", lName = "Ahmed", Department = DeptStatus.CloudComputing,Email="Khaled@gmail.com",IQLevel="Super intelligent" },
				new StudentEntity { Id = 6, Age = 29, fName = "Laila", lName = "Omar", Department = DeptStatus.UI ,Email="Laila@gmail.com",IQLevel="Super intelligent"},
				new StudentEntity { Id = 7, Age = 24, fName = "Youssef", lName = "Kareem", Department = DeptStatus.UI ,Email="Youssef@gmail.com",IQLevel="Super intelligent"},
				new StudentEntity { Id = 8, Age = 31, fName = "Nour", lName = "Ahmed", Department = DeptStatus.SD ,Email="Nour@gmail.com",IQLevel="Super intelligent"},
				new StudentEntity { Id = 9, Age = 27, fName = "Ali", lName = "Sara", Department = DeptStatus.CloudComputing,Email="Ali@gmail.com",IQLevel="Super intelligent" },
				new StudentEntity { Id = 10, Age = 32, fName = "Hala", lName = "Mohamed", Department = DeptStatus.Wireless,Email="Hala@gmail.com" ,IQLevel="Super intelligent"}
			};
		
		#endregion
		public DbSet<StudentEntity> students => Set<StudentEntity>();

		public StudentContext(DbContextOptions options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<StudentEntity>().HasData(_student);
		}
	}
}
