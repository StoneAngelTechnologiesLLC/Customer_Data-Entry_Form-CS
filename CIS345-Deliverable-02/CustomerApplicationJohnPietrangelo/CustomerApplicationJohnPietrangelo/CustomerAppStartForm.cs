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
    public partial class CustomerAppStartForm : Form
    {
     List<Customer> customers = new List<Customer>();

        // Class Defualt Constructor
        public CustomerAppStartForm()
        {
            InitializeComponent();
            // To set the "Parent" form for this app.
            CustomerAppStart.SetParentForm(this);
        }

        //addCustomerBtn_Click() method
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            //  Creates a new add customer form
            AddCustomerForm myAddCustomerForm = new AddCustomerForm(customers);
            // To Display "Add Customer" Form
            myAddCustomerForm.Show();
            this.Hide();
        }//end of addCustomerBtn_Click() method
        
        //exitBtn_Click method 
        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }// end of exitBtn_Click method

        private void listAllCustomerBtn_Click(object sender, EventArgs e)
        { //Create a new ListAllCustomersForm
            ListAllCustomersForm myListAllCustomerForms = new ListAllCustomersForm(customers);
            //display the ListAllCustomersForm
            myListAllCustomerForms.Show();
            //hide this form  
            this.Hide(); 
        }//end of listAllCustomerBtn_Click
    }//end of class
}//
