using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGame.Abstractions;

namespace MazeGame
{
    public abstract class Room
    {
        public readonly int _roomNumber;
        protected readonly IMapSite[] _sides;

        public Room(int roomNumber)
        {
            _roomNumber = roomNumber;
            _sides = new IMapSite[4];
        }

        public abstract IMapSite GetSide(Direction direction);
        public abstract void SetSide(Direction direction, IMapSite mapSite);
    }
}
