using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Registration_DezhiDing.PrintRegistration;

namespace Registration_DezhiDing
{
    public partial class frmRegistration : Form
    {

        Registration registration = new Registration();

        public frmRegistration()
        {
            InitializeComponent();
        }

        internal Registration Registration { get => registration; set => registration = value; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Validate failure!", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }


            try
            {
                // Assign the value from frmRegistration
                registration.FirstName = tbxFirstName.Text;
                registration.LastName = tbxLastName.Text;
                registration.Email = tbxEmail.Text;
                registration.Address = tbxAddress.Text;
                registration.City = tbxCity.Text;
                registration.PostCode = tbxPostalCode.Text;
                registration.Country = tbxCountry.Text;
                registration.Phone = tbxPhone.Text;

                // PrintRegistration prg = new PrintRegistration();
                printRegistration prgToFile = new printRegistration(PrintToFile);
                printRegistration prgToScreen = new printRegistration(PrintToScreen);
                printRegistration prg = prgToFile + prgToScreen;
                prg(registration);


                //empty the form
                EmptyForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid data: " + ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EmptyForm();

        }

        //empty the form
        private void EmptyForm()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>().ToArray())
            {
                tb.Clear();
            }
        }


        //Validating postal Code by a Regex expression 
        private void postalCode_Validating(object sender, CancelEventArgs e)
        {
            bool FoundMatch = false;

            if (!string.IsNullOrEmpty(tbxPostalCode.Text))
            {
                try
                {
                    FoundMatch = Regex.IsMatch(tbxPostalCode.Text, "\\A[ABCEGHJKLMNPRSTVXY]\\d[A-Z] ?\\d[A-Z]\\d\\z");
                    if (!FoundMatch)
                    {
                        MessageBox.Show("The value you entered is not correct. Please enter data again!");
                        this.tbxPostalCode.Focus();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Regex expression is not correct!");
                    throw ex;
                }
            }

        }


        //Validating Phone number by a Regex expression 
        private void phone_Validating(object sender, CancelEventArgs e)
        {
            bool FoundMatch = false;

            if (!string.IsNullOrEmpty(tbxPhone.Text))
            {
                try
                {
                    var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
                    FoundMatch = r.IsMatch(tbxPhone.Text);
                    if (!FoundMatch)
                    {
                        MessageBox.Show("The value you entered is not correct. Please enter data again!");
                        this.tbxPhone.Focus();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Regex expression is not correct!");
                    throw ex;
                }
 
            }

        }

        //validating the mandatory field 
        private void isEmptyOrNull_Validating(object sender, CancelEventArgs e)
        {
            
            TextBox tbx = (TextBox)sender;

            if (string.IsNullOrEmpty(tbx.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter data!");
                tbx.Focus();
            }
 
        }
    }
}
