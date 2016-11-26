using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    class ManaAction : IResolvableAction
    {
        private ManaColor _color;

        public ManaAction(ManaColor color)
        {
            _color = color;
        }

        #region IResolvableAction Members

        public void Resolve(PlayerBoard playerBoard, Board board)
        {
            playerBoard.ManaPool.Add(new Mana() { Color = _color });
        }

        #endregion
    }
}
