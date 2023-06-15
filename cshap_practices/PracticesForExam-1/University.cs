using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesForExam_1;

internal abstract class University
{
    public string Name { get; set; }
    public int cost;

    public int StudentPayment
    { get { return TeacherPayment; } set { TeacherPayment = value; } }

    public int TeacherPayment
    {
        get
        {
            if(cost<0)
                return 0;
            else return cost;
        }
        set
        {
            if(value>=0)
            {
                cost = value;
            }
            else { throw new NotImplementedException("Payment cannot be negative!!!"); }
        }
    }
}
