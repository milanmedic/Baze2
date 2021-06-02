using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class DeleteAccess
    {
        private ReadAccess read;
        public DeleteAccess()
        {
            read = new ReadAccess();
        }
    }
}
