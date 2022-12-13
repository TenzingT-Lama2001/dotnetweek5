using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Week5
    class EmployeesModel
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string name { get; set; }
        public string email { get; set; }
        public long phone { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string position { get; set; }
        public int salary { get; set; }
        public string education { get; set; }
        public string department { get; set; }

    }
}
