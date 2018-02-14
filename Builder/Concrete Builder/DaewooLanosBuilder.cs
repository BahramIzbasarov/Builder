using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class DaewooLanosBuilder : Builder
    {
        private Product product = new Product();

        public override void Engine()
        {
            product.Add("Engine - 98");
        }

        public override void Housing()
        {
            product.Add("Housing - Sedan");
        }

        public override void KPP()
        {
            product.Add("KPP - 5 Manual");
        }

        public override void Wheels()
        {
            product.Add("Wheels - 5 Manual");
        }
        public override Product GetResult()
        {
            return product;
        }
    }
}
