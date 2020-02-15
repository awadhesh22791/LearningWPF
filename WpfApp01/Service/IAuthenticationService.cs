using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp01.Service
{
    interface IAuthenticationService
    {
        bool ValidateUser(string username, string password);
    }
}
