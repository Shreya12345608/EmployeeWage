using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            EmployeeAttendance employeeAttendance = new EmployeeAttendance();
            employeeAttendance.EmpAtt();

            //UC2
            DailyWage dailyWage = new DailyWage();
            dailyWage.DailyWag();
        }
    }
}
