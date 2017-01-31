using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Cars
    {

       private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Say()
        {
            Console.WriteLine("I Made in Germay");


        }


        }
    }

