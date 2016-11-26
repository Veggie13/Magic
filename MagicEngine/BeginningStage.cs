using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public class BeginningStage : Stage
    {
        public override IEnumerable<Step> Steps
        {
            get { return new Step[] { new UntapStep() }; }
        }
    }
}
