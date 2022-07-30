using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EmptySeparatorException : ArgumentNullException
    {
        public EmptySeparatorException()
            : base("separator_is_empty")
        {
        }
    }
}
