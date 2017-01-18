using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApplicationJohnPietrangelo
{
    static class CustomerAppStart
    {
        //Creates a class variable to hold "parent" window's memory address.
        private static Form myParentForm = null;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerAppStartForm());
        }

                        //Class Methods go here.

        // To "set" parent form memory address.
        public static void SetParentForm(Form parentForm)
        {
            myParentForm = parentForm;
        }
                            //  End of method.

        // To "Get" the parent form's memory location(address).
        public static Form GetParentForm()
        {
            return myParentForm;
        }
                            //  End of method.
    }
}
