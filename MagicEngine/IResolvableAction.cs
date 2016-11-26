using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public interface IResolvableAction
    {
        void Resolve(PlayerBoard playerBoard, Board board);
    }
}
