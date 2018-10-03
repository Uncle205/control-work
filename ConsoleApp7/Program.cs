using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ConsoleApp7
{
    class Program
    {

        static void Main(string[] args)
        {
            Categorie categ = new Categorie("Chemistry");
           
             string q;
            string num;
            Console.WriteLine("Enter num:1.Registation\n2.Product chose\n3.Shoplist\n4.Pay\n5.Category");
            num=Console.ReadLine();
            if (String.Equals(num ,"1"))
            {
                Employee Name = new Employee
                {
                    firstname = Console.ReadLine()
                };
                string phonenumber;
                Console.WriteLine("Enter phone");
               phonenumber= Console.ReadLine();
               
            }
            else if (num == "2")
            {
                Console.WriteLine("Choose the categorie:1.Chemistry\n2.Meals\n3.Cloth ");
                q = Console.ReadLine();
                int w;
                w =int.Parse(q);
                Categorie n = new Categorie
                {
                    num = w

                };
               
            }


        }
        
        
    }
}
