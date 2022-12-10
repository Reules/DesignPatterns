using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class MazeGame
    {
        // Method to create a Maze
        public static Maze CreateMaze()
        {
            // Create a new Maze object
            var aMaze = new Maze();

            // Create two Room objects
            var r1 = new Room(1);
            var r2 = new Room(2);

            // Create a Door that connects the two rooms
            var theDoor = new Door(r1, r2);

            // Add the rooms to the Maze
            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            // Set the walls and door for room 1
            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            // Set the walls and door for room 2
            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, theDoor);

            // Return the Maze
            return aMaze;
        }
    }

}
