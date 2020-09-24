using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnummerCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Deklarerar en variabel som senare används för att presentera resulatet
            string outputString;
            //Döljer felmeddelande om användaren tidigare skulle fått detta
            lblError.Visible = false;
            //Ta emot inmatning från användare och skapar en
            //instans av klassen Person baserat på detta
            Person person = RetrieveUserInput();

            //Om person-instansen har skapats upp korrekt  
            //är ok visa textruta med text.
            if(person != null)
            {
                outputString = "Förnamn: " + person.FirstName + "\n" +
                    "Efternamn: " + person.FamilyName + "\n" +
                    "Personnummer: " + person.PersonalNumber + "\n" +
                    "Kön: " + person.Gender;
                lblOutput.Text = outputString;
                //textrutan görs synlig först när det finns ett resultat att visa
                lblOutput.Visible = true;
            }


        }

        private Person RetrieveUserInput()
        {
            //Metoden tar emot inmatning från användare
            //om inmatningen är ok returneras ett person-objekt
            //om något är fel med inmatningen returneras null
            
            string firstName;
            string familyName;
            string personalNumber;
            
            //variabel för att senare hålla potentiellt personnummerfel
            string personalNumberError;

            //skapar en instans av felhanteringsklassen där felhantering görs
            ErrorHandling error = new ErrorHandling();

            //hämta förnamn, efternamn och personnummer från textboxar
            firstName = tbxFirstName.Text;
            familyName = tbxFamilyName.Text;
            personalNumber = tbxPersonalNumber.Text;

            //Om något av fälten är tomma, ska användaren hänvisas till att 
            //fylla i detta fält. Metoden returnerar i s f ett null-värde
            if (firstName == "")
            {
                error.BlankField(lblError, tbxFirstName, "Förnamn");
                return null;
            }
            if (familyName == "")
            {
                error.BlankField(lblError, tbxFamilyName, "Efternamn");
                return null;
            }
            if (personalNumber == "")
            {
                error.BlankField(lblError, tbxPersonalNumber, "Personnummer");
                return null;
            }

            //felhanteringsklassen genomför ett antal personnummer checkar
            //vid något fel returneras det första påträffade felmeddelandet.
            personalNumberError = error.PersonalNumberCheck(personalNumber);

            //om ett personnummerfel påträffats visas ett felmeddelande till användaren
            //och ett null-värde returneras
            if (personalNumberError != "")
            {
                lblError.Text = personalNumberError;
                lblError.Visible = true;
                return null;
            }

            //om inget fel har påträffats skapas ett person-objekt upp och returneras
            Person person = new Person(firstName, familyName, personalNumber);
            return person;
        }

        //när någon av textboxarna ändras döljs tidigare resultat
        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Visible = false;
        }

        private void tbxFamilyName_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Visible = false;
        }

        private void tbxPersonalNumber_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Visible = false;
        }

        private void tbxPersonalNumber_OnFocus(object sender, EventArgs e)
        {
            //Tar bort placeholder-texten när focus sätts på textboxen
            if (tbxPersonalNumber.Text == "YYYYMMDDXXXX")
            {
                tbxPersonalNumber.Text = "";
            }

        }

        private void tbxPersonalNumber_DeFocus(object sender, EventArgs e)
        {
            //Sätter tillbaka placeholdertexten om användaren lämnar fältet oifyllt
            if (tbxPersonalNumber.Text == "")
            {
                tbxPersonalNumber.Text = "YYYYMMDDXXXX";
            }
        }
    }
}
