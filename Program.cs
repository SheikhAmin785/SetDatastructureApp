using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExampleApp
{

   public static void Main()
    {
        Hashtable mytable = new Hashtable();

        mytable.Add("name", "alamin");
        mytable.Add("rollnumber", 12);
        mytable.Add("address", "miami");
        Console.WriteLine(mytable["rollnumber"]);
    }

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
