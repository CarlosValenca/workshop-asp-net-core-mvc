using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        // ssbcvp - erros de integridade referencial de banco serão tratados aqui
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
