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
    public partial class AddCustomerForm : Form
    {
        List<Customer> newCustomers;
        
        //Constructor
        internal AddCustomerForm(List<Customer> customers)
        {
            InitializeComponent();
            newCustomers = customers; 
        }//end of constructor 

        private void saveAndExitBtn_Click(object sender, EventArgs e)
        {
           
            // save the data first
            SaveNewCustomerInfo();
            // next retrieve hiddenn form's memory address.
            Form myParentForm = CustomerAppStart.GetParentForm();
            // To Display Parent (CustApp) Form.
            myParentForm.Show();
            // Finally, To Close This Form.
            this.Close();
        }
        //cancelBtn_Click 
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //retrieve hidden (CustApp) Form's memory.
            Form parentForm = CustomerAppStart.GetParentForm();
            // To Display Parent (CustApp) Form.
            parentForm.Show();
            // Finally, To Close This Form.
            this.Close();
        }//end of cancelBtn_Click
        
        
        //Save a new customer to List 
        private void SaveNewCustomerInfo()
        { //Calling Customer constructor increments customer count 
            Customer tempCustomerBuffer = new Customer(nameTxBx.Text, addressTxBx.Text, zipTxBx.Text);
            //Add new customer to list object 
            newCustomers.Add(tempCustomerBuffer);
        }//end save new customer
    }//end AddCustomerForm class
}
