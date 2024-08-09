using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharp_adv_4_Event
{
    internal class Department
    {

       
            public int DeptID { get; set; }
            public string DeptName { get; set; }
            private List<Employee> Staff = new List<Employee>();

            public void AddStaff(Employee e)
            {
                Staff.Add(e);
                e.EmployeeLayOff += RemoveStaff;
            }

            private void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
            {
                if (sender is Employee employee && (e.Cause == LayOffCause.VacationStockBelowZero || e.Cause == LayOffCause.AgeAboveSixty))
                {
                    Staff.Remove(employee);
                }
            }
        

    }
}
