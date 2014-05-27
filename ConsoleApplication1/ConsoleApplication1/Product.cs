using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Product
    {
        // Auto-implemented properties (data)
        public int Id { get ; set; } // int will have a default of zero
        public string Name { get; set; } // string has a default of null

        // Constructors (defines the different "ways" to make my objects)
        // parameterless constructor

        public Product()

        {
            //empty body - let the properties' values be their defaults
        }

        // greedy constructor
        public Product(int id, string name)
        
        {
            // simply store the information into my properties/fields
            Id = id;
            Name = name;

        }

        // virtual method - use "virtual" when you intend subclasses to "override" the behavior

        public virtual void Purchase()
        {
            // Temp - just output to console
            Console.WriteLine("Product Purchase {0}", Name);

        }

        // new machine


    }
}
