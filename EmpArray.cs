using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticEmployeewangProg
{
      public class EmpArray
        {
            public string Company;
            public int wagePerHour;
            public int maxdays;
            public int maxhours;
            public int Monthwork;

            public EmpArray(string Company, int wagePerHour, int maxdays, int maxhours)
            {
                this.Company = Company;
                this.wagePerHour = wagePerHour;
                this.maxdays = maxdays;
                this.maxhours = maxhours;
            }
            public void setEmpWage(int Monthwork)
            {
                this.Monthwork = Monthwork;
            }
            public string toString()
            {
                return "the company : " + this.Company + " total work is :  " + this.Monthwork;
            }
        }
    
}

