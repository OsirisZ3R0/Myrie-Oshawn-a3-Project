using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_game
{
    public class Crosshair
    {
        public void DrawCrosshair (float x, float y)
        {
            Draw.LineSize = 4;
            Draw.LineColor = Color.Red;

            Draw.Line(x - 50, y, x + 50, y);
            Draw.Line(x, y - 50, x, y + 50);
        }
         
      
    }
}
