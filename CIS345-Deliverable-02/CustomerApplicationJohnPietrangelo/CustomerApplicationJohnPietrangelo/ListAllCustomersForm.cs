using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApplicationJohnPietrangelo
{
    public partial class ListAllCustomersForm : Form
    {   
        //defult constructor
        internal ListAllCustomersForm(List<Customer> customerList)
        {
            InitializeComponent();
            /* Since this is the firstmethod to be executed
             call the displayCustomers method to populate list*/
            displayCustomers(customerList);
        }//end of constructor

        //okBtn_Click method
        private void okBtn_Click(object sender, EventArgs e)
        {
            //retrieve hidden form's memory address
            Form myparentForm = CustomerAppStart.GetParentForm();
            //now that we have the address use it to display parentForm.
            myparentForm.Show();
            // Finally, To Close This Form.
            this.Close();
        }//end of ok_Click method
        //display the customers 
        internal void displayCustomers(List<Customer> list)
        {
            // To format the header in the text box 
            customerListTbx.Text = ""; //Clear the textbox 
            customerListTbx.AppendText("------------------------------------------------------------------------------------------ \r\n");
            customerListTbx.AppendText("Name\t\t      Address\t     Zip \r\n");
            customerListTbx.AppendText("------------------------------------------------------------------------------------------ \r\n\n");
            customerListTbx.AppendText("John Pietrangelo    Streets of Phoenix        85018\r\n");
            customerListTbx.AppendText("Vincent Snow         5050 Geary Blvd          94118\r\n");

            //loop thru the array and display all the data 
            foreach (Customer customer in list)
            {
                if (customer != null)
                {
                    this.customerListTbx.AppendText(string.Format("{0} {1} {2}\r\n",
                        customer.customerName.PadRight(20, ' '),
                        customer.customerAddress.PadRight(23, ' '),
                        customer.customerZip));
                }
            }
        }
    }

}
