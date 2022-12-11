namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IMazeFactory factory = new NormalMazeFactory();
            Maze maze = factory.CreateMaze();

            Room room1 = factory.CreateRoom(1);
            Room room2 = factory.CreateRoom(2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            Door theDoor = factory.CreateDoor(room1, room2);

            // Set the walls and door for room 1
            room1.SetSide(Direction.North, factory.CreateWall());
            room1.SetSide(Direction.East, theDoor);
            room1.SetSide(Direction.South, factory.CreateWall());
            room1.SetSide(Direction.West, factory.CreateWall());

            // Set the walls and door for room 2
            room2.SetSide(Direction.North, factory.CreateWall());
            room2.SetSide(Direction.East, factory.CreateWall());
            room2.SetSide(Direction.South, factory.CreateWall());
            room2.SetSide(Direction.West, theDoor);
        }
    }
}
