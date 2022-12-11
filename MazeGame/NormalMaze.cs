using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class NormalMaze : Maze
    {
        // Default constructor
        public NormalMaze() : base()
        {
        }

        // Method to add a NormalRoom to the Maze
        public override void AddRoom(Room normalRoom)
        {
            // Add the NormalRoom to the list of rooms
            _rooms.Add(normalRoom);
        }

        // Method to get the NormalRoom with a given normalRoom number
        public override Room GetRoom(int roomNo)
        {
            // Return the NormalRoom with the given normalRoom number
            return _rooms.FirstOrDefault(r => r._roomNumber == roomNo);
        }
    }

}
