using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PJones.OEmbed;
using PJones.OEmbed.Providers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            OEmbedEngine engine = new OEmbedEngine();
            string result = engine.Parse(@"hello a b c d http://open.spotify.com/track/298gs9ATwr2rD9tGYJKlQR sooooooo so sooo def, 
                            this other youtube video here: https://www.youtube.com/watch?v=mGw_pxittJA 
                            <p>check this out: http://instagram.com/p/Y_BBAgBs4_/ </p>
                            <b>http://polldaddy.com/p/1323235/ </b>
                            <h3>Colbert Video</h3>
                            http://www.hulu.com/watch/493821"
             );
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
