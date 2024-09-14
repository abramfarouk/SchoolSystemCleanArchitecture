using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SchoolManagment.Data.Entities;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _students;

        public StudentRepository(ApplicationDbContext context) : base(context) {
            {
                _students = context.Set<Student>();
            }
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _students.Include(d => d.Department).ToListAsync();
        }


    }

}


