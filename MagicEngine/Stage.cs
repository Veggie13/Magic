using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public abstract class Stage
    {
        public abstract IEnumerable<Step> Steps { get; }
    }
}
