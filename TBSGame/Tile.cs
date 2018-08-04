using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace TBSGame
{
    class Tile : System.Windows.Forms.Control
    {
        int x;
        public int X
        {
            get => x;
            set => x = value;
        }

        public Tile(Image background, int x, int y)
      {

      }
    }
}
