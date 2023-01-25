using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace creatclasslab1
{
    internal class Program
    {
        public double totalAge = 0;
        public double counter = 0;
        public double averageAge = 0;
        public double oldestAge = 0;
        public double youngestAge = 999;
        public string youngestPerson = "";
        public string oldestPerson = "";

        public void AverageAge(double age)
        {
            this.totalAge = this.totalAge + age;
            this.counter = this.counter + 1;
            this.averageAge = this.totalAge / this.counter;
        }
        static void Main(string[] args)
        {
            

            Person giNa;
            giNa = new Person(2,"Gina","James","Green",18,false);
            giNa.DisplayPersonInfo();
            double ginaAge = giNa.Age;
            string ginaName = giNa.FirstName;
            Program averageAge = new Program();
            averageAge.AverageAge(ginaAge);

            if (ginaAge <= averageAge.youngestAge)
            {
                averageAge.youngestAge = ginaAge;
                averageAge.youngestPerson = ginaName;
            }

            if (ginaAge>= averageAge.oldestAge)
            {
                averageAge.oldestAge=ginaAge;
                averageAge.oldestPerson = ginaName;
            }


            Person miKe;
            miKe = new Person(3,"Mike","Briscoe","Blue",45,true);
            Console.WriteLine(miKe); 
            double mikeAge = miKe.Age;
            string mikeName = miKe.FirstName;
            averageAge.AverageAge(mikeAge);
            if (mikeAge <= averageAge.youngestAge)
            {
                averageAge.youngestAge = mikeAge;
                averageAge.youngestPerson = mikeName;
            }

            if (mikeAge >= averageAge.oldestAge)
            {
                averageAge.oldestAge = mikeAge;
                averageAge.oldestPerson = mikeName;
            }

            Person iAn;
            iAn = new Person(1,"Ian","Brooks","Red",30,true);
            iAn.ChangeFavoriteColour();
            iAn.DisplayPersonInfo();
            double ianAge = iAn.Age;
            string ianName = iAn.FirstName;
            averageAge.AverageAge(ianAge);
            if (ianAge <= averageAge.youngestAge)
            {
                averageAge.youngestAge = ianAge;
                averageAge.youngestPerson = ianName;
            }

            if (ianAge >= averageAge.oldestAge)
            {
                averageAge.oldestAge = ianAge;
                averageAge.oldestPerson = ianName;
            }

            Person maRy;
            maRy = new Person(4,"Mary","Beals","Yellow",28,true);
            maRy.AgeInTenYears();
            double maryAge = maRy.Age;
            string maryName = maRy.FirstName;
            averageAge.AverageAge(maryAge);
            if (maryAge <= averageAge.youngestAge)
            {
                averageAge.youngestAge = maryAge;
                averageAge.youngestPerson = maryName;
            }

            if (maryAge >= averageAge.oldestAge)
            {
                averageAge.oldestAge = maryAge;
                averageAge.oldestPerson = maryName;
            }

            string averageAgeMessage = string.Format("The average age is {0}",averageAge.averageAge);
            Console.WriteLine(averageAgeMessage);

            string youngestMessage = string.Format("The youngest person is {0}", averageAge.youngestPerson);
            Console.WriteLine(youngestMessage);

            string oldestMessage = string.Format("The oldest person is {0}", averageAge.oldestPerson);
            Console.WriteLine(oldestMessage);
        }
    }
}
