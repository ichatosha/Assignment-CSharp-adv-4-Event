using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_adv_4_Event
{
    internal class BoredMember : Employee
    {
       
            public void Resign()
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
            }
        
    }
}
