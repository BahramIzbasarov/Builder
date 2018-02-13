using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FordProbeBuilder : Builder
    {
        private Product products = new Product();

        public override void Housing()
        {
            throw new NotImplementedException();
        }

        public override void Engine()
        {
            throw new NotImplementedException();
        }

        public override void Wheels()
        {
            throw new NotImplementedException();
        }

        public override void KPP()
        {
            throw new NotImplementedException();
        }

        public override Product GetResult()
        {
            return products;
        }
    }
}
