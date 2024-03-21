using Microsoft.EntityFrameworkCore;
using Student.DAL.Data.Context;
using Student.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Student.DAL.Repo.Student
{
	public class StudentRepository : IStudentRepo
	{
		private readonly StudentContext _context;
		public StudentRepository(StudentContext context)
		{
			_context = context;
		}


		public IEnumerable<StudentEntity> GetAll()
		{
			return _context.Set<StudentEntity>().AsNoTracking();
		}

		public StudentEntity? GetById(int id)
		{
			return _context.Set<StudentEntity>().Find(id);
		}

		public void Add(StudentEntity entity)
		{
			_context.Set<StudentEntity>().Add(entity);
		}

		public void Delete(StudentEntity entity)
		{
			_context.Set<StudentEntity>().Remove(entity);
		}

		public void SaveChanges()
		{
            _context.SaveChanges();
        }

		public void Update(StudentEntity entity)
		{
			_context.Set<StudentEntity>().Update(entity);
		}
	}
}
