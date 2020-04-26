﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                  new Employee
                  {
                      Id = 1,
                      Name = "Mary",
                      Department = Dept.IT,
                      Email = "asdasdasd@martin.com"
                  },
                   new Employee
                   {
                       Id = 2,
                       Name = "john",
                       Department = Dept.Hr,
                       Email = "johnd@martin.com"
                   }
              );
        }
    }
}
