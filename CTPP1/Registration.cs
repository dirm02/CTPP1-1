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
    public partial class Registration : Form
    {
 List<Registration> people = new List<Registration>();
        public Registration()
        {
            InitializeComponent();
        }
       
        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            RegistrationModel p = new RegistrationModel();

            p.UserName = TUserName.Text;
            p.FirstName = FnameText.Text;
            p.LastName = NameText.Text;
            p.Email = EmailText.Text;
            p.Signature = SignatureText.Text;
            

            RegDBaccess.SavePerson(p);

            TUserName.Text = "";
            FnameText.Text = "";
            NameText.Text = "";
            EmailText.Text = "";
            SignatureText.Text = "";
        }
    }
}
