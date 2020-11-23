using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4_Students4CheapTexts.Models
{
    public class Textbooks
    {
        // declaring data members and getter/setter
        public string title { get; set; }

        public int ISBN { get; set; }

        public int version { get; set; }

        public int price { get; set; }

        // no parameter constructor
        public Textbooks()
        {

        }

        // full parameter custroctor
        public Textbooks(string title, int ISBN, int version, int price)
        {
            this.title = title;
            this.ISBN = ISBN;
            this.version = version;
            this.price = price;
        }

        public override string ToString()
        {
            return "Your textbook: " + this.title + ", version: " + this.version + " was appraised at: " + this.price;
        }
        /*
        public double calcValue(int price)
        {
            if (price > 1)
            {

            }
        }
        */
    }
}
