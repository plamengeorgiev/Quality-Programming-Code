using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeBlock
{
    class BooleanWriter
    {
        const int MAX_COUNT = 6;

        class Writer
        {
            public void Write(bool flag)
            {
                string flagToString = flag.ToString();
                Console.WriteLine(flagToString);
            }
        }

        public static void Main()
        {
            Writer writer = new Writer();
            writer.Write(true);
        }
    }
}
