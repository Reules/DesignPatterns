using MazeGame.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Door :  IMapSite
    {
        protected readonly Room _room1;
        protected readonly Room _room2;
        protected bool _isOpen;
        public Door(Room? room1 = null, Room? room2 = null)
        {
            _room1 = room1;
            _room2 = room2;
            _isOpen = false;
        }

        // Overridden Enter method
        public void Enter()
        {
            // Implementation of Enter method
        }

        // Method to get the NormalRoom object on the other side of the Door
        public Room OtherSideFrom(Room normalRoom)
        {
            // If the given NormalRoom is room1, return room2
            // Otherwise, return room1
            return (normalRoom == _room1) ? _room2 : _room1;
        }
    }
}
