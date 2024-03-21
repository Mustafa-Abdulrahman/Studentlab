using Student.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Student.DAL.Repo.Student
{
    public interface IStudentRepo
    {
        IEnumerable<StudentEntity> GetAll();
        StudentEntity? GetById(int id);
        void Add(StudentEntity entity);
        void Update(StudentEntity entity);
        void Delete(StudentEntity entity);
       
        void SaveChanges();
    }
}
