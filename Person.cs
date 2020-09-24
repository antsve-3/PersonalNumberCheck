using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnummerCheck
{
    class Person
    {
        //en person-klass som håller förnamn, efternamn, personnummer och som
        //baserat på personnummer räknar ut kön.
        private string firstName;
        private string familyName;
        private string personalNumber;
        private string gender;

        //konstruktor som tar in förnamn, efternamn och personnummer
        public Person(string firstName, string familyName, string personalNumber)
        {
            this.firstName = firstName;
            this.familyName = familyName;
            this.personalNumber = personalNumber;
            //kön räknas ut med hjälp av personnummer
            this.gender = determineGender(personalNumber);
        }

        //gör fälten tillgängliga så att de kan användas utanför klassen.
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string FamilyName
        {
            get
            {
                return familyName;
            }
        }
        public string PersonalNumber
        {
            get
            {
                return personalNumber;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
        }

        private string determineGender(string personalNumber)
        {
            //Metoden räknar ut personens kön med hjälp av personnumret
            string gender;

            //kontrollsiffran hämtas från personnumrets näst sista siffra
            string checkChar = personalNumber.Substring(10, 1);
            //konverterar till heltal
            int checkNum = Convert.ToInt32(checkChar);
            //kollar om kontrollsiffran är ett jämt eller ojämt nummer
            if(checkNum % 2 != 0)
            {
                gender = "Man";
            }
            else
            {
                gender = "Kvinna";
            }
            return gender;
        }
    }
}


