using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEngine
{
    public class Turn
    {
        enum StageId
        {
            Beginning
        }

        private Dictionary<StageId, Stage> _stages;

        public Turn()
        {
            _stages = new Dictionary<StageId, Stage>();
            _stages[StageId.Beginning] = new BeginningStage();

            CurrentStage = _stages[StageId.Beginning];
            CurrentStep = CurrentStage.Steps.First();
        }

        public IEnumerable<Stage> Stages { get; private set; }

        public Stage CurrentStage { get; private set; }

        public Step CurrentStep { get; private set; }

        public void Advance()
        {

        }
    }
}
