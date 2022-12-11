using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGame.Abstractions;

namespace MazeGame
{
    internal interface IMazeFactory
    {
        Maze CreateMaze();
        Room CreateRoom(int roomNr);
        Wall CreateWall(Room? room1 = null, Room? room2 = null);
        Door CreateDoor();
    }
}
