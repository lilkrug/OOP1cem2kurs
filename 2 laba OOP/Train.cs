using System;
using System.Collections.Generic;
using System.Text;

namespace _2_лаба_ООПc
{
    public partial class Train
    {
        public override Boolean Equals(Object obj)
        {
            if (obj == null) { return false; }
            if (this.GetType() != obj.GetType()) { return false; }
            return true;
        }
        
    }
}

