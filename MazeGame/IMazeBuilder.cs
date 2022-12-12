using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGame.Abstractions;

namespace MazeGame
{
    internal abstract class MazeBuilder
    {
        protected Maze Maze;
        
        public abstract void CreateMaze();
        public abstract void BuildRoom();
        public abstract void BuildWall();
        public abstract void BuildDoor(Room? room1 = null, Room? room2 = null);

        public Maze GetMaze()
        {
            return Maze;
        }
    }
}
