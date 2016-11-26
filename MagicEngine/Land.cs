using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicEngine
{
    public class Land : Permanent
    {
        private ManaColor _color;

        public Land(ManaColor color)
        {
            _color = color;
        }

        public override IEnumerable<IResolvableAction> GetActions(UntapStep step)
        {
            yield break;
        }

        protected override bool onTryToTap(Turn turn)
        {
            turn.CurrentStep.Actions.Push(new ManaAction(_color));
            return true;
        }
    }
}
