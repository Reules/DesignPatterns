using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Maze
    {
        // Default constructor
        public Maze()
        {
            // Initialize the list of rooms
            _rooms = new List<Room>();
        }

        // Method to add a Room to the Maze
        public void AddRoom(Room room)
        {
            // Add the Room to the list of rooms
            _rooms.Add(room);
        }

        // Method to get the Room with a given room number
        public Room GetRoom(int roomNo)
        {
            // Return the Room with the given room number
            return _rooms.FirstOrDefault(r => r._roomNumber == roomNo);
        }

        // List to hold the rooms in the Maze
        private readonly List<Room> _rooms;
    }

}
