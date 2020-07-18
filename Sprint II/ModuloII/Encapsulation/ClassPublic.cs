using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class ClassPublic
    {
        public int MinhaPropPublica { get; set; }
        public int MinhaPropPrivate { get; set; }
        protected int MinhaPropProtected { get; set; }
        internal int MinhaPropInternal { get; set; }
        protected internal int MinhaPropProtectedInternal { get; set; }
        private protected int MinhaPropPrivateProtected { get; set; }
    }
}
    
