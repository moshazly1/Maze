using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
 public  interface IMaze
    {
        char Icone { get;  } //the shape of the maze object
        bool isSoled { get;  } //Block
    }
}
