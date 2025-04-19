using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Maze
    {


        private int Whdth;
        private int Hight;
        private Playes _player;
        private IMaze[,] mazeArray;
        public Maze(int whdth, int hight) {

            Whdth = whdth;
            Hight = hight;
            mazeArray = new IMaze[whdth, hight];
            _player = new Playes()
            {
                x = 1,
                y = 1, 
            };
             
        }

        public void Drow() {
            Console.Clear();    
          for (int  y= 0; y < Hight;y++)
            {
                
                for (int x = 0; x < Whdth; x++) {

                    if (x== 39  && y==19 )
                    {
                        mazeArray[x, y] = new EmptySpace();
                        Console.Write(mazeArray[x, y].Icone);
                    }
                    else if (x == 0 || y == 0 || x == Whdth - 1 || y == Hight - 1)
                    {
                        mazeArray[x, y] = new Wall();
                        Console.Write(mazeArray[x, y].Icone);
                    }
                    else if (x == _player.x && y == _player.y)
                    {
                        Console.Write(_player.Icone);
                    }
                    else if (x % 3 == 0 && y % 3 == 0)
                    {
                        mazeArray[x, y] = new Wall();
                        Console.Write(mazeArray[x, y].Icone);
                    }  else if (x % 5 == 0 && y % 5 == 0)
                    {
                        mazeArray[x, y] = new Wall();
                        Console.Write(mazeArray[x, y].Icone);
                    }
                    else
                    {
                        mazeArray[x, y] = new EmptySpace();
                        Console.Write(mazeArray[x, y].Icone);
                    }
                    
                }
                Console.WriteLine();
            }
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo userinpout = Console.ReadKey();
            ConsoleKey key = userinpout.Key;

            switch (key) {
                case ConsoleKey.UpArrow:
                    UpdatePlayers(0, -1);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayers(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayers(-1, 0);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayers(0,1);
                    break;
            }

        }
        private void UpdatePlayers(int dx  ,int dy) {
         int newx = _player.x + dx; 
        int newy = _player.y + dy;

            if (newx < Whdth && newx >=0 && newy >= 0 && newy < Hight  && mazeArray[newx,newy].isSoled== false) {
                _player.x = newx;
                _player.y = newy;
                Drow();
            }
        }
    }
}
