using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutiformVariable
{
    public partial class SecondForm1 : Form
    {
        private string uname;
        public SecondForm1(string name)
        {
            InitializeComponent();
            uname = name;
        }

        private void SecondForm1_Load(object sender, EventArgs e)
        {
            uname = "Steve Lee";
            label1.Text = uname;
        }
    }
}
