﻿using SchoolManagment.Data.Entities;
using SchoolProject.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Abstracts
{   
    public interface IStudentRepository :IGenericRepository<Student>   
    {
      public Task<IEnumerable<Student>> GetStudentsAsync();



    }
}