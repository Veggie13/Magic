using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public interface ITappable
    {
        bool Tapped { get; }
        bool TryToTap(Turn turn);
        void Untap();
    }

    public abstract class Tappable : ITappable
    {
        public Tappable()
        {
            Tapped = false;
        }

        public bool Tapped { get; private set; }

        public bool TryToTap(Turn turn)
        {
            if (Tapped || !onTryToTap(turn))
            {
                return false;
            }

            Tapped = true;
            return true;
        }

        public void Untap()
        {
            Tapped = false;
        }

        protected virtual bool onTryToTap(Turn turn)
        {
            return true;
        }
    }
}
