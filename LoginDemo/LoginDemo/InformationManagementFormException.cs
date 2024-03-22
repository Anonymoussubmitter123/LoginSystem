using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    class InformationManagementFormException:Exception
    {
        public InformationManagementFormException(string message) : base(message)
        {

        }
    }
}
