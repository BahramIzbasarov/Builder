using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
        public abstract void Housing();
        public abstract void Engine();
        public abstract void Wheels();
        public abstract void KPP();

        public abstract Product GetResult();
    }
}
