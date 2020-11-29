using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister {

    // Custom exception for if we have an item confliction
    class NotValidItemException : Exception{
        public NotValidItemException() {
            Console.WriteLine("Invalid item specified");
        }
        public NotValidItemException(String message) : base(message) {
            Console.WriteLine("Invalid item specified for: " + message);
        }

    }
}
