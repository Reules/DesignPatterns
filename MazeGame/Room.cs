using MazeGame.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Room : MapSite
    {
        public Room(int roomNo)
        {
            _roomNumber = roomNo;
            _sides = new MapSite[4];
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }

        public override void Enter()
        {
            // Implementation of Enter method
        }

        public readonly int _roomNumber;
        private readonly MapSite[] _sides;
    }

}
