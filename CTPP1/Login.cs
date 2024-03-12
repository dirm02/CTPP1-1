using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTPP1
{
    public partial class Login : Form
    {
        private Registration newForm; // Declare a reference to the new form
        public Login()
        {
            InitializeComponent();
            newForm = new Registration(); // Initialize the new form instance
        }

        private void BReg_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (Form1)
            newForm.Show(); // Show the new form (Form2)
        }
    }
}
