using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCodeBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCreator personCreator = new PersonCreator();
            personCreator.CreatePerson(2);
            personCreator.CreatePerson(3);
        }
    }
}
