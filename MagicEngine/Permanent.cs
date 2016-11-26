using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicEngine
{
    public abstract class Permanent : Tappable, IPlayerControlled, IFromCard
    {
        public Player Controller { get; set; }
        public Card Source { get; set; }

        public abstract IEnumerable<IResolvableAction> GetActions(UntapStep step);

        public IEnumerable<IResolvableAction> GetActions(Step step)
        {
            throw new NotImplementedException();
        }
    }
}
