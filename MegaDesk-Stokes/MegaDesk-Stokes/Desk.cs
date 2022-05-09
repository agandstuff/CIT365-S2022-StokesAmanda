using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stokes
{
    public class Desk
    {
        public const int MAXWIDTH = 96;
        public const int MINWIDTH = 24;
        public const int MAXDEPTH = 48;
        public const int MINDEPTH = 12;

        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }

        public Desk(int width, int depth, int numDrawers, SurfaceMaterial SurfaceMaterial)
        {
            this.Width = width;
            this.Depth = depth;
            this.NumDrawers = numDrawers;
            this.SurfaceMaterial = SurfaceMaterial;
        }
    }

    public enum SurfaceMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
