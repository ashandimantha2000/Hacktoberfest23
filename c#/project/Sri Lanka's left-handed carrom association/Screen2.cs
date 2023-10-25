using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayMedia_technical_assessment
{

    public partial class Screen2 : Form
    {
        private MyDataModel dataModel;

        public Screen2(MyDataModel dataModel)
        {
            InitializeComponent();
            this.dataModel = dataModel;
            DisplayData();
        }
        private void DisplayData()
        {
            name.Text = dataModel.fullName;
            NamewithInitials.Text = dataModel.nameWithInitials;
            label7.Text = dataModel.address;
            label14.Text = dataModel.reversedAddress;
            label15.Text = dataModel.contactNumber;
            label16.Text = dataModel.internationalContactNumber;
            label17.Text = dataModel.isMobileNumber ? "Mobile Number" : "Landline";
            label18.Text = dataModel.gender;
            label19.Text = dataModel.birthday.ToShortDateString();
            label20.Text = dataModel.calculatedAge.ToString() + " years";
            label21.Text = dataModel.membershipType;
            label22.Text = dataModel.membershipValue.ToString();
            label23.Text = dataModel.finalAmount.ToString();
        }
       




            private void FullName_Click(object sender, EventArgs e)
        {
            


        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
