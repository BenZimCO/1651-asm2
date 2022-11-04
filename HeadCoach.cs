using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASM_2
{
   public class HeadCoach: Coach
    {
        public HeadCoach(int coachID, string cname, int experience, decimal salary) : base(coachID, cname, experience,salary)
        {
          
        }
        public override decimal Salary { get => base.Salary * 3; set => base.Salary = value; }

        public HeadCoach()
        {
        }      
    }
}
