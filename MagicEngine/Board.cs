using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public class Board
    {
        public List<Permanent> Battlefield { get; set; }

        public List<PlayerBoard> PlayerBoards { get; set; }
    }
}
