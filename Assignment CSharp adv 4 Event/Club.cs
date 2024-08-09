using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_adv_4_Event
{
    internal class Club
    {


       
            public int ClubID { get; set; }
            public string ClubName { get; set; }
            private List<Employee> Members = new List<Employee>();

            public void AddMember(Employee e)
            {
                Members.Add(e);
                e.EmployeeLayOff += RemoveMember;
            }

            private void RemoveMember(object sender, EmployeeLayOffEventArgs e)
            {
                if (sender is Employee employee && e.Cause == LayOffCause.VacationStockBelowZero)
                {
                    Members.Remove(employee);
                }
            }
        

    }
}
