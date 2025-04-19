using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Wall : IMaze
    {
        public char Icone { get => '#'; }
        public bool isSoled { get => true ; }
    }
}
