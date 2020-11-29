using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister {
    class NotValidItemException : Exception{
        public NotValidItemException() {
            Console.WriteLine("Invalid item specified");
        }
        public NotValidItemException(String message) : base(message) {
            Console.WriteLine("Invalid item specified for: " + message);
        }

    }
}
