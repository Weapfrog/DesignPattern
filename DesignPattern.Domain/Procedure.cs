using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Domain
{
    public class Procedure
    {
        public int GradeID { get; set; }
        public string StudentName { get; set; }
        public string LectureName { get; set; }
        public Nullable<int> Grade1 { get; set; }
        public Nullable<int> Grade2 { get; set; }
        public Nullable<int> Average { get; set; }
        public Nullable<bool> StudentState { get; set; }
    }
}
