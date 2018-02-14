using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            Builder Lanos = new DaewooLanosBuilder();
            Builder Probe = new FordProbeBuilder();
            Builder Patriot = new UAZPatriotBuilder();

            shop.Construct(Lanos);
            Product lonasProduct = Lanos.GetResult();

            lonasProduct.Show();

        }
    }
}
