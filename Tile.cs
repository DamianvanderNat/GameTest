using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class Tile
    {

        public string Welcome { get; set; }
    
        public int tileType; // 0=Lab, 1=ice, 2=tundra, 3=sea, 4=mountain, 5=desert, 6=grassland, 7=forest, 8=fort, 9=village, 10=vulcanic, 11=farm, 12=swamp, 13=savannah, 14=elf forest
    }

    public class TileType
    {
//       public string imageFilename { get; set; }
        public int id; // 0=Lab, 1=ice, 2=tundra, 3=sea, 4=mountain, 5=desert, 6=grassland, 7=forest, 8=fort, 9=village, 10=vulcanic, 11=farm, 12=swamp, 13=savannah, 14=elf forest

    }
}
