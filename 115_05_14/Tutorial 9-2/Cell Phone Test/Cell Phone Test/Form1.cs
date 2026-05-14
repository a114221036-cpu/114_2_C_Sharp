using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                phone.Price = price; 
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
                phone.Price = 0; // Set to 0 if the input is invalid.
            }   
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
            CellPhone myPhone = new CellPhone();

            // Get data from the user and assign it to the CellPhone object.
            GetPhoneData(myPhone);

            // Display the data in the labels.
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
