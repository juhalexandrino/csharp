using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExceptions_03
{
    public class ExececaoSimples : Exception
    {
        public ExececaoSimples() { }
        public ExececaoSimples(string message) : base(message) { 
            Console.Error.WriteLine(message);
            Console.WriteLine("Exceção definifa pela pessoa desenvolvedora.");
        }
    }
    }
