using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public class PlayerBoard
    {
        public Player Player { get; set; }

        public List<Card> Exile { get; set; }
        public Stack<Card> Graveyard { get; set; }
        public Stack<Card> Library { get; set; }
        public List<Card> Hand { get; set; }
        public List<Mana> ManaPool { get; set; }
    }
}
