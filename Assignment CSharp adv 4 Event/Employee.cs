using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_adv_4_Event
{
    internal class Employee
    {       // Event action
            public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

            public int EmployeeID { get; set; }
            public DateTime BirthDate { get; set; }
            public int VacationStock { get; set; }

            protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
            {   // to run the event :  
                EmployeeLayOff?.Invoke(this, e);
            }


            // VacationStockBelowZero
            public bool RequestVacation(DateTime from, DateTime to)
            {
                // Implement vacation request logic
                // Decrement vacation stock if approved
                // Trigger layoff event if VacationStock < 0
                if (VacationStock < 0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockBelowZero });
                    return false;
                }
                return true;
            }


            //AgeAboveSixty
            public void EndOfYearOperation()
            {
                 // Check age and trigger layoff if Age > 60
                 if ((DateTime.Now.Year - BirthDate.Year) > 60)
                 {
                     OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeAboveSixty });
                 }
            }
    }
}
