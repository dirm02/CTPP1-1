using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTPP1
{
    public class RegistrationModel  
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Signature { get; set; }

        public string Registration
        {
            get
            {
                return $"{UserName} {FirstName} {LastName} {Email} {Signature}";
            }
        }
    }
}
