using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public class UntapAction : IResolvableAction
    {
        #region IResolvableAction Members

        public void Resolve(PlayerBoard playerBoard, Board board)
        {
            foreach (var permanent in board.Battlefield.Where(p => p.Controller == playerBoard.Player))
            {
                permanent.Untap();
            }
        }

        #endregion
    }
}
