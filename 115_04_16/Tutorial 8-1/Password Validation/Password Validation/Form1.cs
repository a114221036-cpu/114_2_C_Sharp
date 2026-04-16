using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (char.IsLower(item))
                {
                    count++;
                }
               
            }
            return count;
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }
            }
            return count;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MINIMUM_LENGTH = 8; // Minimum password length
            string password = passwordTextBox.Text;
            if (password.Length < MINIMUM_LENGTH)
            {
                MessageBox.Show("密碼必須至少須為 8 個字元");
                return;
            }
            else
            {

                int upperCaseCount = NumberUpperCase(password);
                int lowerCaseCount = NumberLowerCase(password);
                int digitCount = NumberDigits(password);
                if (upperCaseCount < 1)
                {
                    MessageBox.Show("密碼必須至少須為 一個大寫字母");
                    return;
                }
                else if (NumberLowerCase(password) < 1)
                {
                    MessageBox.Show("密碼必須至少須為 一個小寫字母");
                    return;
                }
                else if (NumberDigits(password) < 1)
                {
                    MessageBox.Show("密碼必須至少須為 一個數字");
                    return;
                }
                else
                {
                    MessageBox.Show("密碼有效");
                 
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
