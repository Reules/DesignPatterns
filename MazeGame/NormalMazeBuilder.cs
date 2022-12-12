using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MazeGame.Abstractions;

namespace MazeGame
{
    internal class NormalMazeBuilder : MazeBuilder
    {

        private Room room1;
        private Room room2;

        // TODO: How to build the maze properly? Use builder pattern
        public override void CreateMaze()
        {
            Maze = new NormalMaze();
        }

        public override void BuildRoom()
        {
            room1 = new NormalRoom(1);
            room2 = new NormalRoom(2);
            Maze.AddRoom(room1);
            Maze.AddRoom(room2);
           
        }

        public override void BuildDoor(Room? normalRoom1, Room? normalRoom2)
        { 
            var door = new Door(normalRoom1,normalRoom2);
            room1.SetSide(Direction.East, door);
            room2.SetSide(Direction.West, door);
        }

        public override void BuildWall()
        {
            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            // Set the walls and door for room 2
            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
        }
    }
}
