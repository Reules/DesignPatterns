using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public abstract class Maze
    {
        protected readonly List<Room> _rooms;
        public Maze()
        {
            // Initialize the list of rooms
            _rooms = new List<Room>();
        }
        public abstract void AddRoom(Room room);
        public abstract Room GetRoom(int roomNumber);
    }
}
