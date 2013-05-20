using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.SC.OEmbed;
using PJones.SC.OEmbed.Providers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Youtube yt = new Youtube();
            string result = yt.Process("hello a b c d https://www.youtube.com/watch?v=WQO-aOdJLiw sooooooo so sooo def");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
