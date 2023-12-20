/***************************************************************
* Name         : FinalProjectKapic
* Author       : Arnes Kapic
* Created      : 07/17/2023
* Course       : CIS 169 - C# 30501
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is the Final Project.
*                      Input : Name, ID, Hourly Rate, and Hours Worked 
*                      Output: WeeklySalary 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
using System;

namespace FinalProject.Models
{
    public class StudentWorkerModel
    {
        // Name, ID, HourlyPay, Hours Worked, and AmtPaid being created
        public string Name { get; set; }

        public int ID { get; set; }

        public double HourlyPay { get; set; }

        public int HoursWorked { get; set; }

        public double AmtPaid { get; set; }

        // Method WeeklySalary() for mutliplying Hours and Pay
        public double WeeklySalary()
        {
            return HourlyPay * HoursWorked;
        }
    }
}
