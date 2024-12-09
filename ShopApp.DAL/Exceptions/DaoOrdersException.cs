using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Exceptions
{
    public class DaoOrdersException : Exception
    {
        public DaoOrdersException(string message) : base(message) 
        {
        
        }
    }
}
