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

namespace PayMedia_technical_assessment
{
    public partial class Screen1 : Form
    {
        public Screen1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Set Handled property to true to prevent the character from being entered
                e.Handled = true;
            }

            // Check if the total length of the textbox's text, including the newly entered character, will exceed 10
            if (phoneNumber.Text.Length >= 10 && e.KeyChar != '\b')
            {
                // Set Handled property to true to prevent the character from being entered
                e.Handled = true;
            }
        }
        private bool ValidateSriLankaMobileNumber(string number)
        {
            // Regular expression pattern for Sri Lanka mobile numbers
            string pattern = @"^(?:(?:\+?94|0)1|07)(?:\d{8})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(number);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            // Retrieve input values from UI controls
            string fullName = name.Text;
            string address = addressinput.Text;
            string contactNumber = phoneNumber.Text;
            string gender = Gender.SelectedItem?.ToString();
            DateTime birthday = dateTimePicker.Value;
            string membershipType = memberType.SelectedItem?.ToString();

            // Validate input values
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter a valid full name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter a valid address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show("Please enter a valid contact number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateSriLankaMobileNumber(contactNumber))
            {
                MessageBox.Show("Please enter a valid Sri Lanka mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select a valid gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(membershipType))
            {
                MessageBox.Show("Please select a valid membership type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create an instance of MyDataModel and pass the input values to its constructor
            MyDataModel dataModel = new MyDataModel(fullName, address, contactNumber, gender, birthday, membershipType);

            dataModel.DisplayData();
            Screen2 screen2 = new Screen2(dataModel);

            // Show Screen2
            screen2.Show();

            // Hide Screen1 
            this.Hide();
        }
    }
}
