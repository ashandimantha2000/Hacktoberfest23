using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMedia_technical_assessment
{
    public class MyDataModel
    {
        public string fullName;
        public string address;
        public string contactNumber;
        public string gender;
        public DateTime birthday;
        public string membershipType;
        public double membershipValue;
        public string nameWithInitials;
        public string reversedAddress;
        public bool isMobileNumber;
        public string internationalContactNumber;
        public int calculatedAge;
        public double finalAmount;

       
        
        public MyDataModel(string fullName, string address, string contactNumber, string gender, DateTime birthday, string membershipType)
        {

            


            this.fullName = fullName;
            this.address = address;
            this.contactNumber = contactNumber;
            this.gender = gender;
            this.birthday = birthday;
            this.membershipType = membershipType;


            //update membershipValue acoding to the membership type

            if (membershipType == "VIP")
            {
                membershipValue = 5000;
            }
            else if (membershipType == "Gold")
            {
                membershipValue = 3500;
            }
            else
            {
                membershipValue = 2000;
            }



            this.nameWithInitials = GetInitialsFromFullName(fullName);
            this.reversedAddress = GetReversedAddress(address);
            this.isMobileNumber = CheckIfMobileNumber(contactNumber);
            this.internationalContactNumber = ConvertToInternationalFormat(contactNumber);
            this.calculatedAge = CalculateAge(birthday);
            this.finalAmount = CalculateFinalAmount(membershipType, membershipValue);
        }

        private string GetInitialsFromFullName(string fullName)
        {
            string[] nameParts = fullName.Split(' ');
            string initials = "";

            for (int i = 0; i < nameParts.Length - 1; i++)
            {
                initials += nameParts[i][0] + ". ";
            }

            initials += nameParts[nameParts.Length - 1]; // Append the last part without modification

            initials = initials.Trim();
            return initials;
        }


        private string GetReversedAddress(string address)
        {
            string[] addressParts = address.Split(',');
            Array.Reverse(addressParts);
            string reversedAddress = string.Join(", ", addressParts);

            return reversedAddress;
        }

        private bool CheckIfMobileNumber(string contactNumber)
        {
            // Assuming mobile numbers start with "07" or "+94" and have a length of 10 digits
            return contactNumber.StartsWith("07") || contactNumber.StartsWith("+94") && contactNumber.Length == 10;
        }

        private string ConvertToInternationalFormat(string contactNumber)
        {
            // Assuming the contactNumber is in local format (e.g., 0777597899)
            string internationalContactNumber = "+94" + contactNumber.Substring(1);
            return internationalContactNumber;
        }

        private int CalculateAge(DateTime birthday)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthday.Year;

            if (currentDate.Month < birthday.Month || (currentDate.Month == birthday.Month && currentDate.Day < birthday.Day))
            {
                age--;
            }

            return age;
        }

        private double CalculateFinalAmount(string membershipType, double membershipValue)
        {
            

            double taxRate = 0.12; // 12% tax rate per annum
            double taxAmount = membershipValue * taxRate;
            double finalAmount = membershipValue + taxAmount;

            return finalAmount;
        }

        //to check the data is coreectly comming to the dataModel
        public void DisplayData()
        {
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Name with Initials: " + nameWithInitials);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Reversed Address: " + reversedAddress);
            Console.WriteLine("Contact Number (Local format): " + contactNumber);
            Console.WriteLine("Contact Number (International format): " + internationalContactNumber);
            Console.WriteLine("Contact Number Type: " + (isMobileNumber ? "Mobile Number" : "Landline"));
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Birthday: " + birthday.ToShortDateString());
            Console.WriteLine("Age: " + calculatedAge + " years");
            Console.WriteLine("Membership Type: " + membershipType);
            Console.WriteLine("Membership Value before tax: " + membershipValue);
            Console.WriteLine("Final Amount after calculation of tax: " + finalAmount);
        }
    }
}
