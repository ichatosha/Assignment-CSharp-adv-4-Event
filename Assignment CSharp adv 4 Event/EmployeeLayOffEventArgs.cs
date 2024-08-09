using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_adv_4_Event
{

    enum LayOffCause
    {
        VacationStockBelowZero,
        AgeAboveSixty,
        FailedToAchieveSalesTarget,
        Resigned
    }

    internal class EmployeeLayOffEventArgs: EventArgs
    {
        
        
            public LayOffCause Cause { get; set; }
        

    }
}
