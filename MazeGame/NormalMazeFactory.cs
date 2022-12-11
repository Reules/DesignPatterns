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

        // TODO: How to build the maze properly? Use builder pattern
        public Maze CreateMaze()
        {
            return new NormalMaze();
        }

        public Room CreateRoom(int roomNr)
        { 
            return new NormalRoom(roomNr);
        }

        public Door CreateDoor(Room? normalRoom1, Room? normalRoom2)
        { 
            return new Door(normalRoom1,normalRoom2); 
        }

        public Wall CreateWall()
        {
            return new Wall();
        }
    }
}
