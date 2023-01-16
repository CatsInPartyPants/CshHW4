using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Morse morse = new Morse();
            string encoded = morse.Encode("HelloWorld");

            Console.WriteLine(encoded);

            Console.WriteLine(morse.Decode(encoded));
            */

            tictactoe tic = new tictactoe();
            tic.Show(); 

            Console.ReadKey();
        }
    }
}
