using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_BekahHowe
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public SurfaceMaterials SurfaceMaterials { get; set; }

        public int RushOrder { get; set; }

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;

        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }
    enum SurfaceMaterials { oak = 200, laminate = 100, pine = 50, rosewood = 300, veneer = 125 };
}
