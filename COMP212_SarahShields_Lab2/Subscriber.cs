using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_SarahShields_Lab2
{
    public class Subscriber
    {
        public string Email { get; set; }
        public string CellPhone { get; set; }

        public Subscriber(string email = null, string cellPhone = null)
        {
            Email = email;
            CellPhone = cellPhone;
        }
    }
}
