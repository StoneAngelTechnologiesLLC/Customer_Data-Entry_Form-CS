//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApplicationJohnPietrangelo
{
    internal class Customer
    {
        // Class variables go here.
        private static int numberOfCustomersAdded = 0;
        

        // Class property readonly.
        public static int NumberOfCustomerAdded
        {
            get
            {
                return numberOfCustomersAdded;
            }
        }
        
        // Instance variables go here.
        private int zip;
       

        // Instance variables go here.
        public bool valid = false; 
        public string customerName{ get; set; }
        public string customerAddress { get; set; }
        
        public string customerZip{
            get
            {
                return zip.ToString();
            }
            set
            {
                //Validate the string is a 5 digit zip code 
                //Add code Here before assignment below 
                valid = VerifyZipCodeValue(value, out zip);
            }
        }
        //Default Constructor Method. 
        public Customer()
        {
            numberOfCustomersAdded++;
        }
        //end of Customer Constructor method
        public Customer(string inName, string inAddr, string inZip)
        {
            //New customer is added so increment counter. 
            numberOfCustomersAdded++;
            
            //Assign customer data 
            customerName = inName;
            customerAddress = inAddr;
            customerZip = inZip;
            
        }//end of Customer Constructor method

        public static bool VerifyZipCodeValue(string valueGiven, out int valueTaken)
        {
            int validNumCount = 0;
            bool valid = false;
            valueTaken = 0;
            if (valueGiven.Length <= 5)
            {
                for (int i = 0; i < valueGiven.Length; i++)
                {
                    if (char.IsNumber(valueGiven[i]))
                        ++validNumCount;
                }
                if (validNumCount == valueGiven.Length)
                {
                    valueTaken = Convert.ToInt32(valueGiven);
                    valid = true;
                }
            }
            return valid;
        }
    }// End of Class Definition.
}// End of Namespace Definition.
