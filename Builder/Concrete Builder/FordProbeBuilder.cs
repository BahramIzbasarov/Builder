using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FordProbeBuilder : Builder
    {
        private Product product = new Product();

        public override void Housing()
        {
            product.Add("Housing - Coupe");
        }

        public override void Engine()
        {
            product.Add("Engine - 160");
        }

        public override void Wheels()
        {
            product.Add("Wheels - 14");
        }

        public override void KPP()
        {
            product.Add("KPP - 4 Auto");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
