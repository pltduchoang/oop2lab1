using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatclasslab1
{
    internal class Person
    {
        #region constant
        private int personId;
        private string firstName;
        private string lastName;
        private string favouriteColour;
        private int age;
        private bool isWorking;
        #endregion

        #region constructor
        public Person(int personId, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favouriteColour = favouriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }
        #endregion

        #region methods

        public double Age { get { return age; } set { } }
        public string FirstName { get { return firstName;} set { } }
        
        public void DisplayPersonInfo ()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            int personId = this.personId;
            string favouriteColour = this.favouriteColour;


            string display = string.Format("{0}: {1} {2}'s favourite colour is {3}", personId, firstName, lastName, favouriteColour);

            Console.WriteLine(display);
        }

        public void ChangeFavoriteColour()
        {
            this.favouriteColour = "White";
        }

        public void AgeInTenYears()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            int newAge = this.age + 10;
            string display = string.Format("{0} {1}'s Age in 10 years is: {2}", firstName, lastName, newAge);

            Console.WriteLine(display);
        }

        public override string ToString()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            int personId = this.personId;
            string favouriteColour = this.favouriteColour;
            int age = this.age;
            bool isWorking = this.isWorking;


            string display = string.Format("PersonID: {0}\nFirstName: {1}\nLastName: {2}\nFavoriteColour: {3}\nAge {4}\nIsWorking: {5}", personId, firstName, lastName, favouriteColour, age, isWorking);

            return display;
        }
        #endregion
    }
}
