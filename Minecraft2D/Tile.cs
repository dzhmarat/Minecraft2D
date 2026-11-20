using Accessibility;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft2D
{
    public class Tile
    {
        public string Block {  get; set; }
        public Tile(string block, int x, int y)
        {
            if (block == "water")
            {
                Block = "water";
            }
            else if (block == "grass")
            {
                Block = "grass";
            }
            else
            {
                Block = "void";
            }  
        }
    }
}
