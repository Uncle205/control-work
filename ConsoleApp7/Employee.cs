using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee
    {
        private const string name = "Oleg";
        private const int V = 13254;
        private string FirstName;
        public string firstname
        {
            get
            {
                return FirstName;
            }
            set
            {

            }
        }
        private int password;
        public int Password
        {
            get
            {
                return password;
            }
            set => password = V;
        }

        private  string Surname;
        public string surname
        {
            get
            {
                return Surname;
            }
            set
            {

            }
        }
    }
}
