using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask_02
{
    public abstract class User
    {
        public string Name { get; set; }    
        public int salary;
        public int fees;
        public int Salary
        {

            get
            {
                if (salary < 0)
                    return 0;

                else return salary;
            }

            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else { throw new Exception("Salary cannot be negative."); }
            }
        }

        public int Fees
        {

            get
            {
                if (fees < 0)
                    return 0;

                else return fees;
            }

            set
            {
                if (value >= 0)
                {
                    fees = value;
                }
                else { throw new Exception("Fees cannot be negative."); }
            }
        }
    }
}
