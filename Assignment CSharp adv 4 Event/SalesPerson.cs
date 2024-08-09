using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_adv_4_Event
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

            public bool CheckTarget(int Quota)
            {
                if (AchievedTarget < Quota)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FailedToAchieveSalesTarget });
                    return false;
                }
                return true;
            }
    }

        

    
}
