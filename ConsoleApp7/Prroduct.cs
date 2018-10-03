using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Prroduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        private Categorie categorie;

        public Prroduct(string name, int price, Categorie cat)
        {
            this.Name = name;
            this.Price = price;
            this.categorie = cat;
        }
    }
    
}