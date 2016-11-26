using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEngine;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                Name = "Player1",
                HitPoints = 20
            };
            Land land = new Land(ManaColor.Black)
            {
                Controller = player
            };
            Board board = new Board()
            {
                PlayerBoards = new List<PlayerBoard>() {
                    new PlayerBoard()
                    {
                        Player = player,
                        ManaPool = new List<Mana>()
                    }
                },
                Battlefield = new List<Permanent>()
                {
                    land
                }
            };
            Turn turn = new Turn();

            bool success = land.TryToTap(turn);
            turn.CurrentStep.Resolve(board.PlayerBoards[0], board);
            turn.CurrentStep.UpdateActions(land);
            turn.CurrentStep.Resolve(board.PlayerBoards[0], board);
        }
    }
}
