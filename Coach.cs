using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ASM_2
{
    public class Coach : Information
    {
        private int coachID;
        private string cname;
        private int experience;
        private decimal salary;
        public int CoachID
        {
            get => coachID;
            set => coachID = value;
        }
        public string Cname
        {
            get => cname;
            set => cname = value;
        }
        public int Experience
        {
            get => experience;
            set => experience = value;
        }
        public virtual decimal Salary
        {
            get => salary;
            set => salary = value;
        }
        public Coach(int coachID, string cname, int experience,decimal salary)
        {
            Salary = salary;
            CoachID = coachID;
            Cname = cname;
            Experience = experience;
        }

        public Coach()
        {
        }
        public void InputCoach()
        {
            Console.Write("Input coach name: ");
            Cname = Console.ReadLine();
            Console.Write("Input ID: ");
            CoachID = int.Parse(Console.ReadLine());
            Console.Write("Input year of Experience: ");
            Experience = int.Parse(Console.ReadLine());
            Console.Write("Input Salary: ");
            Salary = int.Parse(Console.ReadLine());
        }
        public void ShowInformation()
        {

            Console.WriteLine(GetType());
            Console.WriteLine("- Coach name: {0} | ID: {1} | Experience: {2} | Salary: {3}$", Cname,CoachID,Experience,Salary);
            Console.WriteLine("----------------------------------------");
        }

    }
}

