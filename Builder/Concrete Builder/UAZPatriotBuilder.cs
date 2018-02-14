using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class UAZPatriotBuilder : Builder
    {
        private Product product = new Product();

        public override void Housing()
        {
            product.Add("Housing - Wagon");
        }

        public override void Engine()
        {
            product.Add("Engine - 120");
        }

        public override void Wheels()
        {
            product.Add("Wheels - 16");
        }

        public override void KPP()
        {
            product.Add("KPP - 4 Manual");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
