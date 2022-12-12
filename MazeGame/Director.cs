using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    internal class Director
    {
        private readonly MazeBuilder _builder;
        public Director(MazeBuilder builder)
        {
            _builder = builder;
        }

        public Maze CreateNormalMaze()
        {
            _builder.CreateMaze();
            _builder.BuildRoom();
            _builder.BuildDoor();
            _builder.BuildWall();
            return _builder.GetMaze();
        }
    }
}
