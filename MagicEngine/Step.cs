using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public abstract class Step
    {
        public Step()
        {
            Actions = new Stack<IResolvableAction>();
        }

        public Stack<IResolvableAction> Actions { get; set; }

        public void UpdateActions(Permanent permanent)
        {
            dynamic step = this;
            foreach (var action in permanent.GetActions(step))
            {
                Actions.Push(action);
            }
        }

        public void Resolve(PlayerBoard playerBoard, Board board)
        {
            while (Actions.Any())
            {
                Actions.Pop().Resolve(playerBoard, board);
            }
        }
    }
}
