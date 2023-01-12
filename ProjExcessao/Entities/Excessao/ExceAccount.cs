using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExcessao.Entities.Excessao
{
    internal class ExceAccount : ApplicationException
    {
        public ExceAccount(string message) : base(message)
        {

        }
    }
}
