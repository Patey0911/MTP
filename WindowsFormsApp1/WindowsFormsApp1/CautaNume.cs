﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CautaNume:IComparer<Student>
    { 
        public int Compare(Student x, Student y)
        {
            return string.Compare(x.NumeStudent, y.NumeStudent);
        }
    }
}
