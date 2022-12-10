using MazeGame.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Door : MapSite
    {
        // Constructor that accepts two Room objects as parameters
        // (or null if no Room object is specified)
        public Door(Room room1 = null, Room room2 = null)
        {
            // Initialize the room fields
            _room1 = room1;
            _room2 = room2;

            // Set the default value for the isOpen field
            _isOpen = false;
        }

        // Overridden Enter method
        public override void Enter()
        {
            // Implementation of Enter method
        }

        // Method to get the Room object on the other side of the Door
        public Room OtherSideFrom(Room room)
        {
            // If the given Room is room1, return room2
            // Otherwise, return room1
            return (room == _room1) ? _room2 : _room1;
        }

        // Fields to hold the two Room objects that the Door connects
        private readonly Room _room1;
        private readonly Room _room2;

        // Field to hold the Door's open/closed state
        private bool _isOpen;
    }
}
