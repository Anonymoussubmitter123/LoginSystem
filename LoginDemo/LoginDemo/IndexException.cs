using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    class IndexException:Exception
    {
        public IndexException(string message): base(message)
        {

        }
    }
}
