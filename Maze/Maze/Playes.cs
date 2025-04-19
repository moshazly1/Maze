using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Playes : IMaze
    {
        public int  x{get; set;}
        public int y{get; set;} 
        public char Icone { get=>'@' ;  }
        public bool isSoled { get =>true;  }
    }
}
