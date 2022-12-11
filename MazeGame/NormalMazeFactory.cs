using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGame.Abstractions;

namespace MazeGame
{
    internal class NormalMazeFactory : IMazeFactory
    {
        public Maze CreateMaze()
        {
            Maze normalMaze = new NormalMaze();

            // Create two NormalRoom objects
            var r1 = new NormalRoom(1);
            var r2 = new NormalRoom(2);

            // Create a Door that connects the two rooms
            var theDoor = new Door(r1, r2);

            // Add the rooms to the Maze
            normalMaze.AddRoom(r1);
            normalMaze.AddRoom(r2);

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
            return normalMaze;
        }
    }
}
