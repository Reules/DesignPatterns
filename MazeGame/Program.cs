namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director(new NormalMazeBuilder());
            Maze maze = director.CreateNormalMaze();
        }
    }
}
