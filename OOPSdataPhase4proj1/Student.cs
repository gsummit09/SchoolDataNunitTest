using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Student
    {
        public virtual int StudentId { get; set; }
        public virtual string? StudentName { get; set; }
        public virtual string? Class { get; set; }
    }
}
