namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to maze game!");
            Console.WriteLine("Hello Keyboard move the play");
            Maze maze = new Maze(40,20);
            while (true) {
                maze.Drow();
                maze.MovePlayer();
            }
            
        }
    }
}
