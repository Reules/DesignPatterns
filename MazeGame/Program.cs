namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IMazeFactory factory = new NormalMazeFactory();
            Maze maze = factory.CreateMaze();
        }
    }
}
