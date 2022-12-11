using MazeGame.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class NormalRoom : Room, IMapSite
    {
        public NormalRoom(int roomNo): base(roomNo)
        {
        }

        public override IMapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public override void SetSide(Direction direction, IMapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }

        public void Enter()
        {
            // Implementation of Enter method
        }
    }

}
