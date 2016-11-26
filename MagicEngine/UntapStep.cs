using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public class UntapStep : Step
    {
        public UntapStep() : base()
        {
            Actions.Push(new UntapAction());
        }
    }
}
