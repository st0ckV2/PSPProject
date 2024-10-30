using PSPProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPProject.Data
{
    public class DataContext:DbContext
    {
        DbSet<Employee> Employees { set; get; }

        public DataContext():base("name=con")
        {
            
        }
    }
}
